using System;
using System.IO;
using System.Text.Json;

namespace Second_task
{
    [Serializable]
    public class SerializeClass
    {
        //private static Person human = new Person("James", "Bond", true, 34);
        //public static Person human = new Person();
        private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        public async void SerializeMethod()
        {
            using (FileStream stream = new FileStream(@"D:\Homework\Human.txt", FileMode.OpenOrCreate))
            {
                Person human = new Person("James", "Bond", true, 34);

                await JsonSerializer.SerializeAsync(stream, human, options);
                Console.WriteLine(human.FirstName + " " + human.LastName + " is serialized.");
            }
        }

        public async void DeserializeMethod()
        {
            using (FileStream stream = File.OpenRead(@"D:\Homework\Human.txt") )
            {
                Person getHuman = await JsonSerializer.DeserializeAsync<Person>(stream);
                Console.WriteLine(getHuman.FirstName + " " + getHuman.LastName + " deserialized.");
            }
        }
    }
}
