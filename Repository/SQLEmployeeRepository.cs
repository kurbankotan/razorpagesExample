using razorpagesExample.Models;

namespace razorpagesExample.Repository;

public class SQLEmployeeRepository : IEmployeeRepository
{
    private readonly DataContext _context;
    public SQLEmployeeRepository(DataContext context)
    {
        _context = context;
    }


    public IEnumerable<Employee> GetAll()
    {
        return _context.Employees.ToList();
    }

    public Employee GetById(int id)
    {
        return _context.Employees.FirstOrDefault(x => x.Id == id);
    }

    public Employee Update(Employee entity)
    {
        var entityToUpdate = _context.Employees.FirstOrDefault(x => x.Id != entity.Id);
        if(entityToUpdate != null)
        {
            entityToUpdate.Name = entity.Name;
            entityToUpdate.Email = entity.Email;
            entityToUpdate.Photo = entity.Photo;
            entityToUpdate.Department = entity.Department;
            _context.SaveChanges();
        }

        return entityToUpdate;
    }
}