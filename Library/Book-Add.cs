using Library.Helpers;
using Library.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class Book_Add : Form
    {
        public Book_Add()
        {
            InitializeComponent();
        }

        LibraryDB libraryDB = new LibraryDB();

        #region MouseMove
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

        int Mouse_x;
        int Mouse_y;
        bool Move;

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Book_Add_MouseDown(object sender, MouseEventArgs e)
        {
            Move = true;
            Mouse_x = e.X;
            Mouse_y = e.Y;
        }

        private void Book_Add_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_x, MousePosition.Y - Mouse_y);
            }
        }

        private void Book_Add_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            Move = true;
            Mouse_x = e.X;
            Mouse_y = e.Y;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_x, MousePosition.Y - Mouse_y);
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            Move = false;
        }
        #endregion

        #region FindMethod

        private int FindtypeOf(string typename)
        {
            TypeOfBook findType = libraryDB.TypeOfBooks.FirstOrDefault(f => f.Typename == typename);

            if (findType == null)
            {
                TypeOfBook NewtypeOf = libraryDB.TypeOfBooks.Add(new TypeOfBook()
                {
                    Typename = typename
                });
                libraryDB.SaveChanges();
                return NewtypeOf.TypeID;
            }
            return findType.TypeID;
        }

        private int Findpublish(string publishname)
        {
            Publishing findPublish = libraryDB.Publishings.FirstOrDefault(p => p.Publishname == publishname);

            if (findPublish == null)
            {
                Publishing Newpublish = libraryDB.Publishings.Add(new Publishing()
                {
                    Publishname = publishname
                });
                libraryDB.SaveChanges();
                return Newpublish.PublishID;
            }
            return findPublish.PublishID;
        }

        #endregion

        #region FillCombo

        private void FilltypeOfCombo()
        {
            TypeOf_cb.Items.AddRange(libraryDB.TypeOfBooks.Select(t => t.Typename).ToArray());
        }

        private void FillPublishCombo()
        {
            Publish_cb.Items.AddRange(libraryDB.Publishings.Select(p => p.Publishname).ToArray());
        }

        private void FillAuthorCombo()
        {
            Author_cb.Items.AddRange(libraryDB.Authors.Select(a => a.Authorname).ToArray());
        }

        private void FillDatagrid()
        {
            
            AddBook_dgv.DataSource = libraryDB.Book_To_Authors.Select(b => new
            {
                ID = b.B_ID,
                Bookname = b.Book.Bookname,
                TypeOf = b.Book.TypeOfBook.Typename,
                Author = b.Author.Authorname,
                Publish = b.Book.Publishing.Publishname,
                Quantity = b.Book.Quantity,
                Publishdate = b.Book.Purchasedate
            }).Distinct().ToList();

            AddBook_dgv.Columns[6].DefaultCellStyle.Format = " dd MMMM yyyy";
            AddBook_dgv.Columns[0].Visible = false;

            for (int i = 0; i < AddBook_dgv.RowCount; i++)
            {
                int quantity = (int)AddBook_dgv.Rows[i].Cells[5].Value;

                if (quantity <= 0)
                {
                    AddBook_dgv.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                }
            }
            libraryDB.SaveChanges();
        }

        #endregion

        #region Book-ADD

        private void BookAdd()
        {
            string BookName = BookName_tb.Text;
            string TypeOfname = TypeOf_cb.Text;
            string Publish = Publish_cb.Text;
            int Quantity = (int)Quantity_num.Value;
            DateTime Publishdate = Publish_dtp.Value;
            string Authorname = Author_cb.Text;

            string[] ar = { BookName, TypeOfname, Publish, Authorname };

            if (Utilities.IsEmpty(ar))
            {
                Empty_lb.Visible = false;
                int TypeId = FindtypeOf(TypeOfname);
                int PublishId = Findpublish(Publish);
                if (Quantity > 0)
                {
                    if (Publishdate <= DateTime.Now)
                    {
                        Book book = libraryDB.Books.Add(new Book()
                        {

                            Bookname = BookName,
                            Typeof_ID = TypeId,
                            Publish_ID = PublishId,
                            Purchasedate = Publishdate,
                            Quantity = Quantity
                        });
                        libraryDB.SaveChanges();
                        BookaddAuthor(book.BookID);
                        MessageBox.Show("Book added successfully!", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("publication date cannot be greater than today's date!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Book quantity must be greater than 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                Empty_lb.Visible = true;
            }
        }

        #endregion

        #region author listbox selectedindex

        private void AuthorSelectedIndex()
        {
            string authorName = Author_cb.Text;

            if (!Author_listbox.Items.Contains(authorName))
            {
                Author_listbox.Items.Add(authorName, true);
            }
        }

        private void Author_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            AuthorSelectedIndex();
        }

        private void Author_cb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AuthorSelectedIndex();
            }
        }

        private void Author_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = Author_listbox.SelectedIndex;

            if (selected != -1)
            {
                Author_listbox.Items.RemoveAt(selected);
            }
        }

        #endregion

        #region ClearMethod

        private void Clear()
        {
            BookName_tb.Text = default;
            Author_cb.Text = default;
            Publish_cb.Text = default;
            TypeOf_cb.Text = default;
            Quantity_num.Value = 1;
            Author_listbox.Items.Clear();
            Publish_dtp.Value = DateTime.Now;
        }

        #endregion

        #region book add author

        private bool checkedAuthor(string author)
        {
            Author selectAuthor = libraryDB.Authors.FirstOrDefault(A => A.Authorname == author);

            if (selectAuthor == null)
            {
                return false;
            }
            return true;
        }

        private void BookaddAuthor(int bookID)
        {
            for (var i = 0; i < Author_listbox.Items.Count; i++)
            {
                string AuthorName = Author_listbox.Items[i].ToString();
                int Authorid;
                
                if (checkedAuthor(AuthorName))
                {
                    Authorid = libraryDB.Authors.First(a => a.Authorname == AuthorName).AuthorID;
                }
                else
                {
                    Author author = libraryDB.Authors.Add(new Author()
                    {
                        Authorname = AuthorName
                    });
                    libraryDB.SaveChanges();
                    Authorid = author.AuthorID;
                }
                libraryDB.Book_To_Authors.Add(new Book_To_Authors()
                {

                    A_ID = Authorid,
                    B_ID = bookID
                });

                libraryDB.SaveChanges();
            }
        }

        #endregion

        private void Book_Add_Load(object sender, EventArgs e)
        {
            FilltypeOfCombo();
            FillPublishCombo();
            FillAuthorCombo();
            FillDatagrid();
        }

        private void AddBook_btn_Click(object sender, EventArgs e)
        {
            BookAdd();
            FillDatagrid();
        }
    }
}
