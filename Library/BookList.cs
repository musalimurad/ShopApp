using Library.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using Library.Helpers;
using System.Drawing;

namespace Library
{
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        LibraryDB libraryDB = new LibraryDB();
        Book_To_Authors selectedBook;
       
        #region mousemove
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Maximize_btn_Click(object sender, EventArgs e)
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

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int Mouse_x;
        int Mouse_y;
        bool Move;

        private void BookList_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }

        private void BookList_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_x, MousePosition.Y - Mouse_y);
            }
        }

        private void BookList_MouseDown(object sender, MouseEventArgs e)
        {
            Move = true;
            Mouse_x = e.X;
            Mouse_y = e.Y;
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
        #endregion

        #region Fill Combo

        private void FillBookCombo()
        {
            BookName_cb.Items.AddRange(libraryDB.Books.Select(b => b.Bookname).ToArray());
        }

        private void FillAuthorCombo()
        {
            Author_cb.Items.AddRange(libraryDB.Authors.Select(a => a.Authorname).ToArray());
        }

        private void FillTypeOf()
        {
            TypeOfBook_cb.Items.AddRange(libraryDB.TypeOfBooks.Select(t => t.Typename).ToArray());
        }

        private void FillPublishCombo()
        {
            Publishing_cb.Items.AddRange(libraryDB.Publishings.Select(p => p.Publishname).ToArray());
        }

        private void FillDatagrid()
        {
            BookList_dgv.DataSource = libraryDB.Book_To_Authors.Where(b => b.Book.Bookname.Contains(BookName_cb.Text) && b.Author.Authorname.Contains(Author_cb.Text) && b.Book.TypeOfBook.Typename.Contains(TypeOfBook_cb.Text) && b.Book.Publishing.Publishname.Contains(Publishing_cb.Text)).Select(book => new
            {
                ID = book.B_ID,
                TypeOf = book.Book.TypeOfBook.Typename,
                Bookname = book.Book.Bookname,
                Publish = book.Book.Publishing.Publishname,
                Author = book.Author.Authorname,
                Quantity = book.Book.Quantity,
                Publishdate = book.Book.Purchasedate
            }).Distinct().ToList();
            BookList_dgv.Columns[0].Visible = false;
            BookList_dgv.Columns[6].DefaultCellStyle.Format = " dd MMMM yyyy";

            for (int i = 0; i < BookList_dgv.RowCount; i++)
            {
                int quantity = (int)BookList_dgv.Rows[i].Cells[5].Value;
                if (quantity <= 0)
                {
                    BookList_dgv.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                }
            }
            libraryDB.SaveChanges();
        }

        #endregion

        private void BookList_Load(object sender, EventArgs e)
        {
            FillDatagrid();
            FillBookCombo();
            FillAuthorCombo();
            FillTypeOf();
            FillPublishCombo();
        }

        private void Clear()
        {
            BookName_cb.Text = default;
            Author_cb.Text = default;
            TypeOfBook_cb.Text = default;
            Publishing_cb.Text = default;
        }

        private void TypeOfBook_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDatagrid();
        }

        private void TypeOfBook_cb_KeyDown(object sender, KeyEventArgs e)
        {
            FillDatagrid();
        }

        private void TypeOfBook_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillDatagrid();
        }

        private void BookName_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDatagrid();
        }

        private void BookName_cb_KeyDown(object sender, KeyEventArgs e)
        {
            FillDatagrid();
        }

        private void BookName_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillDatagrid();
        }

        private void Publishing_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDatagrid();
        }

        private void Publishing_cb_KeyDown(object sender, KeyEventArgs e)
        {
            FillDatagrid();
        }

        private void Publishing_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillDatagrid();
        }

        private void Author_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDatagrid();
        }

        private void Author_cb_KeyDown(object sender, KeyEventArgs e)
        {
            FillDatagrid();
        }

        private void Author_cb_KeyUp(object sender, KeyEventArgs e)
        {
            FillDatagrid();
        }

        private void BookList_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int bookId = (int)BookList_dgv.Rows[e.RowIndex].Cells[0].Value;
            selectedBook = libraryDB.Book_To_Authors.First(b => b.B_ID == bookId);
            BookName_cb.Text = selectedBook.Book.Bookname;
            Author_cb.Text = selectedBook.Author.Authorname;
            TypeOfBook_cb.Text = selectedBook.Book.TypeOfBook.Typename;
            Publishing_cb.Text = selectedBook.Book.Publishing.Publishname;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want delete book?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                libraryDB.Book_To_Authors.Remove(selectedBook);

            }
            libraryDB.SaveChanges();
            MessageBox.Show(" Book has been deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            FillDatagrid();
           
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void AddBook_btn_Click(object sender, EventArgs e)
        {
            Book_Add book = new Book_Add();
            book.Show();
        }
    }
}
