﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgnt1
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string Constr;
        public Functions() 
        {
            Constr = @"Data Source=LAPTOP-SUK4VQRT;Database=EmpDB;Integrated Security=sspi;Connection Timeout=30;";
            Con = new SqlConnection(Constr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con; 
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Constr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query) 
        { 
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            cnt = Cmd.ExecuteNonQuery();
            return cnt;
        }
        
    }
}
