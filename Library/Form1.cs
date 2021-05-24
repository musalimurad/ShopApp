using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BookList bookList = new BookList();
            bookList.Show();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int Mouse_x;
        int Mouse_y;
        bool Move;

        private void Library_MouseDown(object sender, MouseEventArgs e)
        {
            Move = true;
            Mouse_x = e.X;
            Mouse_y = e.Y;
        }

        private void Library_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_x, MousePosition.Y - Mouse_y);
            }
        }

        private void Library_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            Move = true;
            Mouse_x = e.X;
            Mouse_y = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_x, MousePosition.Y - Mouse_y);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = true;
            Mouse_x = e.X;
            Mouse_y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_x, MousePosition.Y - Mouse_y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Book_Add book_Add = new Book_Add();
            book_Add.Show();
        }

        private void ReaderList_lb_Click(object sender, EventArgs e)
        {
            ReaderList readerList = new ReaderList();
            readerList.Show();
        }

        private void Library_Load(object sender, EventArgs e)
        {

        }
    }
}
