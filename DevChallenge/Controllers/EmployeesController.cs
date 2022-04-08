using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DevChallenge.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        //Employee[] l = { new Employee(1, "Kindson", "Munonye", "Budapest", "2018-03-09"), new Employee(1, "Kindson", "Munonye", "Budapest", "2018-03-09") };
        
        public List<Employee> employees = new List<Employee>();

        public EmployeesController()
        {
            employees.Add(new Employee(1, "Kindson", "Munonye", "Budapest", "2018-03-09"));
            employees.Add(new Employee(2, "Oleander", "Yuba", "Nigeria", "2018-03-09"));
        }



        //employees.Add(new Employee(1, "Kindson", "Munonye", "Budapest", DateTime.Today));
        //employees.Add(new Employee(2, "Oleander", "Yuba", "Nigeria", DateTime.Today));
        //employees.Add(new Employee(3, "Saffron", "Lawrence", "Lagos", DateTime.Today));
        //employees.Add(new Employee(4, "Jadon", "Munonye", "Asaba", DateTime.Today));
        //employees.Add(new Employee(5, "Solace", "Okeke", "Oko", DateTime.Today));

        // GET: api/Employees
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            

            return employees;
        }

        // GET: api/Employees/5
        [HttpGet("{id}", Name = "Get")]
        public Employee Get(int id)
        {
            Employee employee = employees.Find(f => f.id == id);
            return employee;
        }

        // POST: api/Employees
        [HttpPost]
        public IEnumerable<Employee> Post([FromBody] Employee value)
        {
            employees.Add(new Employee(1, "Kindson", "Munonye", "Budapest", "2018-03-09"));
            employees.Add(new Employee(2, "Oleander", "Yuba", "Nigeria", "2018-03-09"));
            Console.WriteLine(value.firstname);
            employees.Add(value);
            return employees;
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public Employee Put(int id, [FromBody] Employee value)
        {
            Employee friendToUpdate = employees.Find(f => f.id == id);
            int index = employees.IndexOf(friendToUpdate);

            employees[index].firstname = value.firstname;
            employees[index].lastname = value.lastname;
            employees[index].location = value.location;
            employees[index].dateOfHire = value.dateOfHire;

            return employees.Find(f => f.id == id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Employee> Delete(int id)
        {
            Employee employee = employees.Find(f => f.id == id);
            employees.Remove(employee);
            return employees;
        }
    }
}

