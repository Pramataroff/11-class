using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_11.Controller;

namespace Project_11
{
    public partial class Form1 : Form
    {
        static GreensController _controller = new GreensController();

        private int? _selectedVegetableId = null;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTypes();
            LoadVegetables();
        }

        private void LoadVegetables()
        {
            listOfproducts.Items.Clear();

            List<Vegetable> list = _controller.GetAllVegetables();
            foreach (Vegetable veg in list)
                listOfproducts.Items.Add(new VegetableListItem(veg));
        }

        private void LoadTypes()
        {
            List<VegetableType> types = _controller.GetAllTypes();

            type_cmb.DataSource = null;
            type_cmb.DataSource = new List<VegetableType>(types);
            type_cmb.DisplayMember = "Name";
            type_cmb.ValueMember = "Id";

            currentItems_cmb.DataSource = null;
            currentItems_cmb.DataSource = new List<VegetableType>(types);
            currentItems_cmb.DisplayMember = "Name";
            currentItems_cmb.ValueMember = "Id";
        }

        private void listOfproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfproducts.SelectedItem is VegetableListItem item)
            {
                Vegetable veg = item.Vegetable;
                _selectedVegetableId = veg.Id;

                number_txt.Text = veg.Id.ToString();
                name_txt.Text = veg.Name;
                desc_txt.Text = veg.Description;
                price_txt.Text = veg.Price.ToString("F2");

                // Избира съответния тип в type_cmb
                foreach (VegetableType t in type_cmb.Items)
                {
                    if (t.Id == veg.VegetableTypeId)
                    {
                        type_cmb.SelectedItem = t;
                        break;
                    }
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string name = name_txt.Text.Trim();
            string desc = desc_txt.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Полето \"Име\" е задължително.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                name_txt.Focus();
                return;
            }

            if (!decimal.TryParse(price_txt.Text.Trim().Replace(',', '.'),
                                  System.Globalization.NumberStyles.Any,
                                  System.Globalization.CultureInfo.InvariantCulture,
                                  out decimal price) || price < 0)
            {
                MessageBox.Show("Въведете валидна цена (число >= 0).", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                price_txt.Focus();
                return;
            }

            if (!(type_cmb.SelectedItem is VegetableType selectedType))
            {
                MessageBox.Show("Изберете тип от падащия списък.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                type_cmb.Focus();
                return;
            }

            try
            {
                _controller.AddVegetable(new Vegetable
                {
                    Name = name,
                    Description = desc,
                    Price = price,
                    VegetableTypeId = selectedType.Id
                });

                LoadVegetables();
                ClearFields();
                MessageBox.Show("Продуктът беше добавен успешно.", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Грешка при добавяне", ex);
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (_selectedVegetableId == null)
            {
                MessageBox.Show("Изберете продукт от списъка за редактиране.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = name_txt.Text.Trim();
            string desc = desc_txt.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Полето \"Име\" е задължително.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                name_txt.Focus();
                return;
            }

            if (!decimal.TryParse(price_txt.Text.Trim().Replace(',', '.'),
                                  System.Globalization.NumberStyles.Any,
                                  System.Globalization.CultureInfo.InvariantCulture,
                                  out decimal price) || price < 0)
            {
                MessageBox.Show("Въведете валидна цена (число >= 0).", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                price_txt.Focus();
                return;
            }

            if (!(type_cmb.SelectedItem is VegetableType selectedType))
            {
                MessageBox.Show("Изберете тип от падащия списък.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                type_cmb.Focus();
                return;
            }

            try
            {
                _controller.UpdateVegetable(new Vegetable
                {
                    Id = _selectedVegetableId.Value,
                    Name = name,
                    Description = desc,
                    Price = price,
                    VegetableTypeId = selectedType.Id
                });

                LoadVegetables();
                ClearFields();
                MessageBox.Show("Продуктът беше редактиран успешно.", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Грешка при редактиране", ex);
            }
        }

        // ══════════════════════════════════════════════════════════════════════
        // ИЗТРИЙ ПРОДУКТ
        // ══════════════════════════════════════════════════════════════════════
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (_selectedVegetableId == null)
            {
                MessageBox.Show("Изберете продукт от списъка за изтриване.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Сигурни ли сте, че искате да изтриете този продукт?",
                "Потвърждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer != DialogResult.Yes) return;

            try
            {
                _controller.DeleteVegetable(_selectedVegetableId.Value);
                LoadVegetables();
                ClearFields();
                MessageBox.Show("Продуктът беше изтрит.", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Грешка при изтриване", ex);
            }
        }

        // ══════════════════════════════════════════════════════════════════════
        // ОТКАЗ – изчиства полетата
        // ══════════════════════════════════════════════════════════════════════
        private void undo_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // ══════════════════════════════════════════════════════════════════════
        // ДОБАВИ НОВ ТИП
        // ══════════════════════════════════════════════════════════════════════
        private void addType_btn_Click(object sender, EventArgs e)
        {
            string typeName = newType_txt.Text.Trim();

            if (string.IsNullOrEmpty(typeName))
            {
                MessageBox.Show("Въведете име на новия тип.", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newType_txt.Focus();
                return;
            }

            try
            {
                _controller.AddVegetableType(new VegetableType { Name = typeName });
                newType_txt.Clear();
                LoadTypes();
                MessageBox.Show($"Типът \"{typeName}\" беше добавен.", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowError("Грешка при добавяне на тип", ex);
            }
        }

        // ══════════════════════════════════════════════════════════════════════
        // ПРАЗНИ ОБРАБОТЧИЦИ (генерирани от дизайнера – не се трият)
        // ══════════════════════════════════════════════════════════════════════
        private void number_txt_TextChanged(object sender, EventArgs e) { }
        private void name_txt_TextChanged(object sender, EventArgs e) { }
        private void desc_txt_TextChanged(object sender, EventArgs e) { }
        private void price_txt_TextChanged(object sender, EventArgs e) { }
        private void newType_lbl_Click(object sender, EventArgs e) { }
        private void newType_txt_TextChanged(object sender, EventArgs e) { }
        private void currentItems_cmb_SelectedIndexChanged(object sender, EventArgs e) { }
        private void type_cmb_SelectedIndexChanged(object sender, EventArgs e) { }

        private void ClearFields()
        {
            _selectedVegetableId = null;
            number_txt.Clear();
            name_txt.Clear();
            desc_txt.Clear();
            price_txt.Clear();
            listOfproducts.ClearSelected();

            if (type_cmb.Items.Count > 0)
                type_cmb.SelectedIndex = 0;

            if (currentItems_cmb.Items.Count > 0)
                currentItems_cmb.SelectedIndex = 0;
        }

        private void ShowError(string context, Exception ex)
        {
            MessageBox.Show($"{context}:\n{ex.Message}", "Грешка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private class VegetableListItem
        {
            public Vegetable Vegetable { get; }

            public VegetableListItem(Vegetable veg) { Vegetable = veg; }

            public override string ToString() => $"{Vegetable.Id} - {Vegetable.Name}";
        }
    }
}