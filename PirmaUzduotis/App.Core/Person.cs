using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core
{
    public class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        private bool _married;

        public bool Married
        {
            get { return _married; }
            set { _married = value; }
        }
        private int _childs;

        public int Childs
        {
            get { return _childs; }
            set { _childs = value; }
        }

        public Person(string name, double salary, bool married, int childrens)
        {
            this.Name = name;
            this.Salary = salary;
            this.Married = married;
            this.Childs = childrens;
        }
    }
}
