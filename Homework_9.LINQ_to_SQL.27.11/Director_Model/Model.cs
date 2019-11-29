using Microsoft.OData.Edm;
using System;
using System.Data.Linq.Mapping;

namespace Homework_10.LINQ_to_SQL._27._11
{
    // Создайте проект, подключите Linq to Sql, задайте строку подключения к ранее созданной вами 
    // базе данных Cinema, создайте в базе таблицу Directors c полями Id, FirstName, LastName, BirthDate.
    // Заполните таблицу неколькими режисерам с помощью методов Linq To Sql.

    [Table(Name = "Directors")]
    public class Directors
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column]
        public string FirstName { get; set; }

        [Column]
        public string LastName { get; set; }

        [Column]
        public DateTime? BirthDate { get; set; }
    }
}
