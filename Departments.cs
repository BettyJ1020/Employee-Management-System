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
    public partial class Departments : Form
    {
        Functions Con;
        public Departments()
        {
            InitializeComponent();
            Con = new Functions();
            ShowDeparments();
        }

        private void ShowDeparments()
        {
            string Query = "Select * from DepartmentTbl";
            Dep_List.DataSource = Con.GetData(Query);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try 
            {
                if (DepName_Tb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Dep = DepName_Tb.Text;
                    string Query = "insert into DepartmentTbl values('{0}')";
                    Query = string.Format(Query, DepName_Tb.Text);
                    Con.SetData(Query);
                    ShowDeparments();
                    MessageBox.Show("Department Added");
                    DepName_Tb.Text = "";
                }
                
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepName_Tb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Dep = DepName_Tb.Text;
                    string Query = "Delete from DepartmentTbl where DepId = {0}";
                    Query = string.Format(Query, key);
                    Con.SetData(Query);
                    ShowDeparments();
                    MessageBox.Show("Department Deleted");
                    DepName_Tb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }
        

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepName_Tb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    string Dep = DepName_Tb.Text;
                    string Query = "Update DepartmentTbl set DepName = '{0}' where DepId = {1}";
                    Query = string.Format(Query, DepName_Tb.Text, key);
                    Con.SetData(Query);
                    ShowDeparments();
                    MessageBox.Show("Department Updated");
                    DepName_Tb.Text = "";
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        int key = 0;

        private void Dep_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Dep_List.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // click a cell to choose a row
            
            if (Dep_List.SelectedRows.Count > 0)
            {
                
                DepName_Tb.Text = Dep_List.SelectedRows[0].Cells[1].Value.ToString();
                // MessageBox.Show(DepName_Tb.Text);
                if (DepName_Tb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(Dep_List.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            
        }

        private void Emp_Lbl_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
            this.Hide();
        }

        private void Departments_Load(object sender, EventArgs e)
        {

        }

        private void Sal_Lbl_Click(object sender, EventArgs e)
        {
            Salaries obj = new Salaries();
            obj.Show();
            this.Hide();

        }
    }
}
