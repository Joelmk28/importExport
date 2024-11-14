using ImportExport.Components.Pages;
using ImportExport.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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

        public bool CreateEmployee(Employee employee)
        {
            try
            {
                if (employee != null)
                {
                   

                    this.dataContext.employees.Add(employee);
                    var result =   this.dataContext.SaveChanges();

                    return result > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("---Add Employee Error : "+ ex);
                return false;
            }
        }


    }

    
}
