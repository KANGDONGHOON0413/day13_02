
using day13_02.Models;
using System;
using System.Linq;

namespace day13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //db객체 생성
            Mydb db = new Mydb();
            
            //     insert 문
            Employee emp = new Employee
            {
                Name = "Tomy",
                DOB = new DateTime(1999, 4, 13),
                Salary = 50000
            };

            db.Employees.Add(emp);

            //2
            Employee emp2 = new Employee
            {
                Name = "Tomy2",
                DOB = new DateTime(2000, 5, 14),
                Salary = 30000
            };

            db.Employees.Add(emp2);

            db.SaveChanges();

            //select문
            var emps = db.Employees.Where(p => p.Id >= 1);

            foreach (var item in emps) Console.WriteLine("{0}, {1}", item.Id, item.Name);

        }
    }
}
