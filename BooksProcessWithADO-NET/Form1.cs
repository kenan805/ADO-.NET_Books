using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksProcessWithADO_NET
{
    public partial class Form1 : Form
    {
        string connectionString = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    da = new SqlDataAdapter($"select * from Books", conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewBooks.DataSource = dt;

                    var queries = "Select Name From Categories; Select FirstName + LastName From Authors";
                    SqlCommand command = new SqlCommand(queries, conn);
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        int next = 0;
                        do
                        {
                            while (dataReader.Read())
                            {
                                switch (next)
                                {
                                    case 0:
                                        cb_Category.Items.Add(dataReader.GetValue(0));
                                        break;
                                    case 1:
                                        cb_Authors.Items.Add(dataReader.GetValue(0));
                                        break;
                                }
                            }
                            next++;
                        } while (dataReader.NextResult());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void Cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    da = new SqlDataAdapter($"select Books.* from Books inner join Categories on Categories.Id = Books.Id_Category Where Categories.Name = '{cb_Category.SelectedItem.ToString()}'", conn);
                    dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewBooks.DataSource = dt;
                    cb_Authors.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void Cb_Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    da = new SqlDataAdapter($"select Books.* from Books inner join Authors on Books.Id_Author = Authors.Id Where Authors.FirstName + Authors.LastName = '{cb_Authors.SelectedItem.ToString()}'", conn);
                    dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewBooks.DataSource = dt;
                    cb_Category.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (txb_Search.Text != string.Empty)
            {
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        da = new SqlDataAdapter($"select * from Books Where Name = '{txb_Search.Text}'", conn);
                        dt = new DataTable();
                        da.Fill(dt);

                        dataGridViewBooks.DataSource = dt;
                        cb_Category.ResetText();
                        cb_Authors.ResetText();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Search textbox is empty!");
            }
        }

        private void Btn_AllBooks_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    da = new SqlDataAdapter($"select * from Books", conn);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewBooks.DataSource = dt;
                    cb_Authors.ResetText();
                    cb_Category.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void Btn_InsertBooks_Click(object sender, EventArgs e)
        {
            var insBookForm = new InsertBook();
            insBookForm.StartPosition = FormStartPosition.CenterParent;
            insBookForm.ShowDialog();
        }

        private void Btn_UpdateBooks_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    da = new SqlDataAdapter($"select * from Books", conn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
                    da.Update(dt);
                    MessageBox.Show("Update successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void Btn_DeleteBooks_Click(object sender, EventArgs e)
        {
            Form dltForm = new DeleteBooks();
            dltForm.ShowDialog();
        }

        private void txb_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    da = new SqlDataAdapter($"select * from Books Where Name Like '{txb_Search.Text}%'", conn);
                    dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewBooks.DataSource = dt;
                    cb_Category.ResetText();
                    cb_Authors.ResetText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}

