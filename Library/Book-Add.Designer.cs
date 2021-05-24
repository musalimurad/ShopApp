
namespace Library
{
    partial class Book_Add
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Add));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Author_listbox = new System.Windows.Forms.CheckedListBox();
            this.Empty_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddBook_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Author_cb = new System.Windows.Forms.ComboBox();
            this.Quantity_num = new System.Windows.Forms.NumericUpDown();
            this.Publish_dtp = new System.Windows.Forms.DateTimePicker();
            this.Publish_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeOf_cb = new System.Windows.Forms.ComboBox();
            this.BookName_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBook_dgv = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Minimize_btn = new System.Windows.Forms.Button();
            this.Maximize_btn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBook_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.Author_listbox);
            this.panel1.Controls.Add(this.Empty_lb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.AddBook_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Author_cb);
            this.panel1.Controls.Add(this.Quantity_num);
            this.panel1.Controls.Add(this.Publish_dtp);
            this.panel1.Controls.Add(this.Publish_cb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TypeOf_cb);
            this.panel1.Controls.Add(this.BookName_tb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 633);
            this.panel1.TabIndex = 0;
            // 
            // Author_listbox
            // 
            this.Author_listbox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_listbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Author_listbox.FormattingEnabled = true;
            this.Author_listbox.Location = new System.Drawing.Point(22, 415);
            this.Author_listbox.Name = "Author_listbox";
            this.Author_listbox.Size = new System.Drawing.Size(185, 94);
            this.Author_listbox.TabIndex = 26;
            this.Author_listbox.SelectedIndexChanged += new System.EventHandler(this.Author_listbox_SelectedIndexChanged);
            // 
            // Empty_lb
            // 
            this.Empty_lb.AutoSize = true;
            this.Empty_lb.BackColor = System.Drawing.Color.Red;
            this.Empty_lb.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empty_lb.ForeColor = System.Drawing.Color.GhostWhite;
            this.Empty_lb.Location = new System.Drawing.Point(12, 535);
            this.Empty_lb.Name = "Empty_lb";
            this.Empty_lb.Size = new System.Drawing.Size(274, 26);
            this.Empty_lb.TabIndex = 25;
            this.Empty_lb.Text = "Please, fill in all the blanks!";
            this.Empty_lb.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Library.Properties.Resources.books_icon_psd_image_2332books_icon_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // AddBook_btn
            // 
            this.AddBook_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(62)))), ((int)(((byte)(86)))));
            this.AddBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBook_btn.FlatAppearance.BorderSize = 0;
            this.AddBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBook_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook_btn.ForeColor = System.Drawing.Color.White;
            this.AddBook_btn.Location = new System.Drawing.Point(3, 580);
            this.AddBook_btn.Name = "AddBook_btn";
            this.AddBook_btn.Size = new System.Drawing.Size(293, 50);
            this.AddBook_btn.TabIndex = 17;
            this.AddBook_btn.Text = "ADD BOOK";
            this.AddBook_btn.UseVisualStyleBackColor = false;
            this.AddBook_btn.Click += new System.EventHandler(this.AddBook_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(18, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Author";
            // 
            // Author_cb
            // 
            this.Author_cb.DropDownHeight = 90;
            this.Author_cb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author_cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Author_cb.FormattingEnabled = true;
            this.Author_cb.IntegralHeight = false;
            this.Author_cb.Location = new System.Drawing.Point(22, 379);
            this.Author_cb.Name = "Author_cb";
            this.Author_cb.Size = new System.Drawing.Size(185, 30);
            this.Author_cb.TabIndex = 14;
            this.Author_cb.SelectedIndexChanged += new System.EventHandler(this.Author_cb_SelectedIndexChanged);
            this.Author_cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Author_cb_KeyUp);
            // 
            // Quantity_num
            // 
            this.Quantity_num.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Quantity_num.Location = new System.Drawing.Point(22, 275);
            this.Quantity_num.Name = "Quantity_num";
            this.Quantity_num.Size = new System.Drawing.Size(185, 27);
            this.Quantity_num.TabIndex = 13;
            this.Quantity_num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Publish_dtp
            // 
            this.Publish_dtp.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.Publish_dtp.Location = new System.Drawing.Point(22, 331);
            this.Publish_dtp.Name = "Publish_dtp";
            this.Publish_dtp.Size = new System.Drawing.Size(185, 20);
            this.Publish_dtp.TabIndex = 12;
            // 
            // Publish_cb
            // 
            this.Publish_cb.DropDownHeight = 90;
            this.Publish_cb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publish_cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Publish_cb.FormattingEnabled = true;
            this.Publish_cb.IntegralHeight = false;
            this.Publish_cb.Location = new System.Drawing.Point(22, 217);
            this.Publish_cb.Name = "Publish_cb";
            this.Publish_cb.Size = new System.Drawing.Size(185, 30);
            this.Publish_cb.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.label4.Location = new System.Drawing.Point(18, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publishing";
            // 
            // TypeOf_cb
            // 
            this.TypeOf_cb.DropDownHeight = 90;
            this.TypeOf_cb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOf_cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.TypeOf_cb.FormattingEnabled = true;
            this.TypeOf_cb.IntegralHeight = false;
            this.TypeOf_cb.ItemHeight = 22;
            this.TypeOf_cb.Location = new System.Drawing.Point(22, 159);
            this.TypeOf_cb.Name = "TypeOf_cb";
            this.TypeOf_cb.Size = new System.Drawing.Size(185, 30);
            this.TypeOf_cb.TabIndex = 8;
            // 
            // BookName_tb
            // 
            this.BookName_tb.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BookName_tb.Location = new System.Drawing.Point(22, 102);
            this.BookName_tb.Multiline = true;
            this.BookName_tb.Name = "BookName_tb";
            this.BookName_tb.Size = new System.Drawing.Size(185, 28);
            this.BookName_tb.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.label7.Location = new System.Drawing.Point(50, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 42);
            this.label7.TabIndex = 6;
            this.label7.Text = "ADD BOOK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.label6.Location = new System.Drawing.Point(18, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.label5.Location = new System.Drawing.Point(18, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Publish Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type of Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(18, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // AddBook_dgv
            // 
            this.AddBook_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AddBook_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddBook_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AddBook_dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.AddBook_dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddBook_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AddBook_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddBook_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.AddBook_dgv.Location = new System.Drawing.Point(324, 323);
            this.AddBook_dgv.Name = "AddBook_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddBook_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AddBook_dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            this.AddBook_dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AddBook_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AddBook_dgv.Size = new System.Drawing.Size(696, 298);
            this.AddBook_dgv.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::Library.Properties.Resources.wp2036897_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(304, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(442, 311);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
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
            this.Minimize_btn.Location = new System.Drawing.Point(940, -3);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.Size = new System.Drawing.Size(32, 32);
            this.Minimize_btn.TabIndex = 11;
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
            this.Maximize_btn.Location = new System.Drawing.Point(978, 1);
            this.Maximize_btn.Name = "Maximize_btn";
            this.Maximize_btn.Size = new System.Drawing.Size(27, 28);
            this.Maximize_btn.TabIndex = 10;
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
            this.Exit.ForeColor = System.Drawing.Color.Blue;
            this.Exit.Location = new System.Drawing.Point(1011, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 29);
            this.Exit.TabIndex = 7;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Book_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(53)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1042, 633);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddBook_dgv);
            this.Controls.Add(this.Minimize_btn);
            this.Controls.Add(this.Maximize_btn);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Book_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Add";
            this.Load += new System.EventHandler(this.Book_Add_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Book_Add_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Book_Add_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Book_Add_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBook_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Quantity_num;
        private System.Windows.Forms.DateTimePicker Publish_dtp;
        private System.Windows.Forms.ComboBox Publish_cb;
        private System.Windows.Forms.ComboBox TypeOf_cb;
        private System.Windows.Forms.TextBox BookName_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Author_cb;
        private System.Windows.Forms.Button AddBook_btn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Maximize_btn;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.DataGridView AddBook_dgv;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Empty_lb;
        private System.Windows.Forms.CheckedListBox Author_listbox;
    }
}