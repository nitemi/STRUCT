using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRUCT
{
    internal struct BookStruct
    {
        //Make a Book class with Title and Author. Show difference when copying a struct vs a class
        public string Title;
        public string Author;
        public BookStruct(string title, string author)
        {
            Title = title; Author = author;
        }
        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }
}
