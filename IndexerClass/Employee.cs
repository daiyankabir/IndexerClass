using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerClass
{
    class Employee
    {
        int Id, Experience;
        double Salary;
        string Name, Designation, Office_Location;

        public Employee(int id, int experience, double salary,
            string name, string designation, string officeLocation)
        {
            this.Id = id;
            this.Experience = experience;
            this.Salary = salary;
            this.Name = name;
            this.Designation = designation;
            this.Office_Location = officeLocation;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Id;
                else if (index == 1)
                    return Experience;
                else if (index == 2)
                    return Salary;
                else if (index == 3)
                    return Name;
                else if (index == 4)
                    return Designation;
                else if (index == 5)
                    return Office_Location;
                return null;
            }
            set
            {
                if (index == 0)
                    Id = (int)value;
                else if (index == 1)
                    Experience = (int)value;
                else if (index == 2)
                    Salary = (double)value;
                else if (index == 3)
                    Name = (string)value;
                else if (index == 4)
                    Designation = (string)value;
                else if (index == 5)
                    Office_Location = (string)value;                
            }
        }

        public object this[string index]
        {
            get
            {
                if (index == "Id")
                    return Id;
                else if (index == "Experience")
                    return Experience;
                else if (index == "Salary")
                    return Salary;
                else if (index == "Name")
                    return Name;
                else if (index == "Designation")
                    return Designation;
                else if (index == "Office_Location")
                    return Office_Location;
                return null;
            }
            set
            {
                if (index == "Id")
                    Id = (int)value;
                else if (index == "Experience")
                    Experience = (int)value;
                else if (index == "Salary")
                    Salary = (double)value;
                else if (index == "Name")
                    Name = (string)value;
                else if (index == "Designation")
                    Designation = (string)value;
                else if (index == "Office_Location")
                    Office_Location = (string)value;
            }
        }
    }
}
