using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Helpers;
using Library.Models;

namespace Library
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        LibraryDB libraryDB = new LibraryDB();

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = Username_tb.Text;
            string Password = Password_tb.Text;
            string[] ar = { Username, Password };

            if (Utilities.IsEmpty(ar))
            {
                if (libraryDB.Admins.Where( u => u.Username == Username).Count() > 0 && libraryDB.Admins.Where(p => p.Password == Password).Count() > 0)
                {
                    Library library = new Library();
                    library.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Username or Password incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Please, fill in all the blanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void ShowPass_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass_chb.Checked)
            {
                Password_tb.PasswordChar = '\0';
                ShowPass_chb.Text = "Hide Password";
            }
            else
            {
                Password_tb.PasswordChar = '*';
                ShowPass_chb.Text = "Show Password";
            }
        }
    }
}
