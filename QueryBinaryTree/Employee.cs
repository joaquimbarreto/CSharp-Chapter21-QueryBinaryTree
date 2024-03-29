﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QueryBinaryTree
{
    class Employee : IComparable<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public int Id { get; set; }

        public override string ToString() => $"ID: {this.Id}, Name: {FirstName} {LastName}, Department: {this.Department}";

        int IComparable<Employee>.CompareTo(Employee other)
        {
            if (other == null)
            {
                return 1;
            }
            if (this.Id > other.Id)
            {
                return 1;
            }
            if (this.Id < other.Id)
            {
                return -1;
            }
            return 0;
        }
    }
}
