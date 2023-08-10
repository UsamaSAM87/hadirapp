using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace paas_app2
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            //listBox.Visible = false;
            Label3.Visible = false;
        }



        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            if (ActiveDirectoryAuthenticate(txtUserName.Text, txtPassword.Text))
            {
                //listBox.Visible = true;
                Label3.Visible = true;
            }
            else
            {
                lblError.Visible = true;
                //listBox.Items.Clear();
                //listBox.Visible = false;
                Label3.Visible = false;
            }
        }



        public bool ActiveDirectoryAuthenticate(string username, string password)
        {
            //string ldapPath = "LDAP://20.239.51.40:389"; // Replace with your domain controller address and port
            //string domain = "usama.local"; // Replace with your domain name



            //DirectoryEntry entry = new DirectoryEntry(ldapPath, $"{domain}\\{username}", password);



            try
            {
                // Bind to Active Directory using the given username and password
                //object obj = entry.NativeObject;


                /*
                string connectionString = "Data Source=YourServerAddress;Initial Catalog=YourDatabaseName;User ID=YourUsername;Password=YourPassword;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO UserCredentials (Username, Password) VALUES (@Username, @Password)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.ExecuteNonQuery();
                    }
                }
                */

                // If the binding is successful, the credentials are valid
                return true;



            }
            catch (Exception)
            {
                // If an exception is thrown, authentication failed
                return false;
            }
        }
    }
}