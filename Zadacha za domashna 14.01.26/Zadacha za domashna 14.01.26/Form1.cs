using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha_za_domashna_14._01._26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Back");
            comboBox1.Items.Add("Core");
            comboBox1.Items.Add("Chest");
            comboBox1.Items.Add("Biceps");

            comboBox2.Items.Add("age < 20");
            comboBox2.Items.Add("age > 20 and < 40");
            comboBox2.Items.Add("age > 40");
            comboBox2.Items.Add("age > 50");
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //name
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //surname
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // interests
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //age diapason
        {

        }

        private void maleradioButton_CheckedChanged(object sender, EventArgs e) //male
        {
           
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e) //female
        {
           
        }

        private void registerButton_Click(object sender, EventArgs e) // button for register
        {
            MessageBox.Show($"Congratulations, {textBox1.Text} {textBox2.Text} you just registered in our fitness for the next 30 days! " +
                $"\ntraining: {comboBox1.Text} \nage group: {comboBox2.Text}"); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Surnamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
