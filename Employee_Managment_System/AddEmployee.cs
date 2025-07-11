using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Employee_Managment_System
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-EFCD3D4;Initial Catalog=EMPLOYEE_DB;Integrated Security=True");

        public AddEmployee()
        {
            InitializeComponent();

            //To DISPLAY THE DATA FROM DATABASE  TO YOUR DATA GRID VIEW
            displayEmployeeData();
        }

        public void RefreshData()
        {
            if(InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }

        private void AddEmployee_addbtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_ID.Text == ""
               || addEmployee_fullName.Text == ""
               || addEmployee_gender.Text == ""
               || addEmployee_phoneno.Text == ""
               || addEmployee_position.Text == ""
               || addEmployee_status.Text == ""
               || addEmployee_picturebox.Image == null)
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string checkEmID = "SELECT COUNT(*) FROM EMPLOYEES WHERE EMPLOYEE_ID = @emID AND DELETE_DATE IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addEmployee_ID.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if(count >= 1)
                            {
                                MessageBox.Show(addEmployee_ID.Text.Trim() + "is already taken",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO EMPLOYEES " +
                                "(EMPLOYEE_ID, FULL_NAME, GENDER, CONTACT_NUMBER" +
                                ", POSITION, IMAGES, SALARY, INSERT_DATE, STATUS)" +
                                "VALUES(@EMPLOYEE_ID, @FULL_NAME, @GENDER, @CONTACT_NUMBER" +
                                ", @POSITION, @IMAGES, @SALARY, @INSERT_DATE, @STATUS )";

                                string path = Path.Combine(@"E:\.Net\.Net\ASP Dot Net Desktop_application\Employee_Managment_System\Employee_Managment_System\Directory\"
                                + addEmployee_ID.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if(!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployee_picturebox.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@EMPLOYEE_ID", addEmployee_ID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@FULL_NAME", addEmployee_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@GENDER", addEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@CONTACT_NUMBER", addEmployee_phoneno.Text.Trim());
                                    cmd.Parameters.AddWithValue("@POSITION", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@IMAGES", path);
                                    cmd.Parameters.AddWithValue("@SALARY", 0);
                                    cmd.Parameters.AddWithValue("@INSERT_DATE", today);
                                    cmd.Parameters.AddWithValue("@STATUS", addEmployee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added Successfully!",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                       "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void AddEmployee_Import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg; *.png)|*.jpg; *.png";
                string imagePAth = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePAth = dialog.FileName;
                    addEmployee_picturebox.ImageLocation = imagePAth;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex, "Error Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row =  dataGridView1.Rows[e.RowIndex];
                addEmployee_ID.Text = row.Cells[1].Value.ToString();
                addEmployee_fullName.Text = row.Cells[2].Value.ToString();
                addEmployee_gender.Text = row.Cells[3].Value.ToString();
                addEmployee_phoneno.Text = row.Cells[4].Value.ToString();
                addEmployee_position.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                if(imagePath != null)
                {
                    addEmployee_picturebox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addEmployee_picturebox.Image = null;
                }
                addEmployee_status.Text = row.Cells[8].Value.ToString();
            }
            
        }

        public void clearFields()
        {
            addEmployee_ID.Text = "";
            addEmployee_fullName.Text = "";
            addEmployee_gender.SelectedIndex = -1;
            addEmployee_phoneno.Text = "";
            addEmployee_position.SelectedIndex = -1;
            addEmployee_status.SelectedIndex = -1;
            addEmployee_picturebox.Image = null;
        }

        private void AddEmployee_updatebtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_ID.Text == ""
               || addEmployee_fullName.Text == ""
               || addEmployee_gender.Text == ""
               || addEmployee_phoneno.Text == ""
               || addEmployee_position.Text == ""
               || addEmployee_status.Text == ""
               || addEmployee_picturebox.Image == null)
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                "Employee ID: " + addEmployee_ID.Text.Trim() + "?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE EMPLOYEES SET FULL_NAME = @FULL_NAME" +
                        ", GENDER = @GENDER, CONTACT_NUMBER = @CONTACT_NUMBER" +
                        ",POSITION = @POSITION, UPDATE_DATE = @UPDATE_DATE, STATUS = @STATUS " +
                        "WHERE EMPLOYEE_ID = @EMPLOYEE_ID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@FULL_NAME", addEmployee_fullName.Text.Trim());
                            cmd.Parameters.AddWithValue("@GENDER", addEmployee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@CONTACT_NUMBER", addEmployee_phoneno.Text.Trim());
                            cmd.Parameters.AddWithValue("@POSITION", addEmployee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@UPDATE_DATE", today);
                            cmd.Parameters.AddWithValue("@STATUS", addEmployee_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@EMPLOYEE_ID", addEmployee_ID.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update Successfully!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.",
                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void AddEmployee_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AddEmployee_deletebtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_ID.Text == ""
               || addEmployee_fullName.Text == ""
               || addEmployee_gender.Text == ""
               || addEmployee_phoneno.Text == ""
               || addEmployee_position.Text == ""
               || addEmployee_status.Text == ""
               || addEmployee_picturebox.Image == null)
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                "Employee ID: " + addEmployee_ID.Text.Trim() + "?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE EMPLOYEES SET DELETE_DATE = @DELETE_DATE " +
                        "WHERE EMPLOYEE_ID = @EMPLOYEE_ID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@DELETE_DATE", today);
                            cmd.Parameters.AddWithValue("@EMPLOYEE_ID", addEmployee_ID.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update Successfully!",
                                "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.",
                    "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
