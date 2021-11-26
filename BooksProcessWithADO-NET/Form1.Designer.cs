
namespace BooksProcessWithADO_NET
{
    partial class Form1
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
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Authors = new System.Windows.Forms.Label();
            this.cb_Authors = new System.Windows.Forms.ComboBox();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.lbl_Books = new System.Windows.Forms.Label();
            this.txb_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_AllBooks = new System.Windows.Forms.Button();
            this.btn_InsertBooks = new System.Windows.Forms.Button();
            this.btn_DeleteBooks = new System.Windows.Forms.Button();
            this.btn_UpdateBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Category
            // 
            this.cb_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(12, 40);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(203, 33);
            this.cb_Category.TabIndex = 0;
            this.cb_Category.SelectedIndexChanged += new System.EventHandler(this.Cb_Category_SelectedIndexChanged);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(12, 9);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(92, 25);
            this.lbl_Category.TabIndex = 2;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Authors
            // 
            this.lbl_Authors.AutoSize = true;
            this.lbl_Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Authors.Location = new System.Drawing.Point(256, 9);
            this.lbl_Authors.Name = "lbl_Authors";
            this.lbl_Authors.Size = new System.Drawing.Size(80, 25);
            this.lbl_Authors.TabIndex = 4;
            this.lbl_Authors.Text = "Authors";
            // 
            // cb_Authors
            // 
            this.cb_Authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Authors.FormattingEnabled = true;
            this.cb_Authors.Location = new System.Drawing.Point(261, 40);
            this.cb_Authors.Name = "cb_Authors";
            this.cb_Authors.Size = new System.Drawing.Size(203, 33);
            this.cb_Authors.TabIndex = 3;
            this.cb_Authors.SelectedIndexChanged += new System.EventHandler(this.Cb_Authors_SelectedIndexChanged);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(12, 118);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.Size = new System.Drawing.Size(922, 320);
            this.dataGridViewBooks.TabIndex = 5;
            // 
            // lbl_Books
            // 
            this.lbl_Books.AutoSize = true;
            this.lbl_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Books.Location = new System.Drawing.Point(12, 90);
            this.lbl_Books.Name = "lbl_Books";
            this.lbl_Books.Size = new System.Drawing.Size(67, 25);
            this.lbl_Books.TabIndex = 6;
            this.lbl_Books.Text = "Books";
            // 
            // txb_Search
            // 
            this.txb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_Search.Location = new System.Drawing.Point(742, 9);
            this.txb_Search.Name = "txb_Search";
            this.txb_Search.Size = new System.Drawing.Size(192, 30);
            this.txb_Search.TabIndex = 7;
            this.txb_Search.TextChanged += new System.EventHandler(this.txb_Search_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(853, 45);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(81, 28);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // btn_AllBooks
            // 
            this.btn_AllBooks.Location = new System.Drawing.Point(757, 444);
            this.btn_AllBooks.Name = "btn_AllBooks";
            this.btn_AllBooks.Size = new System.Drawing.Size(177, 28);
            this.btn_AllBooks.TabIndex = 9;
            this.btn_AllBooks.Text = "All books";
            this.btn_AllBooks.UseVisualStyleBackColor = true;
            this.btn_AllBooks.Click += new System.EventHandler(this.Btn_AllBooks_Click);
            // 
            // btn_InsertBooks
            // 
            this.btn_InsertBooks.Location = new System.Drawing.Point(12, 444);
            this.btn_InsertBooks.Name = "btn_InsertBooks";
            this.btn_InsertBooks.Size = new System.Drawing.Size(146, 28);
            this.btn_InsertBooks.TabIndex = 10;
            this.btn_InsertBooks.Text = "Insert Books";
            this.btn_InsertBooks.UseVisualStyleBackColor = true;
            this.btn_InsertBooks.Click += new System.EventHandler(this.Btn_InsertBooks_Click);
            // 
            // btn_DeleteBooks
            // 
            this.btn_DeleteBooks.Location = new System.Drawing.Point(316, 444);
            this.btn_DeleteBooks.Name = "btn_DeleteBooks";
            this.btn_DeleteBooks.Size = new System.Drawing.Size(146, 28);
            this.btn_DeleteBooks.TabIndex = 11;
            this.btn_DeleteBooks.Text = "Delete Books";
            this.btn_DeleteBooks.UseVisualStyleBackColor = true;
            this.btn_DeleteBooks.Click += new System.EventHandler(this.Btn_DeleteBooks_Click);
            // 
            // btn_UpdateBooks
            // 
            this.btn_UpdateBooks.Location = new System.Drawing.Point(164, 444);
            this.btn_UpdateBooks.Name = "btn_UpdateBooks";
            this.btn_UpdateBooks.Size = new System.Drawing.Size(146, 28);
            this.btn_UpdateBooks.TabIndex = 12;
            this.btn_UpdateBooks.Text = "Update Books";
            this.btn_UpdateBooks.UseVisualStyleBackColor = true;
            this.btn_UpdateBooks.Click += new System.EventHandler(this.Btn_UpdateBooks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 480);
            this.Controls.Add(this.btn_UpdateBooks);
            this.Controls.Add(this.btn_DeleteBooks);
            this.Controls.Add(this.btn_InsertBooks);
            this.Controls.Add(this.btn_AllBooks);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txb_Search);
            this.Controls.Add(this.lbl_Books);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.lbl_Authors);
            this.Controls.Add(this.cb_Authors);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.cb_Category);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Authors;
        private System.Windows.Forms.ComboBox cb_Authors;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Label lbl_Books;
        private System.Windows.Forms.TextBox txb_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_AllBooks;
        private System.Windows.Forms.Button btn_InsertBooks;
        private System.Windows.Forms.Button btn_DeleteBooks;
        private System.Windows.Forms.Button btn_UpdateBooks;
    }
}

