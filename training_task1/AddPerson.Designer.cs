namespace training_task1
{
    partial class AddPerson
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.canselButton = new System.Windows.Forms.Button();
            this.deptCheckBox = new System.Windows.Forms.CheckBox();
            this.expellCheckBox = new System.Windows.Forms.CheckBox();
            this.avrMarkUpDown = new System.Windows.Forms.NumericUpDown();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avrMarkUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Image = global::training_task1.Properties.Resources.people_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Форма добавления информации о студенте";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Внимательно заполните форму ниже:";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(139, 16);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // canselButton
            // 
            this.canselButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canselButton.Location = new System.Drawing.Point(220, 16);
            this.canselButton.Name = "canselButton";
            this.canselButton.Size = new System.Drawing.Size(75, 23);
            this.canselButton.TabIndex = 13;
            this.canselButton.Text = "Отмена";
            this.canselButton.UseVisualStyleBackColor = true;
            // 
            // deptCheckBox
            // 
            this.deptCheckBox.AutoSize = true;
            this.deptCheckBox.Location = new System.Drawing.Point(110, 226);
            this.deptCheckBox.Name = "deptCheckBox";
            this.deptCheckBox.Size = new System.Drawing.Size(135, 17);
            this.deptCheckBox.TabIndex = 23;
            this.deptCheckBox.Text = "Имеет задолженость";
            this.deptCheckBox.UseVisualStyleBackColor = true;
            // 
            // expellCheckBox
            // 
            this.expellCheckBox.AutoSize = true;
            this.expellCheckBox.Location = new System.Drawing.Point(110, 249);
            this.expellCheckBox.Name = "expellCheckBox";
            this.expellCheckBox.Size = new System.Drawing.Size(74, 17);
            this.expellCheckBox.TabIndex = 22;
            this.expellCheckBox.Text = "Отчислен";
            this.expellCheckBox.UseVisualStyleBackColor = true;
            // 
            // avrMarkUpDown
            // 
            this.avrMarkUpDown.DecimalPlaces = 1;
            this.avrMarkUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.avrMarkUpDown.Location = new System.Drawing.Point(110, 189);
            this.avrMarkUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.avrMarkUpDown.Name = "avrMarkUpDown";
            this.avrMarkUpDown.Size = new System.Drawing.Size(177, 20);
            this.avrMarkUpDown.TabIndex = 20;
            this.avrMarkUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(110, 163);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(177, 20);
            this.birthDatePicker.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ф. И. О. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пол:";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(110, 110);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(177, 20);
            this.fioTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Дата рождения:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(110, 136);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(177, 21);
            this.genderComboBox.TabIndex = 18;
            this.genderComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.genderComboBox_DrawItem);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Средняя оценка:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 86);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.canselButton);
            this.panel2.Controls.Add(this.okButton);
            this.panel2.Location = new System.Drawing.Point(0, 286);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 55);
            this.panel2.TabIndex = 25;
            // 
            // AddPerson
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.canselButton;
            this.ClientSize = new System.Drawing.Size(307, 341);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deptCheckBox);
            this.Controls.Add(this.expellCheckBox);
            this.Controls.Add(this.avrMarkUpDown);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddPerson";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avrMarkUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button canselButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.DateTimePicker birthDatePicker;
        private System.Windows.Forms.NumericUpDown avrMarkUpDown;
        private System.Windows.Forms.CheckBox deptCheckBox;
        private System.Windows.Forms.CheckBox expellCheckBox;
    }
}