using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository() 
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mary", Department = "CSE", Email = "mary@gmail.com"},
                new Employee() {Id = 2, Name = "John", Department = "EEE", Email = "john@gmail.com"},
                new Employee() {Id = 3, Name = "Sam", Department = "ETE", Email = "sam@gmail.com"},
            };
        }

        public Employee GetEmployee(int Id)
        {
            //return _employeeList.FirstOrDefault(x => x.Id == Id);
            return _employeeList.Find(x=>x.Id == Id);
        }
    }
}
