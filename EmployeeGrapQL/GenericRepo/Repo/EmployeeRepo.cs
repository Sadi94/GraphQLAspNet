using EmployeeGrapQL.Data;
using EmployeeGrapQL.GenericRepo.Interface;
using EmployeeGrapQL.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeGrapQL.GenericRepo
{
    public class EmployeeRepo : IGenericRepo<Employee>
    {
        private readonly DataContext _context;
        public EmployeeRepo(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Employee>> AddItem(Employee employee)
        {
            var item = await _context.AddAsync(employee);
            _context.SaveChanges();
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> DeleteItem(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Remove(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.Include(a => a.department).ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return _context.Employees.Include(a => a.department).ToList().Find(a => a.Id == id);
        }

        public async Task<Employee> UpdateItem(int id, Employee emp)
        {
            var employee = await _context.Employees.FindAsync(id);
            employee.FirstName = emp.FirstName;
            employee.LastName = emp.LastName;
            employee.Email = emp.Email;
            return employee;
        }
    }
}
