using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework_10.LINQ_to_SQL._27._11.Director_Manipulating;

namespace Homework_10.LINQ_to_SQL._27._11
{
    public partial class Directors_Form : Form
    {
        //Director_Context dbDirector;
        DataContext dtContext = new DataContext(ConfigurationManager.ConnectionStrings["ConnectToDb"].ToString());
        public Directors_Form()
        {
            InitializeComponent();

            //dbDirector = new Director_Context();
            //dbDirector.Directors.Load();
            //dgvDirectors.DataSource = dbDirector.Directors.Local.ToBindingList();
        }

        private void btnAddDirector_Click(object sender, EventArgs e)
        {
            //DataContext dtContext = new DataContext(ConfigurationManager.ConnectionStrings["ConnectToDb"].ToString());

            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            DateTime? birthDate = DateTime.Parse(tbBirthDate.Text);

            dtContext.GetTable<Directors>().InsertOnSubmit(
                new Directors
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate
                });

            dtContext.SubmitChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var delDirector = dtContext.GetTable<Directors>().Where(x => x.Id > dtContext.GetTable<Directors>().Count()-2); // delete 2 last directors 
            dtContext.GetTable<Directors>().DeleteAllOnSubmit(delDirector);
            dtContext.SubmitChanges();              
        }
    }
}
