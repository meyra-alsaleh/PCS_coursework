using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseObject
{
    public class Course
    {

        // Instance variables 
        private String name;
        private int ec;

        // Constructor
        public Course(String name, int ec)
        {
            this.name = name;
            this.ec = ec;
        }

        // Methods 
        public void SetName(String name)
        { 
            this.name = name; 
        }
        public String GetName()
        { 
            return this.name; 
        }

        public void SetEc(int ec)
        { 
            this.ec = ec; 
        }
        public int GetEc()
        { 
            return this.ec; 
        }

    }
}
