using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDex
{
    public enum Gender
    {
        Male,
        Female
    }
    public enum Position
    {
        Administrator,
        Manager,
        Executive
    }
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }
    #region Changes
    //public class EmployeeManager
    //{
    //    private readonly List<Employee> _employees;

    //    public EmployeeManager()
    //    {
    //        _employees = new List<Employee>();
    //    }
    //    public void AddEmployee(Employee employee)
    //    {
    //        _employees.Add(employee);
    //    }
    //    public List<Employee> Employees => _employees;
    //}
    //public class EmployeeStatistics
    //{
    //    private readonly EmployeeManager _empManager;
    //    public EmployeeStatistics(EmployeeManager empManager)
    //    {
    //        _empManager = empManager;
    //    }
    //    public int CountFemaleManagers() =>
    //      _empManager.Employees.Count(emp => emp.Gender == Gender.Female && emp.Position == Position.Manager);
    //} 
    #endregion
    /*
     * Well, first of all, our EmployeeStatistics class has a strong relation (coupled) to the EmployeeManager class and we can’t send any other object in the EmployeeStatistics constructor except the EmployeeManager object. 
     * The second problem is that we are using the public property from the low-level class inside the high-level class.
     * By doing so, our low-level class can’t change its way of keeping track of employees.
     * If we want to change its behavior to use a dictionary instead of a list, we need to change the EmployeeStatistics class behavior for sure. 
     * And that’s something we want to avoid if possible.
     */

    public interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender,Position position);
    }
    public class EmployeeManager:IEmployeeSearchable
    {
        private readonly List<Employee> _employees;
        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
        {
            var e = _employees.Where(emp => emp.Gender == gender && emp.Position == position);
            return e;
        }
    }
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _emp;
        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }
        public int CountFemaleManagers() =>
        _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}
