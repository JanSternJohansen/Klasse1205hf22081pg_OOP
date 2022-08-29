using System;

namespace MyFirstClass
{
    internal class Person
    {
        // Fields
        private string name;
        private int age;
       
        public Person()
        {

        }

        public Person(string n, int a)
        {
            this.name = n;
            this.age = a;
        }

        //Get og Set methods

        public void setName(string n)
        {
            name = n;
        }
        public string getName()
        {
            return name;
        }
        //public void setAge(int age)
        //{
        //    if (age > 0)
        //    {
        //        this.age = age;
        //    }
        //}
        //public int getAge()
        //{
        //    return age;
        //}

        //Properties
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        //Automatisk Property
        //public String Name { get; set; }

    }
}