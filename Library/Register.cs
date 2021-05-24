using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Helpers;

namespace Library
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        LibraryDB libraryDB = new LibraryDB();

        #region Exit_back_click
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackTo_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            RegisterContent();
           
        }
        #endregion
      

       private void RegisterContent()
        {
            string Fullname = Fullname_tb.Text;
            string Username = Username_tb.Text;
            string Email = Email_tb.Text;
            string Password = Password_tb.Text;
            string RePassword = RePassword_tb.Text;

            string[] ar = { Fullname, Username, Email, Password, RePassword };

            if (Utilities.IsEmpty(ar))
            {
                if (Password == RePassword)
                {
                    if (Password.Length >= 6 && RePassword.Length >= 6 )
                    {
                       
                        Admin newAdmin = libraryDB.Admins.Add(new Admin()
                        {
                            Fullname = Fullname,
                            Username = Username,
                            Email = Email,
                            Password = Password,
                            Repassword = RePassword
                        });
                        libraryDB.SaveChanges();
                        MessageBox.Show("Admin added successfully!", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login login = new Login();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(" Passwords must be at least six characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
                else
                {
                    MessageBox.Show("Passwords are not the same!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            else
            {
                MessageBox.Show("Please, fill in all the blanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

          
        }

        private void ShowPass_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass_chb.Checked)
            {
                Password_tb.PasswordChar = '\0';
                RePassword_tb.PasswordChar = '\0';
                ShowPass_chb.Text = "Hide Password";
            }
            else
            {
                Password_tb.PasswordChar = '*';
                RePassword_tb.PasswordChar = '*';
                ShowPass_chb.Text = "Show Password";
            }
        }

      
    }
}
