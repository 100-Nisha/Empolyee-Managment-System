using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Managment_System
{
    public partial class Register_form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-EFCD3D4;Initial Catalog=EMPLOYEE_DB;Integrated Security=True");
        public Register_form()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void Login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void Btn_signup_Click_1(object sender, EventArgs e)
        {
            if(signup_username.Text == " " || signup_password.Text == " ")
            {
                MessageBox.Show("please fill the all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        //To check if the user is existing already
                        string selectUsername = "SELECT COUNT(id) FROM USERS WHERE USERNAME = @USER";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, conn))
                        {
                            checkUser.Parameters.AddWithValue("@user", signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();
                            
                            if(count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + " is already taken ", " Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO USERS " + "(USERNAME, PASSWORDS, DATE_REGISTER)" + "VALUES (@USERNAME, @PASSWORDS, @DATE_REGISTER)";

                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@USERNAME", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@PASSWORDS", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@DATE_REGISTER", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registerd successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }

                          
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
