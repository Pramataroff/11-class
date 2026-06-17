using System;

namespace Project_11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Declarations ────────────────────────────────────────────────
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbl_appTitle = new System.Windows.Forms.Label();
            this.lbl_appSubtitle = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();

            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.num_lbl = new System.Windows.Forms.Label();
            this.number_txt = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.price_lbl = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.type_lbl = new System.Windows.Forms.Label();
            this.type_cmb = new System.Windows.Forms.ComboBox();

            this.grpActions = new System.Windows.Forms.GroupBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.undo_btn = new System.Windows.Forms.Button();

            this.grpTypes = new System.Windows.Forms.GroupBox();
            this.newType_lbl = new System.Windows.Forms.Label();
            this.newType_txt = new System.Windows.Forms.TextBox();
            this.addType_btn = new System.Windows.Forms.Button();
            this.AvailableTypes_lbl = new System.Windows.Forms.Label();
            this.currentItems_cmb = new System.Windows.Forms.ComboBox();

            this.grpList = new System.Windows.Forms.GroupBox();
            this.listOfproducts = new System.Windows.Forms.ListBox();
            this.lbl_listHint = new System.Windows.Forms.Label();

            this.pnlHeader.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpTypes.SuspendLayout();
            this.grpList.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════
            // FORM
            // ════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 580);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Text = "Greens — Зеленчукова борса";
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 234);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);

            // ════════════════════════════════════════════════════════════════
            // HEADER PANEL
            // ════════════════════════════════════════════════════════════════
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(820, 72);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 78, 36);
            this.pnlHeader.Controls.Add(this.lbl_appTitle);
            this.pnlHeader.Controls.Add(this.lbl_appSubtitle);

            this.lbl_appTitle.AutoSize = false;
            this.lbl_appTitle.Location = new System.Drawing.Point(20, 10);
            this.lbl_appTitle.Size = new System.Drawing.Size(500, 32);
            this.lbl_appTitle.Text = "🌿  GREENS — Зеленчукова борса";
            this.lbl_appTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_appTitle.ForeColor = System.Drawing.Color.White;

            this.lbl_appSubtitle.AutoSize = false;
            this.lbl_appSubtitle.Location = new System.Drawing.Point(22, 44);
            this.lbl_appSubtitle.Size = new System.Drawing.Size(500, 18);
            this.lbl_appSubtitle.Text = "Управление на продукти и типове";
            this.lbl_appSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_appSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 220, 170);

            // ════════════════════════════════════════════════════════════════
            // LEFT PANEL  (форма + действия + типове)
            // ════════════════════════════════════════════════════════════════
            this.pnlLeft.Location = new System.Drawing.Point(12, 84);
            this.pnlLeft.Size = new System.Drawing.Size(370, 484);
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.grpProduct);
            this.pnlLeft.Controls.Add(this.grpActions);
            this.pnlLeft.Controls.Add(this.grpTypes);

            // ── grpProduct ──────────────────────────────────────────────────
            this.grpProduct.Location = new System.Drawing.Point(0, 0);
            this.grpProduct.Size = new System.Drawing.Size(370, 228);
            this.grpProduct.Text = "  Данни за продукта";
            this.grpProduct.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpProduct.ForeColor = System.Drawing.Color.FromArgb(33, 78, 36);
            this.grpProduct.BackColor = System.Drawing.Color.White;
            this.grpProduct.Padding = new System.Windows.Forms.Padding(10);
            this.grpProduct.Controls.Add(this.num_lbl);
            this.grpProduct.Controls.Add(this.number_txt);
            this.grpProduct.Controls.Add(this.name_lbl);
            this.grpProduct.Controls.Add(this.name_txt);
            this.grpProduct.Controls.Add(this.desc_lbl);
            this.grpProduct.Controls.Add(this.desc_txt);
            this.grpProduct.Controls.Add(this.price_lbl);
            this.grpProduct.Controls.Add(this.price_txt);
            this.grpProduct.Controls.Add(this.type_lbl);
            this.grpProduct.Controls.Add(this.type_cmb);

            StyleLabel(this.num_lbl, "Номер", new System.Drawing.Point(14, 34));
            StyleLabel(this.name_lbl, "Име", new System.Drawing.Point(14, 68));
            StyleLabel(this.desc_lbl, "Описание", new System.Drawing.Point(14, 102));
            StyleLabel(this.price_lbl, "Цена (€/кг)", new System.Drawing.Point(14, 136));
            StyleLabel(this.type_lbl, "Тип", new System.Drawing.Point(14, 172));

            StyleTextBox(this.number_txt, new System.Drawing.Point(140, 31), true);
            StyleTextBox(this.name_txt, new System.Drawing.Point(140, 65), false);
            StyleTextBox(this.desc_txt, new System.Drawing.Point(140, 99), false);
            StyleTextBox(this.price_txt, new System.Drawing.Point(140, 133), false);

            this.type_cmb.Location = new System.Drawing.Point(140, 168);
            this.type_cmb.Size = new System.Drawing.Size(210, 24);
            this.type_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.type_cmb.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.type_cmb.SelectedIndexChanged += new System.EventHandler(this.type_cmb_SelectedIndexChanged);

            this.number_txt.TextChanged += new System.EventHandler(this.number_txt_TextChanged);
            this.name_txt.TextChanged += new System.EventHandler(this.name_txt_TextChanged);
            this.desc_txt.TextChanged += new System.EventHandler(this.desc_txt_TextChanged);
            this.price_txt.TextChanged += new System.EventHandler(this.price_txt_TextChanged);

            // ── grpActions ──────────────────────────────────────────────────
            this.grpActions.Location = new System.Drawing.Point(0, 238);
            this.grpActions.Size = new System.Drawing.Size(370, 78);
            this.grpActions.Text = "  Действия";
            this.grpActions.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpActions.ForeColor = System.Drawing.Color.FromArgb(33, 78, 36);
            this.grpActions.BackColor = System.Drawing.Color.White;
            this.grpActions.Controls.Add(this.add_btn);
            this.grpActions.Controls.Add(this.edit_btn);
            this.grpActions.Controls.Add(this.delete_btn);
            this.grpActions.Controls.Add(this.undo_btn);

            StyleActionButton(this.add_btn, "➕  Добави", new System.Drawing.Point(10, 28),
                              System.Drawing.Color.FromArgb(46, 125, 50));
            StyleActionButton(this.edit_btn, "✏  Редактирай", new System.Drawing.Point(108, 28),
                              System.Drawing.Color.FromArgb(21, 101, 192));
            StyleActionButton(this.delete_btn, "🗑  Изтрий", new System.Drawing.Point(228, 28),
                              System.Drawing.Color.FromArgb(183, 28, 28));
            StyleActionButton(this.undo_btn, "✖  Отказ", new System.Drawing.Point(316, 28),
                              System.Drawing.Color.FromArgb(97, 97, 97));

            this.add_btn.Size = new System.Drawing.Size(90, 34);
            this.edit_btn.Size = new System.Drawing.Size(112, 34);
            this.delete_btn.Size = new System.Drawing.Size(82, 34);
            this.undo_btn.Size = new System.Drawing.Size(42, 34);
            this.undo_btn.Text = "✖";

            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);

            // ── grpTypes ────────────────────────────────────────────────────
            this.grpTypes.Location = new System.Drawing.Point(0, 326);
            this.grpTypes.Size = new System.Drawing.Size(370, 116);
            this.grpTypes.Text = "  Управление на типове";
            this.grpTypes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTypes.ForeColor = System.Drawing.Color.FromArgb(33, 78, 36);
            this.grpTypes.BackColor = System.Drawing.Color.White;
            this.grpTypes.Controls.Add(this.newType_lbl);
            this.grpTypes.Controls.Add(this.newType_txt);
            this.grpTypes.Controls.Add(this.addType_btn);
            this.grpTypes.Controls.Add(this.AvailableTypes_lbl);
            this.grpTypes.Controls.Add(this.currentItems_cmb);

            StyleLabel(this.newType_lbl, "Нов тип:", new System.Drawing.Point(14, 32));
            StyleLabel(this.AvailableTypes_lbl, "Съществуващи:", new System.Drawing.Point(14, 74));

            this.newType_txt.Location = new System.Drawing.Point(100, 29);
            this.newType_txt.Size = new System.Drawing.Size(140, 24);
            this.newType_txt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.newType_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newType_txt.TextChanged += new System.EventHandler(this.newType_txt_TextChanged);

            StyleActionButton(this.addType_btn, "➕  Добави тип",
                              new System.Drawing.Point(248, 28),
                              System.Drawing.Color.FromArgb(46, 125, 50));
            this.addType_btn.Size = new System.Drawing.Size(110, 28);
            this.addType_btn.Click += new System.EventHandler(this.addType_btn_Click);

            this.currentItems_cmb.Location = new System.Drawing.Point(140, 71);
            this.currentItems_cmb.Size = new System.Drawing.Size(218, 24);
            this.currentItems_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentItems_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentItems_cmb.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.currentItems_cmb.SelectedIndexChanged += new System.EventHandler(this.currentItems_cmb_SelectedIndexChanged);

            // ════════════════════════════════════════════════════════════════
            // RIGHT PANEL  (списък)
            // ════════════════════════════════════════════════════════════════
            this.pnlRight.Location = new System.Drawing.Point(394, 84);
            this.pnlRight.Size = new System.Drawing.Size(414, 484);
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.grpList);

            this.grpList.Location = new System.Drawing.Point(0, 0);
            this.grpList.Size = new System.Drawing.Size(414, 484);
            this.grpList.Text = "  Списък с продукти";
            this.grpList.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpList.ForeColor = System.Drawing.Color.FromArgb(33, 78, 36);
            this.grpList.BackColor = System.Drawing.Color.White;
            this.grpList.Controls.Add(this.lbl_listHint);
            this.grpList.Controls.Add(this.listOfproducts);

            this.lbl_listHint.AutoSize = false;
            this.lbl_listHint.Location = new System.Drawing.Point(10, 22);
            this.lbl_listHint.Size = new System.Drawing.Size(392, 18);
            this.lbl_listHint.Text = "Кликни върху продукт за да го зареди в полетата вляво";
            this.lbl_listHint.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lbl_listHint.ForeColor = System.Drawing.Color.FromArgb(140, 140, 140);

            this.listOfproducts.Location = new System.Drawing.Point(10, 44);
            this.listOfproducts.Size = new System.Drawing.Size(392, 428);
            this.listOfproducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfproducts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listOfproducts.ItemHeight = 26;
            this.listOfproducts.BackColor = System.Drawing.Color.White;
            this.listOfproducts.SelectedIndexChanged += new System.EventHandler(this.listOfproducts_SelectedIndexChanged);

            // ════════════════════════════════════════════════════════════════
            // ADD TO FORM
            // ════════════════════════════════════════════════════════════════
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);

            this.pnlHeader.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpTypes.ResumeLayout(false);
            this.grpTypes.PerformLayout();
            this.grpList.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // ── Design helpers ──────────────────────────────────────────────────

        private void StyleLabel(System.Windows.Forms.Label lbl, string text,
                                System.Drawing.Point loc)
        {
            lbl.AutoSize = true;
            lbl.Location = loc;
            lbl.Text = text;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(70, 70, 70);
        }

        private void StyleTextBox(System.Windows.Forms.TextBox txt,
                                  System.Drawing.Point loc, bool readOnly)
        {
            txt.Location = loc;
            txt.Size = new System.Drawing.Size(210, 24);
            txt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.ReadOnly = readOnly;
            txt.BackColor = readOnly
                              ? System.Drawing.Color.FromArgb(230, 238, 228)
                              : System.Drawing.Color.White;
        }

        private void StyleActionButton(System.Windows.Forms.Button btn, string text,
                                       System.Drawing.Point loc,
                                       System.Drawing.Color backColor)
        {
            btn.Location = loc;
            btn.Size = new System.Drawing.Size(90, 34);
            btn.Text = text;
            btn.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.BackColor = backColor;
            btn.ForeColor = System.Drawing.Color.White;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor =
                System.Drawing.Color.FromArgb(
                    Math.Min(backColor.R + 30, 255),
                    Math.Min(backColor.G + 30, 255),
                    Math.Min(backColor.B + 30, 255));
        }

        #endregion

        // Controls
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbl_appTitle;
        private System.Windows.Forms.Label lbl_appSubtitle;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.GroupBox grpTypes;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.Label num_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label type_lbl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.Label newType_lbl;
        private System.Windows.Forms.Label AvailableTypes_lbl;
        private System.Windows.Forms.TextBox newType_txt;
        private System.Windows.Forms.ComboBox currentItems_cmb;
        private System.Windows.Forms.ListBox listOfproducts;
        private System.Windows.Forms.Label lbl_listHint;
        private System.Windows.Forms.TextBox number_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox desc_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.Button addType_btn;
        private System.Windows.Forms.ComboBox type_cmb;
    }
}