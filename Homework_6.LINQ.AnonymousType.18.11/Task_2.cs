using System;
using System.Collections.Generic;
using System.Text;
using LINQ.HelpMaterial;
using System.Linq;

//    Используя коллекцию персонажей из проекта LINQ, создайте LINQ запрос, 
//    который будет отсеивать всех персонажей старше 100 лет и группировать их по Gender, 
//    полученые группы сгруппируйте по количеству элементов в группе и создайте анонимный тип, 
//    который будет включать в себя полученую группу, ее ключ и количество элементов.
//    Используйте 3 вложеный цикл чтоб вывести все элементы в группах.
namespace Homework_6.LINQ.AnonymousType._18._11
{
    class ClassWithAnonTypeTwo
    {
        public void AnonymousTypeMethod()
        {
            var humans = PersonsService.GetPersons();

            var groups = from human in humans
                         where human.Age < 100
                         group human by human.Gender into genderGroups
                         group genderGroups by genderGroups.Count() into sortedGroups
                         select new
                         {
                             Key = sortedGroups.Key,
                             Count = sortedGroups.Count(),
                             Group = sortedGroups
                         };

            foreach (var group in groups)
            {
                Console.WriteLine("Key:" + group.Key);
                foreach (var person in group)                    // ????????????????
                {
                    Console.Write(group.Count);
                }
            }
        }

    }
}
