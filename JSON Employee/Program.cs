using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            GetRequest();
            Console.ReadKey();      

        }

        public static void GetRequest()
        {
            string html = string.Empty;
            string url = @"http://dummy.restapiexample.com/api/v1/employees";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            var jsonResponnse = JsonConvert.DeserializeObject<JsonResponse>(html);
            foreach(var employee in jsonResponnse.data)
            {
                Console.WriteLine($"EmployeeId={employee.id}, EmployeeName={employee.employee_name}\n");
            }
            //Console.WriteLine(html);
        }
    }
}
