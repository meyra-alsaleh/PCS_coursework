using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    class Person
    {
        private String name;
        private int age;

        public void SetName(String name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

    }
}
