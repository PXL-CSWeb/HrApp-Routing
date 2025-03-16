using HrApp.ViewModels;

namespace HrApp.ViewModels
{
    public class SearchEmployeeViewModel
    {
        public string FirstName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
