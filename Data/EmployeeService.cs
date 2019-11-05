using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using static System.Net.WebRequestMethods;

namespace test.Data
{
    public class EmployeeService
    {
        private static readonly string[] Names = new[]
      {
            "Rajni Kumar", "Hans Martin Mohn", "Prasad Rao", "Lars Røine", "Rolf Anders","Tarjei"
        };
        //Select random employee from the list but remove dubpicates. 
        //I have used groupBy to remove dublicates. tried with distinct but it didn't work
        public Task<Employees[]> GetEmployeesAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 10).Select(index => new Employees
            {
                FullName = Names[rng.Next(Names.Length)],
                jobTitle = "System developer"

            }).GroupBy(x => x.FullName).Select(y => y.First()).ToArray());
        }
        
        }
    }
