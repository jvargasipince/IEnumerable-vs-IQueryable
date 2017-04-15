using System;
using System.Linq;

namespace Projection_EF
{
    public class LoadData_IQueryable
    {
        static void Main(string[] args)
        {
            GetListEmployees();
        }


        private static void GetListEmployees()
        {
            var AWEntitiesContext = new AdventureWorks2014Entities();

            IQueryable<Employee> EmployeeList = AWEntitiesContext.Employees.Where(p => p.MaritalStatus.Equals("m", StringComparison.CurrentCultureIgnoreCase));
            EmployeeList = EmployeeList.Take(10);

            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine("Los datos del empleado son: ");
                Console.WriteLine("Nro. Documento del empleado : " + employee.NationalIDNumber);
                Console.WriteLine("Puesto : " + employee.JobTitle);
                Console.WriteLine("Fecha Nacimiento : " + employee.BirthDate.ToShortDateString());
                Console.WriteLine("Estado Civil : " + employee.MaritalStatus);

                Console.WriteLine("Pulse una tecla para continuar");
                Console.ReadKey();
            }

        }


    }
}
