using System;

namespace CollectionsLib
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            Employee emp = obj as Employee;

            if (emp == null)
            {
                return false;
            }

            return this.Id == emp.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}