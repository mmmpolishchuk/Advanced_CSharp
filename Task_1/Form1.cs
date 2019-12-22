using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Task_1
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Character> characters = new List<Character>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (characters.Count() < 10)
            {
                characters.Add(new Character() { FirstName = "Finn", LastName = "Mertens", Gender = true, Age = 14 });
                characters.Add(new Character() { FirstName = "Philip", LastName = "Fry", Gender = true, Age = 25 });
                characters.Add(new Character() { FirstName = "Arven", LastName = "Undomiel", Gender = false, Age = 2700 });
                characters.Add(new Character() { FirstName = "Audrey", LastName = "Hepburn", Gender = false, Age = 29 });
                characters.Add(new Character() { FirstName = "John", LastName = "Wick", Gender = true, Age = 42 });
                characters.Add(new Character() { FirstName = "Anakin", LastName = "Skywalker", Gender = true, Age = 29 });
                characters.Add(new Character() { FirstName = "Princess", LastName = "Bubblegum", Gender = false, Age = 827 });
                characters.Add(new Character() { FirstName = "Svetlana", LastName = "Sokolova", Gender = false, Age = 45 });
                characters.Add(new Character() { FirstName = "Varian", LastName = "Wrynn", Gender = true, Age = 42 });
                characters.Add(new Character() { FirstName = "Harry", LastName = "Seldon", Gender = true, Age = 35 });
            }

            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            bool gender = bool.Parse(textBox3.Text);
            int age = int.Parse(textBox4.Text);

            characters.Add(new Character()
            {
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                Age = age
            });

            dataGridView1.DataSource = characters;
        }
    }
}
