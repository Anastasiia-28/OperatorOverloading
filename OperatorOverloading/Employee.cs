namespace OperatorOverloading
{
    public class Employee
    {
        public int Salary { get; set; }

        public static int operator +(Employee employee, int value)
        {
            return employee.Salary + value;
        }
        public static int operator -(Employee employee, int value)
        {
            return employee.Salary - value;
        }
        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }
        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            //return Object.Equals(employee1, employee2);
            if (employee1.Salary == employee2.Salary)
                return true;

            return false;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            //return !Object.Equals(employee1, employee2);
            if (employee1.Salary != employee2.Salary)
                return true;

            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee objectType)
                return Salary == objectType.Salary;

            return false;
        }

        //public override int GetHashCode()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
