using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net;
using TestProject1.MockData;
using WebApplication1.Controllers;
using WebApplication1.Interfaces;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly Mock<IEmployeeService> employeeService;
        public UnitTest1()
        {
            employeeService = new Mock<IEmployeeService>();
        }

        [Fact]
        public async Task GetEmployeeList_Success()
        {
            //arrange
            var employeeList = EmployeeMockData.GetEmployees();
            employeeService.Setup(x => x.SelectAllEmployees())
                .ReturnsAsync(employeeList);
            var employeeController = new EmployeesController(employeeService.Object);

            //act
            var employeeResult = (await employeeController.GetEmployees()).Result as ObjectResult;
            var actualtResult = employeeResult.Value;

            //assert
            Assert.NotNull(employeeResult);
            Assert.True(employeeList.Equals(actualtResult));
        }
    }
}