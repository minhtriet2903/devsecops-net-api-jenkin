using WebApplication1.Models;

namespace TestProject1.MockData
{
    public class EmployeeMockData
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>{
                 new Employee
                    {
                        Name = "Md. Mahedee Hasan",
                        Designation = "Head of Software Development",
                        FathersName = "Yeasin Bhuiyan",
                        MothersName = "Moriom Begum",
                        DateOfBirth = new DateTime(1984, 12, 19, 00, 00, 00)
                    },

                    new Employee
                    {
                        Name = "Khaleda Islam",
                        Designation = "Software Engineer",
                        FathersName = "Shahidul Islam",
                        MothersName = "Momtaz Begum",
                        DateOfBirth = new DateTime(1990, 10, 29, 00, 00, 00)
                    },

                    new Employee
                    {
                        Name = "Tahiya Hasan Arisha",
                        Designation = "Jr. Software Engineer",
                        FathersName = "Md. Mahedee Hasan",
                        MothersName = "Khaleda Islam",
                        DateOfBirth = new DateTime(2017, 09, 17, 00, 00, 00)
                    },

                    new Employee
                    {
                        Name = "Humaira Hasan",
                        Designation = "Jr. Software Engineer",
                        FathersName = "Md. Mahedee Hasan",
                        MothersName = "Khaleda Islam",
                        DateOfBirth = new DateTime(2021, 03, 17, 00, 00, 00)
                    }
            };
        }

        public static List<Employee> GetEmptyEmployees()
        {
            return new List<Employee>();
        }

        public static Employee NewEmployee()
        {
            return new Employee
            {
                Name = "Md. Mahedee Hasan",
                Designation = "Head of Software Development",
                FathersName = "Yeasin Bhuiyan",
                MothersName = "Moriom Begum",
                DateOfBirth = new DateTime(1984, 12, 19, 00, 00, 00)
            };
        }
    }
}
