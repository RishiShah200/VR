using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTest
{
    class Elminster
    {
        private string name;
        private string characterClass;
        private int experience;

        public double Level
        {
            get
            {
                if(((experience%1000)) == 500)
                {
                    return (experience / 1000) + 1;
                }
                return experience / 1000;
            }
        }


        public Elminster((string,string) nameAndClass)
        {
            this.name = nameAndClass.Item1;
            this.characterClass = nameAndClass.Item2;
            experience = 0;
        }

        public void AddExperience(int num)
        {
            experience += num;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} , Class: {1} , and Level: {2}",name,characterClass,Level);
        }
    }
}
