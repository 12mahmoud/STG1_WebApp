namespace ST_WebApp.Models
{
    public class SampleData
    {
        public static List<Employee> Employees { get; } = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Mahmoud Sharnoby",
                Age = 21,
                Salary = 15000,
                Address = "menof",
                Email = "Sharnoby@gmail.com"
            },
            new Employee
            {
                Id = 2,
                Name = "Adham Diab",
                Age = 25,
                Salary = 5000,
                Address = "Giza",
                Email = "Adham22@gmsil.com"
            },
            new Employee
            {
                Id = 3,
                Name = "Mohamed Karim ",
                Age = 36,
                Salary = 2500,
                Address = "New Cairo",
                Email = "Mokarim@gmail.com"
            },
                        new Employee
            {
                Id = 4,
                Name = "Maria Ali",
                Age = 21,
                Salary = 7500,
                Address = "New cairo",
                Email = "MariaAli@yahoo.com"
            },




        };
    }
}
