using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


namespace test.Pages
{
    public class EmployeeListBase : Microsoft.AspNetCore.Components.ComponentBase
    {
        [Inject]
        protected HttpClient Http { get; set; }

        [Parameter]

        public Employees[] Employees { get; set; }


        protected override async Task OnInitializedAsync()
        {


            Employees = await Http.GetJsonAsync<Employees[]>("sample-data/Employees.json").ConfigureAwait(false);
            //Just setting delay on Task to demonstrate MatBlazor.MatProgressBar
            await Task.Delay(500).ConfigureAwait(false);
        }

    }
    public class Employees
    {

        public string FullName { get; set; }
        public string jobTitle { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        //conditional properties
        public string genderColor
        {
            get { return genderColor; }
            set
            {
                genderColor = value;
                if (gender == "male")
                {
                    genderColor = "blue";
                }
                else
                {
                    genderColor = "pink";
                }

            }
        }
    }
}
