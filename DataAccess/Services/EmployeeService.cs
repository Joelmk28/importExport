using ImportExport.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImportExport.DataAccess.Services
{
    public class EmployeeService
    {
        private readonly DataContext dataContext;

        public EmployeeService(DataContext dataContext) { 
            this.dataContext = dataContext;
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await dataContext.employees.OrderBy(x=>x.FullName).ToListAsync();
        }


    }
}
