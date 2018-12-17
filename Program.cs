using System;
using MyPhonebook.Models;
using System.Linq;

namespace MyPhonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new Phonebook11Context();
            var contacts = dbContext.Contacts.ToList();
            foreach (var c in contacts)
            {
                System.Console.WriteLine($"Name:{c.Name}");
            }
        }
    }
}
