using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Employee_Managment_System
{
    class EmployeeData
    {
        
        public int ID { set; get; } //0
        public string EmployeeID { set; get; } //1
        public string Name { set; get; } //2
        public string Gender { set; get; } //3
        public string Contact { set; get; } //4
        public string Position { set; get; } //5
        public string Image { set; get; } //6
        public int Salary { set; get; } //7
        public string Status { set; get; } //8


        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-EFCD3D4;Initial Catalog=EMPLOYEE_DB;Integrated Security=True");

        public List<EmployeeData>employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                   string selectData = "SELECT * FROM EMPLOYEES WHERE DELETE_DATE IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while(reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();
                            ed.ID = (int)reader["ID"];
                            ed.EmployeeID = reader["EMPLOYEE_ID"].ToString();
                            ed.Name = reader["FULL_NAME"].ToString();
                            ed.Gender = reader["GENDER"].ToString();
                            ed.Contact = reader["CONTACT_NUMBER"].ToString();
                            ed.Position = reader["POSITION"].ToString();
                            ed.Image = reader["IMAGES"].ToString();
                            ed.Salary = (int)reader["SALARY"];
                            ed.Status = reader["STATUS"].ToString();

                            listdata.Add(ed);
                        }
                    }


                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

        public List<EmployeeData> salaryEmployeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM EMPLOYEES WHERE  DELETE_DATE IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();     
                            ed.EmployeeID = reader["EMPLOYEE_ID"].ToString();
                            ed.Name = reader["FULL_NAME"].ToString();                 
                            ed.Position = reader["POSITION"].ToString();               
                            ed.Salary = (int)reader["SALARY"];

                            listdata.Add(ed);
                        }
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

    }
}
