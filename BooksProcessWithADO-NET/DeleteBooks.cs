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
    public partial class DeleteBooks : Form
    {
        string connectionString = null;
        public DeleteBooks()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                try
                {
                    using (var conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = $"Delete From Books Where Id = @Id";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@Id", textBox1.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Delete succesfully!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Id verilmeyib!");
        }
    }
}
