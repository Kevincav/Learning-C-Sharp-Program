using System.ComponentModel.DataAnnotations;
using System.Globalization;
namespace StreamStuff.Models
{
    public enum EmpType { FTE, Intern, Contractor }
    public enum EmpRank { SWE, SWE_II, Senior_SWE, Manager, Senior_Manager }
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public double Salary { get; set; }
        public EmpRank EmployeeRank { get; set; }
        public EmpType EmployeeType { get; set; }
    }
}