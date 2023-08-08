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
    public partial class Salaries : Form
    {
        Functions Con;
        public Salaries()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmployee();
        }
        private void ShowSalaries()
        {
            try
            {
                string Query = "Select * from SalaryTbl";
                Sal_List.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void GetEmployee()
        {
            string Query = "select * from EmployeeTbl";
            Emp_Cb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            Emp_Cb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            Emp_Cb.DataSource = Con.GetData(Query);
        }

        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "select EmpSal from EmployeeTbl where EmpId = {0}";
            Query = string.Format(Query, Emp_Cb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            // MessageBox.Show("" + DSal);
            // Emp_Cb.DataSource = Con.GetData(Query);
            if (Days_Tb.Text == "")
            {
                Sal_Tb.Text = "Rs " + (d * DSal);
            }
            else if (Convert.ToInt32(Days_Tb.Text) > 31)
            {
                MessageBox.Show("Days can not be greater than 31");
            }
            else
            {
                d = Convert.ToInt32(Days_Tb.Text);
                Sal_Tb.Text = "Rs " + (d * DSal);
            }

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Sal_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int d = 1;

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Emp_Cb.SelectedIndex == -1 || Days_Tb.Text == "" || Period_Tb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    Period = Period_Tb.Value.Date.Month.ToString() + "-" + Period_Tb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(Days_Tb.Text);

                    int Days = Convert.ToInt32(Days_Tb.Text);
                    string Query = "insert into SalaryTbl values({0}, {1}, '{2}', {3}, '{4}')";
                    Query = string.Format(Query, Emp_Cb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalaries();
                    MessageBox.Show("Salary Paid");

                    // reset 
                    Days_Tb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            
            }
            

        }

        private void Emp_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Emp_Cb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();

        }

        private void Emp_Btn_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void Dep_Btn_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }

        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
