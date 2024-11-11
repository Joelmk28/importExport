using ImportExport.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ImportExport.DataAccess
{
    public static class Generator
    {
        public static void GenerateEmpoyees(this ModelBuilder modelBuilder)
        {
            var employees = new List<Employee>
            {
                new Employee { EmployeId = 1, FullName = "Alice Dupont", Departement = "Marketing", DateOfBirth = new DateTime(1985, 5, 12), Age = 39, PhoneNumber = "0997916876" },
new Employee { EmployeId = 2, FullName = "Bernard Lefevre", Departement = "IT", DateOfBirth = new DateTime(1990, 3, 22), Age = 34, PhoneNumber = "0997916877" },
new Employee { EmployeId = 3, FullName = "Caroline Martin", Departement = "HR", DateOfBirth = new DateTime(1988, 7, 10), Age = 36, PhoneNumber = "0997916878" },
new Employee { EmployeId = 4, FullName = "David Dubois", Departement = "Sales", DateOfBirth = new DateTime(1992, 11, 1), Age = 32, PhoneNumber = "0997916879" },
new Employee { EmployeId = 5, FullName = "Daniel Kadima", Departement = "Marketing", DateOfBirth = new DateTime(1990, 12, 5), Age = 33, PhoneNumber = "0997916880" },
new Employee { EmployeId = 6, FullName = "Elisabeth Garnier", Departement = "IT", DateOfBirth = new DateTime(1986, 4, 15), Age = 38, PhoneNumber = "0997916881" },
new Employee { EmployeId = 7, FullName = "François Lemoine", Departement = "Finance", DateOfBirth = new DateTime(1984, 8, 25), Age = 40, PhoneNumber = "0997916882" },
new Employee { EmployeId = 8, FullName = "Gabrielle Dumont", Departement = "HR", DateOfBirth = new DateTime(1991, 9, 30), Age = 33, PhoneNumber = "0997916883" },
new Employee { EmployeId = 9, FullName = "Henri Clément", Departement = "IT", DateOfBirth = new DateTime(1983, 2, 18), Age = 41, PhoneNumber = "0997916884" },
new Employee { EmployeId = 10, FullName = "Isabelle Lefranc", Departement = "Sales", DateOfBirth = new DateTime(1995, 6, 2), Age = 29, PhoneNumber = "0997916885" },
new Employee { EmployeId = 11, FullName = "Julien Moreau", Departement = "Marketing", DateOfBirth = new DateTime(1987, 10, 25), Age = 37, PhoneNumber = "0997916886" },
new Employee { EmployeId = 12, FullName = "Katherine Bernard", Departement = "IT", DateOfBirth = new DateTime(1994, 1, 13), Age = 30, PhoneNumber = "0997916887" },
new Employee { EmployeId = 13, FullName = "Louis Lefevre", Departement = "Finance", DateOfBirth = new DateTime(1981, 6, 9), Age = 43, PhoneNumber = "0997916888" },
new Employee { EmployeId = 14, FullName = "Marie Lefevre", Departement = "HR", DateOfBirth = new DateTime(1993, 11, 21), Age = 31, PhoneNumber = "0997916889" },
new Employee { EmployeId = 15, FullName = "Nicolas Dufresne", Departement = "Sales", DateOfBirth = new DateTime(1990, 7, 17), Age = 34, PhoneNumber = "0997916890" },
new Employee { EmployeId = 16, FullName = "Olivier Vidal", Departement = "Marketing", DateOfBirth = new DateTime(1992, 4, 19), Age = 32, PhoneNumber = "0997916891" },
new Employee { EmployeId = 17, FullName = "Pauline Chretien", Departement = "IT", DateOfBirth = new DateTime(1989, 9, 3), Age = 35, PhoneNumber = "0997916892" },
new Employee { EmployeId = 18, FullName = "Quentin Renaud", Departement = "Finance", DateOfBirth = new DateTime(1986, 11, 28), Age = 38, PhoneNumber = "0997916893" },
new Employee { EmployeId = 19, FullName = "Raphaël Dufresne", Departement = "HR", DateOfBirth = new DateTime(1991, 2, 14), Age = 33, PhoneNumber = "0997916894" },
new Employee { EmployeId = 20, FullName = "Sophie Berger", Departement = "Sales", DateOfBirth = new DateTime(1990, 12, 1), Age = 34, PhoneNumber = "0997916895" },
new Employee { EmployeId = 21, FullName = "Thomas Lefranc", Departement = "Marketing", DateOfBirth = new DateTime(1985, 10, 17), Age = 39, PhoneNumber = "0997916896" },
new Employee { EmployeId = 22, FullName = "Ursula David", Departement = "IT", DateOfBirth = new DateTime(1988, 3, 25), Age = 36, PhoneNumber = "0997916897" },
new Employee { EmployeId = 23, FullName = "Vincent Boucher", Departement = "Finance", DateOfBirth = new DateTime(1994, 6, 18), Age = 30, PhoneNumber = "0997916898" },
new Employee { EmployeId = 24, FullName = "Wendy Dumont", Departement = "HR", DateOfBirth = new DateTime(1992, 12, 5), Age = 32, PhoneNumber = "0997916899" },
new Employee { EmployeId = 25, FullName = "Xavier Girard", Departement = "Sales", DateOfBirth = new DateTime(1987, 1, 20), Age = 37, PhoneNumber = "0997916900" },
new Employee { EmployeId = 26, FullName = "Yannick Bernard", Departement = "Marketing", DateOfBirth = new DateTime(1989, 8, 3), Age = 35, PhoneNumber = "0997916901" },
new Employee { EmployeId = 27, FullName = "Zoe Lefevre", Departement = "IT", DateOfBirth = new DateTime(1991, 11, 16), Age = 33, PhoneNumber = "0997916902" },


                new Employee { EmployeId = 28, FullName = "Noel Kazadi", Departement = "IT", DateOfBirth = new DateTime(1980, 5, 12), Age = 43, PhoneNumber = "123-456-7890" },
                new Employee { EmployeId = 29, FullName = "Joel Kirengo", Departement = "HR", DateOfBirth = new DateTime(1985, 7, 19), Age = 38, PhoneNumber = "234-567-8901" },
                new Employee { EmployeId = 30, FullName = "Joel Muhindo", Departement = "Finance", DateOfBirth = new DateTime(1992, 10, 22), Age = 31, PhoneNumber = "345-678-9012" },
                new Employee { EmployeId = 31, FullName = "Claudien Green", Departement = "Sales", DateOfBirth = new DateTime(1988, 3, 30), Age = 35, PhoneNumber = "456-789-0123" },
                new Employee { EmployeId = 32, FullName = "Jonathan Mutendi", Departement = "Marketing", DateOfBirth = new DateTime(1990, 12, 5), Age = 33, PhoneNumber = "567-890-1234" },
                new Employee { EmployeId = 33, FullName = "Gabriel Kanyibu", Departement = "IT", DateOfBirth = new DateTime(1980, 5, 12), Age = 43, PhoneNumber = "0997916872" },
                new Employee { EmployeId = 34, FullName = "Bob Smith", Departement = "HR", DateOfBirth = new DateTime(1985, 7, 19), Age = 38, PhoneNumber = "0997916873" },
                new Employee { EmployeId = 35, FullName = "Bob Smith", Departement = "HR", DateOfBirth = new DateTime(1985, 7, 19), Age = 38, PhoneNumber = "0997916873" },
                new Employee { EmployeId = 36, FullName = "Bob Smith", Departement = "HR", DateOfBirth = new DateTime(1985, 7, 19), Age = 38, PhoneNumber = "0997916873" },
                new Employee { EmployeId = 37, FullName = "Charlie Brown", Departement = "Finance", DateOfBirth = new DateTime(1992, 10, 22), Age = 31, PhoneNumber = "0997916874" },
                new Employee { EmployeId = 38, FullName = "Diana Green", Departement = "Sales", DateOfBirth = new DateTime(1988, 3, 30), Age = 35, PhoneNumber = "0997916875" },
                new Employee { EmployeId = 39, FullName = "Edward White", Departement = "Marketing", DateOfBirth = new DateTime(1990, 12, 5), Age = 33, PhoneNumber = "0997916876" },
               
               
            };

            foreach(Employee employee in employees) {
                modelBuilder.Entity<Employee>().HasData(employee);
            }
           


        }
    }
}
