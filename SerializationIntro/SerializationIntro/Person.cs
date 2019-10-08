using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationIntro
{
    public class Person
    {

        //this is something called "POCO" - a class with just public get-set props and default constructor
        //"DTO"-data transfer object: data container for moving data between layers
        public int Id {get; set;}
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
