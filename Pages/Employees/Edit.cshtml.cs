using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorpagesExample.Models;
using razorpagesExample.Repository;

namespace razorpagesExample.Pages.Employees;

public class EditModel:PageModel
{
    private readonly IEmployeeRepository _employeeRepository;
    public EditModel(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }
    public Employee Employee {get; set;} = null!;
    public void OnGet(int id)
    {
        Employee = _employeeRepository.GetById(id);

    }

    public IActionResult OnPost(Employee employee)
    {
        Employee = _employeeRepository.Update(employee);
        return RedirectToPage("/Employees/Index");
    }
}