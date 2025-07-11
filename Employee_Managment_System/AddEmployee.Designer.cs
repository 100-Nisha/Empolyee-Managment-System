namespace Employee_Managment_System
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Employee = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployee_Import = new System.Windows.Forms.Button();
            this.addEmployee_picturebox = new System.Windows.Forms.PictureBox();
            this.addEmployee_clearbtn = new System.Windows.Forms.Button();
            this.addEmployee_deletebtn = new System.Windows.Forms.Button();
            this.addEmployee_updatebtn = new System.Windows.Forms.Button();
            this.addEmployee_addbtn = new System.Windows.Forms.Button();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployee_phoneno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmployee_fullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addEmployee_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Employee);
            this.panel1.Location = new System.Drawing.Point(23, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 337);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(33, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(818, 254);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Location = new System.Drawing.Point(16, 13);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(217, 30);
            this.Employee.TabIndex = 0;
            this.Employee.Text = "Employee\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addEmployee_status);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addEmployee_Import);
            this.panel2.Controls.Add(this.addEmployee_picturebox);
            this.panel2.Controls.Add(this.addEmployee_clearbtn);
            this.panel2.Controls.Add(this.addEmployee_deletebtn);
            this.panel2.Controls.Add(this.addEmployee_updatebtn);
            this.panel2.Controls.Add(this.addEmployee_addbtn);
            this.panel2.Controls.Add(this.addEmployee_position);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addEmployee_phoneno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addEmployee_gender);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addEmployee_fullName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.addEmployee_ID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(23, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 242);
            this.panel2.TabIndex = 1;
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Active ",
            "Inactive"});
            this.addEmployee_status.Location = new System.Drawing.Point(530, 125);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(214, 26);
            this.addEmployee_status.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Status:";
            // 
            // addEmployee_Import
            // 
            this.addEmployee_Import.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addEmployee_Import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_Import.FlatAppearance.BorderSize = 0;
            this.addEmployee_Import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.addEmployee_Import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.addEmployee_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_Import.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_Import.ForeColor = System.Drawing.Color.White;
            this.addEmployee_Import.Location = new System.Drawing.Point(779, 120);
            this.addEmployee_Import.Name = "addEmployee_Import";
            this.addEmployee_Import.Size = new System.Drawing.Size(82, 35);
            this.addEmployee_Import.TabIndex = 15;
            this.addEmployee_Import.Text = "Import";
            this.addEmployee_Import.UseVisualStyleBackColor = false;
            this.addEmployee_Import.Click += new System.EventHandler(this.AddEmployee_Import_Click);
            // 
            // addEmployee_picturebox
            // 
            this.addEmployee_picturebox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addEmployee_picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_picturebox.Location = new System.Drawing.Point(779, 27);
            this.addEmployee_picturebox.Name = "addEmployee_picturebox";
            this.addEmployee_picturebox.Size = new System.Drawing.Size(82, 94);
            this.addEmployee_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picturebox.TabIndex = 14;
            this.addEmployee_picturebox.TabStop = false;
            // 
            // addEmployee_clearbtn
            // 
            this.addEmployee_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addEmployee_clearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_clearbtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.addEmployee_clearbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.addEmployee_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_clearbtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_clearbtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_clearbtn.Location = new System.Drawing.Point(517, 186);
            this.addEmployee_clearbtn.Name = "addEmployee_clearbtn";
            this.addEmployee_clearbtn.Size = new System.Drawing.Size(137, 37);
            this.addEmployee_clearbtn.TabIndex = 13;
            this.addEmployee_clearbtn.Text = "Clear";
            this.addEmployee_clearbtn.UseVisualStyleBackColor = false;
            this.addEmployee_clearbtn.Click += new System.EventHandler(this.AddEmployee_clearbtn_Click);
            // 
            // addEmployee_deletebtn
            // 
            this.addEmployee_deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addEmployee_deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_deletebtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.addEmployee_deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.addEmployee_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_deletebtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_deletebtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_deletebtn.Location = new System.Drawing.Point(354, 186);
            this.addEmployee_deletebtn.Name = "addEmployee_deletebtn";
            this.addEmployee_deletebtn.Size = new System.Drawing.Size(137, 37);
            this.addEmployee_deletebtn.TabIndex = 12;
            this.addEmployee_deletebtn.Text = "Delete";
            this.addEmployee_deletebtn.UseVisualStyleBackColor = false;
            this.addEmployee_deletebtn.Click += new System.EventHandler(this.AddEmployee_deletebtn_Click);
            // 
            // addEmployee_updatebtn
            // 
            this.addEmployee_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addEmployee_updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_updatebtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.addEmployee_updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.addEmployee_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_updatebtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_updatebtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_updatebtn.Location = new System.Drawing.Point(193, 186);
            this.addEmployee_updatebtn.Name = "addEmployee_updatebtn";
            this.addEmployee_updatebtn.Size = new System.Drawing.Size(137, 37);
            this.addEmployee_updatebtn.TabIndex = 11;
            this.addEmployee_updatebtn.Text = "Update";
            this.addEmployee_updatebtn.UseVisualStyleBackColor = false;
            this.addEmployee_updatebtn.Click += new System.EventHandler(this.AddEmployee_updatebtn_Click);
            // 
            // addEmployee_addbtn
            // 
            this.addEmployee_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addEmployee_addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_addbtn.FlatAppearance.BorderSize = 0;
            this.addEmployee_addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.addEmployee_addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.addEmployee_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_addbtn.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_addbtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_addbtn.Location = new System.Drawing.Point(33, 186);
            this.addEmployee_addbtn.Name = "addEmployee_addbtn";
            this.addEmployee_addbtn.Size = new System.Drawing.Size(137, 37);
            this.addEmployee_addbtn.TabIndex = 10;
            this.addEmployee_addbtn.Text = "Add";
            this.addEmployee_addbtn.UseVisualStyleBackColor = false;
            this.addEmployee_addbtn.Click += new System.EventHandler(this.AddEmployee_addbtn_Click);
            // 
            // addEmployee_position
            // 
            this.addEmployee_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
            "Business Managemet",
            "Front-End Developer",
            "Back-End Developer",
            "Data Administrator",
            "UI/UX Design"});
            this.addEmployee_position.Location = new System.Drawing.Point(530, 77);
            this.addEmployee_position.Name = "addEmployee_position";
            this.addEmployee_position.Size = new System.Drawing.Size(214, 26);
            this.addEmployee_position.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Position:";
            // 
            // addEmployee_phoneno
            // 
            this.addEmployee_phoneno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_phoneno.Location = new System.Drawing.Point(530, 32);
            this.addEmployee_phoneno.Name = "addEmployee_phoneno";
            this.addEmployee_phoneno.Size = new System.Drawing.Size(214, 24);
            this.addEmployee_phoneno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number:";
            // 
            // addEmployee_gender
            // 
            this.addEmployee_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.addEmployee_gender.Location = new System.Drawing.Point(147, 127);
            this.addEmployee_gender.Name = "addEmployee_gender";
            this.addEmployee_gender.Size = new System.Drawing.Size(211, 26);
            this.addEmployee_gender.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gender:";
            // 
            // addEmployee_fullName
            // 
            this.addEmployee_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_fullName.Location = new System.Drawing.Point(147, 77);
            this.addEmployee_fullName.Name = "addEmployee_fullName";
            this.addEmployee_fullName.Size = new System.Drawing.Size(211, 24);
            this.addEmployee_fullName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // addEmployee_ID
            // 
            this.addEmployee_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_ID.Location = new System.Drawing.Point(147, 30);
            this.addEmployee_ID.Name = "addEmployee_ID";
            this.addEmployee_ID.Size = new System.Drawing.Size(211, 24);
            this.addEmployee_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(924, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addEmployee_Import;
        private System.Windows.Forms.PictureBox addEmployee_picturebox;
        private System.Windows.Forms.Button addEmployee_clearbtn;
        private System.Windows.Forms.Button addEmployee_deletebtn;
        private System.Windows.Forms.Button addEmployee_addbtn;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addEmployee_phoneno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployee_fullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEmployee_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEmployee_updatebtn;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.Label label6;
    }
}
