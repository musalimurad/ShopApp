
namespace Library
{
    partial class BookList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Maximize_btn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.BookList_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TypeOfBook_cb = new System.Windows.Forms.ComboBox();
            this.BookName_cb = new System.Windows.Forms.ComboBox();
            this.Author_cb = new System.Windows.Forms.ComboBox();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.AddBook_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Publishing_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookList_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Minimize_btn);
            this.panel1.Controls.Add(this.Maximize_btn);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 37);
            this.panel1.TabIndex = 0;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Library.Properties.Resources.books_icon_psd_image_2332books_icon_512;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_btn.BackgroundImage = global::Library.Properties.Resources.icons8_shrink_50;
            this.Minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.FlatAppearance.BorderSize = 0;
            this.Minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_btn.Location = new System.Drawing.Point(917, 3);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(32, 32);
            this.Minimize_btn.TabIndex = 10;
            this.Minimize_btn.UseVisualStyleBackColor = false;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Maximize_btn
            // 
            this.Maximize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize_btn.BackColor = System.Drawing.Color.Transparent;
            this.Maximize_btn.BackgroundImage = global::Library.Properties.Resources.icons8_compress_50;
            this.Maximize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Maximize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize_btn.FlatAppearance.BorderSize = 0;
            this.Maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize_btn.Location = new System.Drawing.Point(955, 6);
            this.Maximize_btn.Name = "Maximize_btn";
            this.Maximize_btn.Size = new System.Drawing.Size(27, 28);
            this.Maximize_btn.TabIndex = 9;
            this.Maximize_btn.UseVisualStyleBackColor = false;
            this.Maximize_btn.Click += new System.EventHandler(this.Maximize_btn_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::Library.Properties.Resources.icons8_close_window_100;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(988, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 29);
            this.Exit.TabIndex = 4;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BookList_dgv
            // 
            this.BookList_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BookList_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookList_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BookList_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookList_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookList_dgv.Location = new System.Drawing.Point(395, 61);
            this.BookList_dgv.Name = "BookList_dgv";
            this.BookList_dgv.Size = new System.Drawing.Size(613, 500);
            this.BookList_dgv.TabIndex = 1;
            this.BookList_dgv.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BookList_dgv_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book name";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type of Book";
            // 
            // TypeOfBook_cb
            // 
            this.TypeOfBook_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TypeOfBook_cb.DropDownHeight = 90;
            this.TypeOfBook_cb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfBook_cb.FormattingEnabled = true;
            this.TypeOfBook_cb.IntegralHeight = false;
            this.TypeOfBook_cb.Location = new System.Drawing.Point(56, 74);
            this.TypeOfBook_cb.Name = "TypeOfBook_cb";
            this.TypeOfBook_cb.Size = new System.Drawing.Size(201, 29);
            this.TypeOfBook_cb.TabIndex = 5;
            this.TypeOfBook_cb.SelectedIndexChanged += new System.EventHandler(this.TypeOfBook_cb_SelectedIndexChanged);
            this.TypeOfBook_cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TypeOfBook_cb_KeyDown);
            this.TypeOfBook_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TypeOfBook_cb_KeyUp);
            // 
            // BookName_cb
            // 
            this.BookName_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BookName_cb.DropDownHeight = 90;
            this.BookName_cb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName_cb.FormattingEnabled = true;
            this.BookName_cb.IntegralHeight = false;
            this.BookName_cb.Location = new System.Drawing.Point(56, 131);
            this.BookName_cb.Name = "BookName_cb";
            this.BookName_cb.Size = new System.Drawing.Size(201, 29);
            this.BookName_cb.TabIndex = 6;
            this.BookName_cb.SelectedIndexChanged += new System.EventHandler(this.BookName_cb_SelectedIndexChanged);
            this.BookName_cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BookName_cb_KeyDown);
            this.BookName_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BookName_cb_KeyUp);
            // 
            // Author_cb
            // 
            this.Author_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Author_cb.DropDownHeight = 90;
            this.Author_cb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_cb.FormattingEnabled = true;
            this.Author_cb.IntegralHeight = false;
            this.Author_cb.Location = new System.Drawing.Point(56, 245);
            this.Author_cb.Name = "Author_cb";
            this.Author_cb.Size = new System.Drawing.Size(201, 29);
            this.Author_cb.TabIndex = 7;
            this.Author_cb.SelectedIndexChanged += new System.EventHandler(this.Author_cb_SelectedIndexChanged);
            this.Author_cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Author_cb_KeyDown);
            this.Author_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Author_cb_KeyUp);
            // 
            // Edit_btn
            // 
            this.Edit_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Edit_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_btn.FlatAppearance.BorderSize = 0;
            this.Edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.Edit_btn.Location = new System.Drawing.Point(20, 451);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(151, 40);
            this.Edit_btn.TabIndex = 8;
            this.Edit_btn.Text = "EDIT";
            this.Edit_btn.UseVisualStyleBackColor = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Delete_btn.BackColor = System.Drawing.Color.Black;
            this.Delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.Delete_btn.Location = new System.Drawing.Point(217, 451);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(151, 40);
            this.Delete_btn.TabIndex = 9;
            this.Delete_btn.Text = "DELETE";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // AddBook_btn
            // 
            this.AddBook_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddBook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(120)))), ((int)(((byte)(83)))));
            this.AddBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBook_btn.FlatAppearance.BorderSize = 0;
            this.AddBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.AddBook_btn.Location = new System.Drawing.Point(20, 521);
            this.AddBook_btn.Name = "AddBook_btn";
            this.AddBook_btn.Size = new System.Drawing.Size(348, 40);
            this.AddBook_btn.TabIndex = 10;
            this.AddBook_btn.Text = "ADD BOOK";
            this.AddBook_btn.UseVisualStyleBackColor = false;
            this.AddBook_btn.Click += new System.EventHandler(this.AddBook_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::Library.Properties.Resources.wp2036897_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(56, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Publishing_cb
            // 
            this.Publishing_cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Publishing_cb.DropDownHeight = 90;
            this.Publishing_cb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publishing_cb.FormattingEnabled = true;
            this.Publishing_cb.IntegralHeight = false;
            this.Publishing_cb.Location = new System.Drawing.Point(56, 188);
            this.Publishing_cb.Name = "Publishing_cb";
            this.Publishing_cb.Size = new System.Drawing.Size(201, 29);
            this.Publishing_cb.TabIndex = 13;
            this.Publishing_cb.SelectedIndexChanged += new System.EventHandler(this.Publishing_cb_SelectedIndexChanged);
            this.Publishing_cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Publishing_cb_KeyDown);
            this.Publishing_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Publishing_cb_KeyUp);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(52, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Publishing";
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1020, 584);
            this.Controls.Add(this.Publishing_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddBook_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.Author_cb);
            this.Controls.Add(this.BookName_cb);
            this.Controls.Add(this.TypeOfBook_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookList_dgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookList";
            this.Load += new System.EventHandler(this.BookList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookList_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookList_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BookList_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookList_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Maximize_btn;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.DataGridView BookList_dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TypeOfBook_cb;
        private System.Windows.Forms.ComboBox BookName_cb;
        private System.Windows.Forms.ComboBox Author_cb;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button AddBook_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox Publishing_cb;
        private System.Windows.Forms.Label label4;
    }
}