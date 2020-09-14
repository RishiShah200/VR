using System;
using System.Collections.Generic;
using System.Text;

namespace Demo2
{
    class Person
    {
        private string firstName;
        private string eyeColor;
        private int daysAlive;

        public string LastName { get; set; } //properties are capatilized

        public float YearsAlive
        {
            get
            {
                return (float)(daysAlive / 365.0);
            }

            set
            {
                daysAlive = (int)(value * 365); //value is the input from the user
            }
        }

        public Person(string firstName, int daysAlive)
        {
            this.firstName = firstName;
            this.daysAlive = daysAlive;
        }

        public Person(string firstName, string eyeColor, int daysAlive)
            : this(firstName, daysAlive) //calls the previous consturctor and fills in the properties. Constructor chaining.
        {
            this.eyeColor = eyeColor;
        }

        public override string ToString()
        {
            return "first name " + firstName + "eyes: " + eyeColor;
        }


    }




}
