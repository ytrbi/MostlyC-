using System;

namespace DatingProfile
{ 
    class Profile 
    {
        private string Name { get; set; } // Add the data type 'string'
        private int Age { get; set; }
        private string City { get; set; }
        private string Country { get; set; }
        private string Pronouns { get; set; }
        private string[] Hobbies { get; set; }

        public Profile
        (string n, int age, string city, string country, string p = "they/them")
        {
            Name = n;
            Age = age;
            City = city;
            Country = country;
            Pronouns = p;
            Hobbies = h;
        }
        
        public string ViewProfile () 
        {
          return $"name: {Name}, \nAge: {Age}, \nCity: {City}, \nCountry: {Country}, \nPronouns: {Pronouns}, \nHobbies: \n{Hobbies}"
        
        }
            static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            Console.WriteLine(sam.ViewProfile());
         
        }}}
