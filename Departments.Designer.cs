namespace EmployeeMgnt1
{
    partial class Departments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            this.Add_Btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DepName_Tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dep_List = new System.Windows.Forms.DataGridView();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Emp_Btn = new EmployeeMgnt1.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sal_Btn = new EmployeeMgnt1.CustomButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.customButton2 = new EmployeeMgnt1.CustomButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dep_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Add_Btn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Btn.Location = new System.Drawing.Point(35, 526);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(137, 50);
            this.Add_Btn.TabIndex = 43;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Update_Btn
            // 
            this.Update_Btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Update_Btn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Update_Btn.FlatAppearance.BorderSize = 0;
            this.Update_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Btn.ForeColor = System.Drawing.Color.White;
            this.Update_Btn.Location = new System.Drawing.Point(184, 526);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(137, 50);
            this.Update_Btn.TabIndex = 44;
            this.Update_Btn.Text = "Update";
            this.Update_Btn.UseVisualStyleBackColor = false;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 20);
            this.panel2.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(30, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Department Name";
            // 
            // DepName_Tb
            // 
            this.DepName_Tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DepName_Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepName_Tb.Location = new System.Drawing.Point(35, 209);
            this.DepName_Tb.Name = "DepName_Tb";
            this.DepName_Tb.Size = new System.Drawing.Size(286, 35);
            this.DepName_Tb.TabIndex = 29;
            this.DepName_Tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Departments";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 92);
            this.panel1.TabIndex = 27;
            // 
            // Dep_List
            // 
            this.Dep_List.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dep_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dep_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dep_List.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dep_List.Location = new System.Drawing.Point(351, 209);
            this.Dep_List.Name = "Dep_List";
            this.Dep_List.RowHeadersWidth = 62;
            this.Dep_List.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dep_List.RowTemplate.Height = 31;
            this.Dep_List.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dep_List.Size = new System.Drawing.Size(655, 270);
            this.Dep_List.TabIndex = 55;
            this.Dep_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dep_List_CellContentClick);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.BackColor = System.Drawing.Color.IndianRed;
            this.Delete_Btn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Delete_Btn.FlatAppearance.BorderSize = 0;
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.ForeColor = System.Drawing.Color.White;
            this.Delete_Btn.Location = new System.Drawing.Point(629, 526);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(137, 50);
            this.Delete_Btn.TabIndex = 56;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = false;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(341, 126);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 71;
            this.pictureBox6.TabStop = false;
            // 
            // Emp_Btn
            // 
            this.Emp_Btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Emp_Btn.FlatAppearance.BorderSize = 0;
            this.Emp_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Emp_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_Btn.ForeColor = System.Drawing.Color.White;
            this.Emp_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Emp_Btn.Location = new System.Drawing.Point(337, 120);
            this.Emp_Btn.Name = "Emp_Btn";
            this.Emp_Btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Emp_Btn.Size = new System.Drawing.Size(210, 40);
            this.Emp_Btn.TabIndex = 72;
            this.Emp_Btn.Text = "Employee";
            this.Emp_Btn.UseVisualStyleBackColor = false;
            this.Emp_Btn.Click += new System.EventHandler(this.Emp_Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // Sal_Btn
            // 
            this.Sal_Btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Sal_Btn.FlatAppearance.BorderSize = 0;
            this.Sal_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sal_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_Btn.ForeColor = System.Drawing.Color.White;
            this.Sal_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sal_Btn.Location = new System.Drawing.Point(569, 120);
            this.Sal_Btn.Name = "Sal_Btn";
            this.Sal_Btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sal_Btn.Size = new System.Drawing.Size(210, 40);
            this.Sal_Btn.TabIndex = 74;
            this.Sal_Btn.Text = "Salary";
            this.Sal_Btn.UseVisualStyleBackColor = false;
            this.Sal_Btn.Click += new System.EventHandler(this.Sal_Btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(800, 126);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 75;
            this.pictureBox3.TabStop = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.SteelBlue;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton2.Location = new System.Drawing.Point(796, 120);
            this.customButton2.Name = "customButton2";
            this.customButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customButton2.Size = new System.Drawing.Size(210, 40);
            this.customButton2.TabIndex = 76;
            this.customButton2.Text = "Logout";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(114, 115);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 656);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sal_Btn);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Emp_Btn);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Dep_List);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DepName_Tb);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Departments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departments";
            this.Load += new System.EventHandler(this.Departments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dep_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_Btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DepName_Tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dep_List;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private CustomButton Emp_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton Sal_Btn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomButton customButton2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}