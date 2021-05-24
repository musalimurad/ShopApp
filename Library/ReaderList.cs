using Library.Helpers;
using Library.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class ReaderList : Form
    {
        public ReaderList()
        {
            InitializeComponent();
        }

        LibraryDB libraryDB = new LibraryDB();

        Book_To_Readers selectedReader;

        #region Exit Minimize button

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region FindMethod

        private int Findfaculty(string facultyname)
        {
            Faculty Selectfaculty = libraryDB.Faculties.FirstOrDefault(f => f.Facultyname == facultyname);

            if (Selectfaculty == null)
            {
                Faculty Newfaculty = libraryDB.Faculties.Add(new Faculty()
                {
                    Facultyname = facultyname
                });
                libraryDB.SaveChanges();
                return Newfaculty.FacultyID;
            }
            return Selectfaculty.FacultyID;

        }

        private int FindGroup(string groupname)
        {
            Group Selectgroup = libraryDB.Groups.FirstOrDefault(g => g.Groupname == groupname);
            if (Selectgroup == null)
            {
                Group Newgroup = libraryDB.Groups.Add(new Group()
                {
                    Groupname = groupname
                });
                libraryDB.SaveChanges();
                return Newgroup.GroupID;
            }
            return Selectgroup.GroupID;
        }

        #endregion

        #region FillCombo method

        private void FillfacultyCombo()
        {
            Faculty_cb.Items.AddRange(libraryDB.Faculties.Select(f => f.Facultyname).ToArray());
        }

        private void FillGroupCombo()
        {
            Group_cb.Items.AddRange(libraryDB.Groups.Select(g => g.Groupname).ToArray());
        }

        private void FillBookCombo()
        {
            Book_cb.Items.AddRange(libraryDB.Books.Select(b => b.Bookname).ToArray());
        }

        private void filldataGrid()
        {
            Reader_dgv.DataSource = libraryDB.Book_To_Readers.Select(br => new
            {
                Id = br.ID,
                Firstname = br.Reader.Firstname,
                Lastname = br.Reader.Lastname,
                Fathername = br.Reader.Fathername,
                Phone = br.Reader.Phone,
                Faculty = br.Reader.Faculty.Facultyname,
                Group = br.Reader.Faculty.Group.Groupname,
                Book = br.Book.Bookname,
                GetBookdate = br.GetbookDate

            }).Distinct().ToList();
            libraryDB.SaveChanges();
            Reader_dgv.Columns[0].Visible = false;
        }

        #endregion

        #region Add Reader 

        private void AddReader()
        {
            string Firstname = Firstname_tb.Text;
            string Lastname = Lastname_tb.Text;
            string Fathername = Fathername_tb.Text;
            string Phone = Phone_tb.Text;
            string Faculty = Faculty_cb.Text;
            string Groupname = Group_cb.Text;
            string Bookname = Book_cb.Text;
            DateTime DateTime = GetBook_dtp.Value;

            string[] ar = { Firstname, Lastname, Fathername, Phone, Faculty, Bookname };
            if (Utilities.IsEmpty(ar))
            {
                Empty_lb.Visible = false;
                int FacultyId = Findfaculty(Faculty);
                int GroupId = FindGroup(Groupname);

                if (DateTime >= DateTime.Now)
                {
                    Reader reader = libraryDB.Readers.Add(new Reader()
                    {
                        Firstname = Firstname,
                        Lastname = Lastname,
                        Fathername = Fathername,
                        Phone = Phone,
                        Faculty_ID = FacultyId,


                    });
                    libraryDB.SaveChanges();
                    ReaderaddBook(reader.ReaderID);
                    MessageBox.Show("Reader added successfully!", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filldataGrid();
                    Clear();
                }
                else
                {
                    MessageBox.Show("The return date of the book cannot be in the past!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            else
            {
                Empty_lb.Visible = true;
            }
        }

        #endregion

        #region reader add book

        private void ReaderaddBook(int readerId)
        {
            for (var i = 0; i < Book_listbox.Items.Count; i++)
            {
                string bookname = Book_listbox.Items[i].ToString();
                int bookid;
                DateTime getdate = GetBook_dtp.Value;

                bookid = libraryDB.Books.First(b => b.Bookname == bookname).BookID;



                libraryDB.Book_To_Readers.Add(new Book_To_Readers()
                {
                    Book_ID = bookid,
                    Reader_ID = readerId,
                    GetbookDate = getdate

                });
                libraryDB.SaveChanges();
            }
        }

        #endregion

        #region Book selected index

        private void BookSelectedIndex()
        {
            string authorName = Book_cb.Text;

            if (!Book_listbox.Items.Contains(authorName))
            {
                Book_listbox.Items.Add(authorName, true);
            }
        }

        private void Book_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = Book_listbox.SelectedIndex;

            if (selected != -1)
            {
                Book_listbox.Items.RemoveAt(selected);
            }
        }

        private void Book_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BookSelectedIndex();
            filldataGrid();
        }

        private void Book_cb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BookSelectedIndex();
            }
            filldataGrid();
        }

        #endregion

        #region ClearMethod

        private void Clear()
        {
            Firstname_tb.Text = default;
            Lastname_tb.Text = default;
            Fathername_tb.Text = default;
            Phone_tb.Text = default;
            Faculty_cb.Text = default;
            Group_cb.Text = default;
            Book_cb.Text = default;
            Book_listbox.Items.Clear();
            GetBook_dtp.Value = DateTime.Now;
        }

        #endregion

        #region Delete Reader

        private void Reader_dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int readerID = (int)Reader_dgv.Rows[e.RowIndex].Cells[0].Value;
            selectedReader = libraryDB.Book_To_Readers.First(r => r.Reader_ID == readerID);
            Firstname_tb.Text = selectedReader.Reader.Firstname;
            Lastname_tb.Text = selectedReader.Reader.Lastname;
            Fathername_tb.Text = selectedReader.Reader.Fathername;
            Phone_tb.Text = selectedReader.Reader.Phone;
            Book_cb.Text = selectedReader.Book.Bookname;
            Faculty_cb.Text = selectedReader.Reader.Faculty.Facultyname;
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want delete reader?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                libraryDB.Book_To_Readers.Remove(selectedReader);

            }
            libraryDB.SaveChanges();
            MessageBox.Show(" Reader has been deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
            filldataGrid();
        }

        #endregion

        private void ReaderList_Load(object sender, EventArgs e)
        {
            FillBookCombo();
            FillfacultyCombo();
            FillGroupCombo();
            filldataGrid();
        }


        private void Addreader_btn_Click(object sender, EventArgs e)
        {
            AddReader();
        }

        
    }
}
