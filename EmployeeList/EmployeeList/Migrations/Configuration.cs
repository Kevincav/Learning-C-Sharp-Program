namespace EmployeeList.Migrations
{
    using StreamStuff.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeList.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeList.Models.ApplicationDbContext context)
        {
            var reader = new System.IO.StreamReader(System.IO.File.OpenRead(
                @"C:\Users\Kevin\Documents\Visual Studio 2015\Projects\EmployeeList\EmployeeList\Migrations\EmployeeList.csv"));
                // System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "\\EmployeeList.csv")));

            System.Collections.Generic.List<Employee> employeeList = new System.Collections.Generic.List<Employee>();
            while (!reader.EndOfStream)
            {
                var values = reader.ReadLine().Split(',');
                employeeList.Add(
                    new Employee
                    {
                        FirstName = values[0],
                        LastName = values[1],
                        Address = values[2],
                        City = values[3],
                        State = values[4],
                        Zip = values[5],
                        Email = values[6],
                        Salary = double.Parse(values[7]),
                        EmployeeRank = (EmpRank)Enum.Parse(typeof(EmpRank), values[8]),
                        EmployeeType = (EmpType)Enum.Parse(typeof(EmpType), values[9])
                    }
                );
            }
            context.Employees.AddOrUpdate(p => p.FirstName, employeeList.ToArray());
        }
    }
}
