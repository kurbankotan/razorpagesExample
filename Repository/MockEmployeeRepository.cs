using razorpagesExample.Models;

namespace razorpagesExample.Repository;

public class MockEmployeeRepository : IEmployeeRepository
{
    private List<Employee> _employeeList;

    public MockEmployeeRepository()
    {
        _employeeList = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Mustafa KOTAN", Email = "mustafa@kotan.com",  Photo = "1.jpg", Department = "Muhasebe" },
            new Employee { Id = 2, Name = "Selim KOTAN", Email = "selim@kotan.com",  Photo = "2.jpg", Department = "Operasyon" },
            new Employee { Id = 3, Name = "Vefa KOTAN", Email = "vefa@kotan.com",  Photo = "3.jpg", Department = "İnsan Kaynakları" },
            new Employee { Id = 4, Name = "Kurban KOTAN", Email = "kurban@kotan.com",  Photo = "4.jpg", Department = "Bilgi İşlem" },
        };
    }

    public IEnumerable<Employee> GetAll()
    {
        return _employeeList;
    }
}