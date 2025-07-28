using System;
using System.Threading.Tasks;
using School.Application.Dtos.Department;
using School.Application.Service;

namespace School.ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var departmentService = new DepartamentService();

            var newDepartment = new DepartmentDto
            {
                Name = "Tecnología",
                Description = "Departamento encargado del desarrollo tecnológico"
            };

            var added = await departmentService.AddAsync(newDepartment);

            Console.WriteLine($"✅ Departamento agregado: {added.Name} (ID: {added.Id})");

            var list = await departmentService.GetAllAsync();

            Console.WriteLine("\n📋 Lista de departamentos:");
            foreach (var dept in list)
            {
                Console.WriteLine($"- {dept.Name} | {dept.Description}");
            }
        }
    }
}



