using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
           
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                               
                }
                else
                {
                    name = value;
                }
            
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value<=0)
                {

                    throw new ArgumentException("Invalid input!");
                
                }
                else 
                {
                    age = value;
                }
            
            }
        }
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                else 
                {
                    gender = value;
                }
                        
            }

        }
        //public virtual string ProduceSound() 
        //{
        //    return string.Empty;
        //}

        public virtual string ProduceSound() // тук си разцъквам нещо мое
        {
            return string.Empty;
        }

        public override string ToString()
        {
            return this.GetType().Name +
                   Environment.NewLine +
            $"{this.Name} {this.Age} {this.Gender}";
                       
        }
    }
}