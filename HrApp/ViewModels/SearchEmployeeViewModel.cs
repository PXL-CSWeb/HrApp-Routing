using HrApp.Models;

namespace HrApp.Models
{
    public class SearchEmployeeViewModel
    {
        public string FirstName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
