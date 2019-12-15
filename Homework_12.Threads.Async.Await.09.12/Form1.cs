using System;

using System.Data;
using System.Data.SqlClient;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_12.Threads.Async.Await._09._12
{
    public partial class Form1 : Form
    {
        string connectionStrings = @"Data Source=SOME1; Initial Catalog = mPolishchuk_CSharpAdvanced; Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }
       
        DataTable table = new DataTable();
        public async Task<DataTable> GetDataAsync(string command)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(command, connectionStrings))
            {
                await Task.Run(() => adapter.Fill(table));
            }
            return table;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string command = @"SELECT * FROM Characters";

            DataTable table = await GetDataAsync(command);

            dataGridView1.DataSource = table;
        }

    }
}
