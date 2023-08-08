namespace EmployeeMgnt1
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpName_Tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpSal_Tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EmpGen_Cb = new System.Windows.Forms.ComboBox();
            this.EmpDep_Cb = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DOB_Tb = new System.Windows.Forms.DateTimePicker();
            this.JD = new System.Windows.Forms.DateTimePicker();
            this.EmpAdd_Btn = new System.Windows.Forms.Button();
            this.EmpUp_Btn = new System.Windows.Forms.Button();
            this.Emp_List = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Del_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.customButton2 = new EmployeeMgnt1.CustomButton();
            this.Sal_Btn = new EmployeeMgnt1.CustomButton();
            this.Deps_Btn = new EmployeeMgnt1.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_List)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(36, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = " Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EmpName_Tb
            // 
            this.EmpName_Tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpName_Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName_Tb.Location = new System.Drawing.Point(46, 197);
            this.EmpName_Tb.Margin = new System.Windows.Forms.Padding(5);
            this.EmpName_Tb.Name = "EmpName_Tb";
            this.EmpName_Tb.Size = new System.Drawing.Size(242, 28);
            this.EmpName_Tb.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(43, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(36, 289);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = " Employee Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(36, 461);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = " Employee Daily Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(43, 401);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Join Date";
            // 
            // EmpSal_Tb
            // 
            this.EmpSal_Tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpSal_Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSal_Tb.Location = new System.Drawing.Point(47, 487);
            this.EmpSal_Tb.Margin = new System.Windows.Forms.Padding(5);
            this.EmpSal_Tb.Name = "EmpSal_Tb";
            this.EmpSal_Tb.Size = new System.Drawing.Size(241, 28);
            this.EmpSal_Tb.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(36, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = " Employee Gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(131, 117);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // EmpGen_Cb
            // 
            this.EmpGen_Cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpGen_Cb.FormattingEnabled = true;
            this.EmpGen_Cb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGen_Cb.Location = new System.Drawing.Point(46, 253);
            this.EmpGen_Cb.Margin = new System.Windows.Forms.Padding(5);
            this.EmpGen_Cb.Name = "EmpGen_Cb";
            this.EmpGen_Cb.Size = new System.Drawing.Size(241, 30);
            this.EmpGen_Cb.TabIndex = 21;
            // 
            // EmpDep_Cb
            // 
            this.EmpDep_Cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDep_Cb.FormattingEnabled = true;
            this.EmpDep_Cb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpDep_Cb.Location = new System.Drawing.Point(47, 313);
            this.EmpDep_Cb.Margin = new System.Windows.Forms.Padding(5);
            this.EmpDep_Cb.Name = "EmpDep_Cb";
            this.EmpDep_Cb.Size = new System.Drawing.Size(241, 30);
            this.EmpDep_Cb.TabIndex = 22;
            // 
            // DOB_Tb
            // 
            this.DOB_Tb.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_Tb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB_Tb.Location = new System.Drawing.Point(46, 371);
            this.DOB_Tb.Margin = new System.Windows.Forms.Padding(5);
            this.DOB_Tb.Name = "DOB_Tb";
            this.DOB_Tb.Size = new System.Drawing.Size(241, 28);
            this.DOB_Tb.TabIndex = 23;
            this.DOB_Tb.ValueChanged += new System.EventHandler(this.DOB_ValueChanged);
            // 
            // JD
            // 
            this.JD.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.JD.Location = new System.Drawing.Point(47, 428);
            this.JD.Margin = new System.Windows.Forms.Padding(5);
            this.JD.Name = "JD";
            this.JD.Size = new System.Drawing.Size(241, 28);
            this.JD.TabIndex = 24;
            // 
            // EmpAdd_Btn
            // 
            this.EmpAdd_Btn.BackColor = System.Drawing.Color.SteelBlue;
            this.EmpAdd_Btn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.EmpAdd_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpAdd_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpAdd_Btn.ForeColor = System.Drawing.Color.White;
            this.EmpAdd_Btn.Location = new System.Drawing.Point(47, 543);
            this.EmpAdd_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.EmpAdd_Btn.Name = "EmpAdd_Btn";
            this.EmpAdd_Btn.Size = new System.Drawing.Size(105, 42);
            this.EmpAdd_Btn.TabIndex = 25;
            this.EmpAdd_Btn.Text = "Add";
            this.EmpAdd_Btn.UseVisualStyleBackColor = false;
            this.EmpAdd_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpUp_Btn
            // 
            this.EmpUp_Btn.BackColor = System.Drawing.Color.SteelBlue;
            this.EmpUp_Btn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.EmpUp_Btn.FlatAppearance.BorderSize = 0;
            this.EmpUp_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpUp_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpUp_Btn.ForeColor = System.Drawing.Color.White;
            this.EmpUp_Btn.Location = new System.Drawing.Point(183, 543);
            this.EmpUp_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.EmpUp_Btn.Name = "EmpUp_Btn";
            this.EmpUp_Btn.Size = new System.Drawing.Size(105, 42);
            this.EmpUp_Btn.TabIndex = 26;
            this.EmpUp_Btn.Text = "Update";
            this.EmpUp_Btn.UseVisualStyleBackColor = false;
            this.EmpUp_Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Emp_List
            // 
            this.Emp_List.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Emp_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Emp_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Emp_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.Emp_List.Location = new System.Drawing.Point(330, 197);
            this.Emp_List.Margin = new System.Windows.Forms.Padding(5);
            this.Emp_List.Name = "Emp_List";
            this.Emp_List.RowHeadersWidth = 62;
            this.Emp_List.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Emp_List.RowTemplate.Height = 31;
            this.Emp_List.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Emp_List.Size = new System.Drawing.Size(664, 318);
            this.Emp_List.TabIndex = 56;
            this.Emp_List.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Emp_List_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 628);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 28);
            this.panel2.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Employees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 92);
            this.panel1.TabIndex = 68;
            // 
            // Del_Btn
            // 
            this.Del_Btn.BackColor = System.Drawing.Color.IndianRed;
            this.Del_Btn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Del_Btn.FlatAppearance.BorderSize = 0;
            this.Del_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_Btn.ForeColor = System.Drawing.Color.White;
            this.Del_Btn.Location = new System.Drawing.Point(604, 543);
            this.Del_Btn.Margin = new System.Windows.Forms.Padding(5);
            this.Del_Btn.Name = "Del_Btn";
            this.Del_Btn.Size = new System.Drawing.Size(105, 42);
            this.Del_Btn.TabIndex = 69;
            this.Del_Btn.Text = "Delete";
            this.Del_Btn.UseVisualStyleBackColor = false;
            this.Del_Btn.Click += new System.EventHandler(this.Del_Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(800, 128);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 27);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 73;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(334, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.SteelBlue;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton2.Location = new System.Drawing.Point(796, 122);
            this.customButton2.Name = "customButton2";
            this.customButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customButton2.Size = new System.Drawing.Size(210, 40);
            this.customButton2.TabIndex = 74;
            this.customButton2.Text = "Logout";
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // Sal_Btn
            // 
            this.Sal_Btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Sal_Btn.FlatAppearance.BorderSize = 0;
            this.Sal_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sal_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sal_Btn.ForeColor = System.Drawing.Color.White;
            this.Sal_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sal_Btn.Location = new System.Drawing.Point(565, 122);
            this.Sal_Btn.Name = "Sal_Btn";
            this.Sal_Btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sal_Btn.Size = new System.Drawing.Size(210, 40);
            this.Sal_Btn.TabIndex = 72;
            this.Sal_Btn.Text = "Salary";
            this.Sal_Btn.UseVisualStyleBackColor = false;
            this.Sal_Btn.Click += new System.EventHandler(this.customButton1_Click_1);
            // 
            // Deps_Btn
            // 
            this.Deps_Btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Deps_Btn.FlatAppearance.BorderSize = 0;
            this.Deps_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deps_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deps_Btn.ForeColor = System.Drawing.Color.White;
            this.Deps_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deps_Btn.Location = new System.Drawing.Point(330, 121);
            this.Deps_Btn.Name = "Deps_Btn";
            this.Deps_Btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Deps_Btn.Size = new System.Drawing.Size(210, 40);
            this.Deps_Btn.TabIndex = 70;
            this.Deps_Btn.Text = "Department";
            this.Deps_Btn.UseVisualStyleBackColor = false;
            this.Deps_Btn.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 656);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sal_Btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Deps_Btn);
            this.Controls.Add(this.Del_Btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Emp_List);
            this.Controls.Add(this.EmpUp_Btn);
            this.Controls.Add(this.EmpAdd_Btn);
            this.Controls.Add(this.JD);
            this.Controls.Add(this.DOB_Tb);
            this.Controls.Add(this.EmpDep_Cb);
            this.Controls.Add(this.EmpGen_Cb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmpSal_Tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpName_Tb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmpUp_Btn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emp_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpName_Tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmpSal_Tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox EmpGen_Cb;
        private System.Windows.Forms.ComboBox EmpDep_Cb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker DOB_Tb;
        private System.Windows.Forms.DateTimePicker JD;
        private System.Windows.Forms.Button EmpAdd_Btn;
        private System.Windows.Forms.Button EmpUp_Btn;
        private System.Windows.Forms.DataGridView Emp_List;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Del_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton Sal_Btn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private CustomButton customButton2;
        private CustomButton Deps_Btn;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}