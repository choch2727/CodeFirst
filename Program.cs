﻿using System;

namespace CodeFirst
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        //public Author Author { get; set; }
        //public IList<Tag> Tags { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
