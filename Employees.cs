using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgnt1
{
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
            InitializeComponent();
            Con = new Functions();
            ShowEmployees();
            GetDepartmnent();

        }

        private void ShowEmployees()
        {
            try
            {
                string Query = "Select * from EmployeeTbl";
                Emp_List.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetDepartmnent()
        {
            string Query = "select * from DepartmentTbl";
            EmpDep_Cb.DisplayMember = Con.GetData(Query).Columns["DepName"].ToString();
            EmpDep_Cb.ValueMember = Con.GetData(Query).Columns["DepId"].ToString();
            EmpDep_Cb.DataSource = Con.GetData(Query);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // add button
        {
            try
            {
                if (EmpName_Tb.Text == "" || EmpGen_Cb.SelectedIndex == -1 || EmpDep_Cb.SelectedIndex == -1 || EmpSal_Tb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Name = EmpName_Tb.Text;
                    string Gender = EmpGen_Cb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(EmpDep_Cb.SelectedValue.ToString());
                    string DOB = DOB_Tb.Value.ToString("yyyy-MM-dd");
                    string JDate = JD.Value.ToString("yyyy-MM-dd");
                    int Salary = Convert.ToInt32(EmpSal_Tb.Text);
                    
                    string Query = "insert into EmployeeTbl values('{0}', '{1}', {2}, '{3}', '{4}', {5})";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Added");

                    // reset 
                    EmpName_Tb.Text = "";
                    EmpGen_Cb.SelectedIndex = -1;
                    EmpDep_Cb.SelectedIndex = -1; 
                    EmpSal_Tb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e) // Update
        {
            try
            {
                if (EmpName_Tb.Text == "" || EmpGen_Cb.SelectedIndex == -1 || EmpDep_Cb.SelectedIndex == -1 || EmpSal_Tb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Name = EmpName_Tb.Text;
                    string Gender = EmpGen_Cb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(EmpDep_Cb.SelectedValue.ToString());
                    string DOB = DOB_Tb.Value.ToString("yyyy-MM-dd");
                    string JDate = JD.Value.ToString("yyyy-MM-dd");
                    int Salary = Convert.ToInt32(EmpSal_Tb.Text);

                    string Query = "Update EmployeeTbl set EmpName = '{0}', EmpGen = '{1}', EmpDep = {2}, EmpDOB = '{3}', EmpJDate = '{4}', EmpSal = {5} where EmpId = {6}";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary, Key);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Added");

                    // reset 
                    EmpName_Tb.Text = "";
                    EmpGen_Cb.SelectedIndex = -1;
                    EmpDep_Cb.SelectedIndex = -1;
                    EmpSal_Tb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        int Key = 0; // Update Btn Key

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Emp_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Emp_List.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // click a cell to choose a row

            if (Emp_List.SelectedRows.Count > 0)
            {

                EmpName_Tb.Text = Emp_List.SelectedRows[0].Cells[1].Value.ToString();
                EmpGen_Cb.Text = Emp_List.SelectedRows[0].Cells[2].Value.ToString();
                EmpDep_Cb.Text = Emp_List.SelectedRows[0].Cells[3].Value.ToString();
                DOB_Tb.Text = Emp_List.SelectedRows[0].Cells[4].Value.ToString();
                JD.Text = Emp_List.SelectedRows[0].Cells[5].Value.ToString();
                EmpSal_Tb.Text = Emp_List.SelectedRows[0].Cells[6].Value.ToString();
                // MessageBox.Show(DepName_Tb.Text);
                if (EmpName_Tb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(Emp_List.SelectedRows[0].Cells[0].Value.ToString());
                }
            }

        }

        private void EmpUp_Btn_Load(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void Del_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data");
                }
                else
                { 
                    string Query = "Delete from EmployeeTbl where EmpId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    ShowEmployees();
                    MessageBox.Show("Employee Deleted");

                    // reset 
                    EmpName_Tb.Text = "";
                    EmpGen_Cb.SelectedIndex = -1;
                    EmpDep_Cb.SelectedIndex = -1;
                    EmpSal_Tb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e) // Department Btn
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();

        }

        

        private void customButton1_Click_1(object sender, EventArgs e) // 
        {
            Salaries Obj = new Salaries();
            Obj.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e) // Logout Btn
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
