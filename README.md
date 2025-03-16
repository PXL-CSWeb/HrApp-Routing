# HrApp - Routing

- Voeg een class toe aan de ViewModels folder: ***SearchEmployeeViewModel***
```
    public class SearchEmployeeViewModel
    {
        public string FirstName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
```
- Maak een *Search* view aan in de Views/Employee folder
```
    @model HrApp.ViewModels.SearchEmployeeViewModel

    <form asp-action="Search" class="col-4 m-3">
        <div class="row mb-3">
            <div class="form-group">
                <label asp-for="FirstName" class="col-2 col-form-label"></label>
                <input asp-for="FirstName" class="form-control" />
            </div>
        </div>
        <div class="row mb-3">
            <input type="submit" value="Search" class="btn btn-primary" />
        </div>
    </form>

    <div class ="col-4 m-3">
        @foreach (Employee employee in Model.Employees)
        {
            <div class="card m-3">
                <div class="card-body p-3">
                    @* ==> Add hyperlink to Employee/Detail/{id} with FirstName & LastName as content <== *@
                </div>
            </div>
        }
    </div>
```
- Voeg bovenaan in de Employee/Index view een knop toe voor de navigatie naar de Search view 
- Maak een *Search* actie aan in de EmployeeController
```
public class EmployeeController
{
    ...

    public async Task<IActionResult> Search([FromForm] string firstName)
    {
        //TODO: Get all employee from repository

        var model = new SearchEmployeeViewModel();

        //TODO: Search employee with firstname...
        
        return View(model);
    }

    ...
}
```
> [!CAUTION]
> Hou er rekening mee dat de *firstName* parameter niet altijd ingevuld zal zijn