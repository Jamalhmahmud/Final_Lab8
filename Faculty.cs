﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLT8a
{
    class Faculty
    {

        public string Name { get; set; }
        public string Id { get; set; }
        public Faculty() { }
        public Faculty(string Name, string Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
        public void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Id: " + Id);
        }
    }
}
