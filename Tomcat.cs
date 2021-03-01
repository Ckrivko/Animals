using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string Defaultgender = "male";

        public Tomcat(string name, int age)
            : base(name, age, Defaultgender)
        {

        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
