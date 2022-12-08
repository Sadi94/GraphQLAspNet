using EmployeeGrapQL.Data;
using EmployeeGrapQL.GenericRepo.Interface;
using Microsoft.EntityFrameworkCore;
using EmployeeGrapQL.Model;

namespace EmployeeGrapQL.GenericRepo.Repo
{
    public class DepartmentRepo : IGenericRepo<Department>
    {
        private readonly DataContext _context;

        public DepartmentRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> AddItem(Department department)
        {
            var item = await _context.AddAsync(department);
            _context.SaveChanges();
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department> DeleteItem(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            _context.Remove(department);
            await _context.SaveChangesAsync();
            return department;
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department> GetById(int id)
        {
            return await _context.Departments.FindAsync(id);
        }

        public async Task<Department> UpdateItem(int id, Department dept)
        {
            var department = await _context.Departments.FindAsync(id);
            department.Name = dept.Name;
            department.Phone = dept.Phone;
            return department;
        }
    }
}
