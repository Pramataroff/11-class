namespace Project_11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.num_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.price_lbl = new System.Windows.Forms.Label();
            this.type_lbl = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.undo_btn = new System.Windows.Forms.Button();
            this.newType_lbl = new System.Windows.Forms.Label();
            this.AvailableTypes_lbl = new System.Windows.Forms.Label();
            this.newType_txt = new System.Windows.Forms.TextBox();
            this.currentItems_cmb = new System.Windows.Forms.ComboBox();
            this.listOfproducts = new System.Windows.Forms.ListBox();
            this.number_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.type_txt = new System.Windows.Forms.TextBox();
            this.addType_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num_lbl
            // 
            this.num_lbl.AutoSize = true;
            this.num_lbl.Location = new System.Drawing.Point(21, 41);
            this.num_lbl.Name = "num_lbl";
            this.num_lbl.Size = new System.Drawing.Size(41, 13);
            this.num_lbl.TabIndex = 0;
            this.num_lbl.Text = "Номер";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(21, 71);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(29, 13);
            this.name_lbl.TabIndex = 1;
            this.name_lbl.Text = "Име";
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.Location = new System.Drawing.Point(21, 97);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(57, 13);
            this.desc_lbl.TabIndex = 2;
            this.desc_lbl.Text = "Описание";
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(21, 129);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(62, 13);
            this.price_lbl.TabIndex = 3;
            this.price_lbl.Text = "Цена на кг";
            // 
            // type_lbl
            // 
            this.type_lbl.AutoSize = true;
            this.type_lbl.Location = new System.Drawing.Point(21, 162);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(26, 13);
            this.type_lbl.TabIndex = 4;
            this.type_lbl.Text = "Тип";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(24, 199);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Добави";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(105, 199);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 6;
            this.edit_btn.Text = "Редактирай";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(186, 199);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "Изтрий";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(64, 228);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Запази";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // undo_btn
            // 
            this.undo_btn.Location = new System.Drawing.Point(145, 228);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(75, 23);
            this.undo_btn.TabIndex = 9;
            this.undo_btn.Text = "Отказ";
            this.undo_btn.UseVisualStyleBackColor = true;
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);
            // 
            // newType_lbl
            // 
            this.newType_lbl.AutoSize = true;
            this.newType_lbl.Location = new System.Drawing.Point(21, 288);
            this.newType_lbl.Name = "newType_lbl";
            this.newType_lbl.Size = new System.Drawing.Size(47, 13);
            this.newType_lbl.TabIndex = 10;
            this.newType_lbl.Text = "Нов тип";
            // 
            // AvailableTypes_lbl
            // 
            this.AvailableTypes_lbl.AutoSize = true;
            this.AvailableTypes_lbl.Location = new System.Drawing.Point(16, 317);
            this.AvailableTypes_lbl.Name = "AvailableTypes_lbl";
            this.AvailableTypes_lbl.Size = new System.Drawing.Size(123, 13);
            this.AvailableTypes_lbl.TabIndex = 11;
            this.AvailableTypes_lbl.Text = "Съществуващи типове";
            // 
            // newType_txt
            // 
            this.newType_txt.Location = new System.Drawing.Point(74, 285);
            this.newType_txt.Name = "newType_txt";
            this.newType_txt.Size = new System.Drawing.Size(100, 20);
            this.newType_txt.TabIndex = 12;
            // 
            // currentItems_cmb
            // 
            this.currentItems_cmb.FormattingEnabled = true;
            this.currentItems_cmb.Location = new System.Drawing.Point(145, 314);
            this.currentItems_cmb.Name = "currentItems_cmb";
            this.currentItems_cmb.Size = new System.Drawing.Size(121, 21);
            this.currentItems_cmb.TabIndex = 13;
            // 
            // listOfproducts
            // 
            this.listOfproducts.FormattingEnabled = true;
            this.listOfproducts.Location = new System.Drawing.Point(298, 41);
            this.listOfproducts.Name = "listOfproducts";
            this.listOfproducts.Size = new System.Drawing.Size(188, 316);
            this.listOfproducts.TabIndex = 14;
            // 
            // number_txt
            // 
            this.number_txt.Location = new System.Drawing.Point(105, 38);
            this.number_txt.Name = "number_txt";
            this.number_txt.Size = new System.Drawing.Size(100, 20);
            this.number_txt.TabIndex = 15;
            this.number_txt.TextChanged += new System.EventHandler(this.number_txt_TextChanged);
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(105, 68);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 16;
            // 
            // desc_txt
            // 
            this.desc_txt.Location = new System.Drawing.Point(105, 94);
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(100, 20);
            this.desc_txt.TabIndex = 17;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(105, 126);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(100, 20);
            this.price_txt.TabIndex = 18;
            // 
            // type_txt
            // 
            this.type_txt.Location = new System.Drawing.Point(105, 159);
            this.type_txt.Name = "type_txt";
            this.type_txt.Size = new System.Drawing.Size(100, 20);
            this.type_txt.TabIndex = 19;
            // 
            // addType_btn
            // 
            this.addType_btn.Location = new System.Drawing.Point(180, 285);
            this.addType_btn.Name = "addType_btn";
            this.addType_btn.Size = new System.Drawing.Size(75, 23);
            this.addType_btn.TabIndex = 20;
            this.addType_btn.Text = "Добави тип";
            this.addType_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 375);
            this.Controls.Add(this.addType_btn);
            this.Controls.Add(this.type_txt);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.desc_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.number_txt);
            this.Controls.Add(this.listOfproducts);
            this.Controls.Add(this.currentItems_cmb);
            this.Controls.Add(this.newType_txt);
            this.Controls.Add(this.AvailableTypes_lbl);
            this.Controls.Add(this.newType_lbl);
            this.Controls.Add(this.undo_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.type_lbl);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.desc_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.num_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label type_lbl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.Label newType_lbl;
        private System.Windows.Forms.Label AvailableTypes_lbl;
        private System.Windows.Forms.TextBox newType_txt;
        private System.Windows.Forms.ComboBox currentItems_cmb;
        private System.Windows.Forms.ListBox listOfproducts;
        private System.Windows.Forms.TextBox number_txt;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox desc_txt;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox type_txt;
        private System.Windows.Forms.Button addType_btn;
    }
}

