using System;
using System.Collections.Generic;
using System.Text;

namespace students2020
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGap)
        {
            name = aName;
            major = aMajor;
            gpa = aGap;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}

    





