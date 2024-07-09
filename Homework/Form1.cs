using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        public static SqlConnection connection;
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString.Text);
                connection.Open();
                statusLbl.Text = "З'єднання з БД відбулося успішно.";
                Form2 form2 = new Form2();
                form2.Show();
            }
            catch (Exception ex)
            {
                statusLbl.Text = $"Помилка з'єднання: {ex.Message}";
                statusLbl.ForeColor = Color.Red;
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    statusLbl.Text = "Роз'єдання відбулося успішно.";
                }
            }
            catch (Exception ex)
            {
                statusLbl.Text = $"Помилка роз'єднання: {ex.Message}";
                statusLbl.ForeColor = Color.Red;
            }
        }
    }
}
