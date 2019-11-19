using System;
using LINQ.HelpMaterial;
using System.Linq;

//    Используя коллекцию персонажей из проекта LINQ, создайте LINQ запрос,
//    в котором выберите анонимный тип который будет содержать в себе свойство 
//    PersonDescription - это должны быть строка, в которой прописаны значения всех свойств персонажа.
namespace Homework_6.LINQ.AnonymousType._18._11
{
    public class ClassWithAnonType
    {
        public void MyAnonymousType()
        {
            var humans = PersonsService.GetPersons();

            var persons = from person in humans
                          select new
                          {
                              PersonDescriprion = person.FirstName + " " +
                              person.LastName + " " + person.Gender + " " + person.Age
                          };
            foreach (var person in persons)
            {
                Console.WriteLine(person.PersonDescriprion);
            }
        }
    }
}
