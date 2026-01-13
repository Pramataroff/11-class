namespace Zadacha_za_domashna_14._01._26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Namelbl = new System.Windows.Forms.Label();
            this.Surnamelbl = new System.Windows.Forms.Label();
            this.Interestslbl = new System.Windows.Forms.Label();
            this.Agediapasonlbl = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.maleradioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maleFemaleLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(12, 9);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(51, 20);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Name";
            // 
            // Surnamelbl
            // 
            this.Surnamelbl.AutoSize = true;
            this.Surnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surnamelbl.Location = new System.Drawing.Point(200, 7);
            this.Surnamelbl.Name = "Surnamelbl";
            this.Surnamelbl.Size = new System.Drawing.Size(74, 20);
            this.Surnamelbl.TabIndex = 1;
            this.Surnamelbl.Text = "Surname";
            this.Surnamelbl.Click += new System.EventHandler(this.Surnamelbl_Click);
            // 
            // Interestslbl
            // 
            this.Interestslbl.AutoSize = true;
            this.Interestslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Interestslbl.Location = new System.Drawing.Point(12, 111);
            this.Interestslbl.Name = "Interestslbl";
            this.Interestslbl.Size = new System.Drawing.Size(72, 20);
            this.Interestslbl.TabIndex = 2;
            this.Interestslbl.Text = "Interests";
            // 
            // Agediapasonlbl
            // 
            this.Agediapasonlbl.AutoSize = true;
            this.Agediapasonlbl.BackColor = System.Drawing.Color.White;
            this.Agediapasonlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agediapasonlbl.Location = new System.Drawing.Point(200, 111);
            this.Agediapasonlbl.Name = "Agediapasonlbl";
            this.Agediapasonlbl.Size = new System.Drawing.Size(107, 20);
            this.Agediapasonlbl.TabIndex = 3;
            this.Agediapasonlbl.Text = "Age diapason";
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Bernard MT Condensed", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(15, 201);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(123, 47);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // maleradioButton
            // 
            this.maleradioButton.AutoSize = true;
            this.maleradioButton.Location = new System.Drawing.Point(217, 220);
            this.maleradioButton.Name = "maleradioButton";
            this.maleradioButton.Size = new System.Drawing.Size(48, 17);
            this.maleradioButton.TabIndex = 5;
            this.maleradioButton.TabStop = true;
            this.maleradioButton.Text = "Male";
            this.maleradioButton.UseVisualStyleBackColor = true;
            this.maleradioButton.CheckedChanged += new System.EventHandler(this.maleradioButton_CheckedChanged);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(217, 243);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 8;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleRadioButton_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maleFemaleLbl
            // 
            this.maleFemaleLbl.AutoSize = true;
            this.maleFemaleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleFemaleLbl.Location = new System.Drawing.Point(213, 197);
            this.maleFemaleLbl.Name = "maleFemaleLbl";
            this.maleFemaleLbl.Size = new System.Drawing.Size(100, 20);
            this.maleFemaleLbl.TabIndex = 13;
            this.maleFemaleLbl.Text = "Male/Female";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(201, 140);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Zadacha_za_domashna_14._01._26.Properties.Resources._53c13b19ab536f60e040a97f91ca5c6b;
            this.pictureBox2.Location = new System.Drawing.Point(-45, -102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(439, 428);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 286);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maleFemaleLbl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleradioButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.Agediapasonlbl);
            this.Controls.Add(this.Interestslbl);
            this.Controls.Add(this.Surnamelbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fitness registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label Surnamelbl;
        private System.Windows.Forms.Label Interestslbl;
        private System.Windows.Forms.Label Agediapasonlbl;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.RadioButton maleradioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label maleFemaleLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

