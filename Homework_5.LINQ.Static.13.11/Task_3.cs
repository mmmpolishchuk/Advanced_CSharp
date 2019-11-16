using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_5.LINQ.Static._13._11
{
    public enum BodyParts
    {
        Head,
        Legs,
        Arms
    }
    public class Human
    {
        public BodyParts MostImportantBodyPart { get; set; }
    }
    public static class HumanExtension
    {
        public static BodyParts Evolve(this Human human)
        {
            human.MostImportantBodyPart = BodyParts.Arms;
            return human.MostImportantBodyPart;
        }
    }
}
