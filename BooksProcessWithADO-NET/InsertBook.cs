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
    public partial class InsertBook : Form
    {
        string connectionString = null;
        public InsertBook()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["myConnString"].ConnectionString;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = $"Insert into Books Values (@Id,@Name,@Pages,@YearPress,@Id_Themes,@Id_Category,@Id_Author,@Id_Press,@Comment,@Quantity)";
                SqlCommand command = new SqlCommand(query, conn);
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Id", txbId.Text);
                command.Parameters.AddWithValue("@Name", txbName.Text);
                command.Parameters.AddWithValue("@Pages", txbPages.Text);
                command.Parameters.AddWithValue("@YearPress", txbYearPress.Text);
                command.Parameters.AddWithValue("@Id_Themes", txbId_Themes.Text);
                command.Parameters.AddWithValue("@Id_Category", txbId_Category.Text);
                command.Parameters.AddWithValue("@Id_Author", txbId_Category.Text);
                command.Parameters.AddWithValue("@Id_Press", txbId_Press.Text);
                command.Parameters.AddWithValue("@Comment", txbComment.Text);
                command.Parameters.AddWithValue("@Quantity", txbQuantity.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Succesfully!");
                this.Close();
                
            }
        }
    }
}
