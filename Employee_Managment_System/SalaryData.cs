using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Employee_Managment_System
{
    class SalaryData
    {
        public string EmployeeID { set; get; } //0
        public string Name { set; get; } //1
        public string Gender { set; get; } //2
        public string Contact { set; get; } //3
        public string Position { set; get; } //4
        public int Salary { set; get; } //5


        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-EFCD3D4;Initial Catalog=EMPLOYEE_DB;Integrated Security=True");

        public List<SalaryData> salaryEmployeeListData()
        {
            List<SalaryData> listdata = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM EMPLOYEES WHERE STATUS = 'Active'" +
                        " AND DELETE_DATE IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData sd = new SalaryData();
                            sd.EmployeeID = reader["EMPLOYEE_ID"].ToString();
                            sd.Name = reader["FULL_NAME"].ToString();
                            sd.Gender = reader["GENDER"].ToString();
                            sd.Contact = reader["CONTACT_NUMBER"].ToString();
                            sd.Position = reader["POSITION"].ToString();
                            sd.Salary = (int)reader["SALARY"];

                            listdata.Add(sd);
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
