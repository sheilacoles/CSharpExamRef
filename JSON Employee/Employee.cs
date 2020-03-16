using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Employee
{
public class Employee
    {
        public string id { get; set; }
        public string employee_name { get; set; }
        public string employee_salary { get; set; }
        public string employee_age { get; set; }
        public string profile_image { get; set; }
}

    public class JsonResponse
    {
        public string status { get; set; }
        public Employee[] data { get; set; }
    }
}
