using System;
using System.Collections.Generic;
using System.Text;
using InClassExercise_Classes;

namespace Professor
{
    class Professor : InClassExercise_Classes.Person
    {
        public string Employee_ID;

        public Professor()
        {
            Employee_ID = "P1234";
        }

        public Professor(string PNumber, string Isal, string ftName, string ltName) : base(ltName)
        {
            Employee_ID = PNumber;
        }

        new public string getName()
        {
            return Employee_ID + " " + base.getName();
        }
    }
}
