using EmployeeRegistration.Data;
using EmployeeRegistration.Models.AppEntities;
using EmployeeRegistration.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeRegistration.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _dbContext;
        public EmployeeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            var qualifications = _dbContext.Qualifications
                .AsQueryable()
                .Select(x => new QualificationListViewModel { Id = x.Q_Id, Name = x.Q_Name }).ToList();

            ViewBag.Qualifications = qualifications;
            return View();
            
        }
        [HttpPost]
        public IActionResult Add(AddEmployeeViewModel viewModel)
        {
            //need to add format validation for DOB 
            if(viewModel is null)
            {
                //return error message
            }
            using (_dbContext)
            {
                var employee = new Employee()
                {
                    Emp_Name = viewModel.EmployeeName,
                    DateOfBirth = viewModel.DOB,
                    Gender = viewModel.Gender,
                    Salary = (decimal)viewModel.Salary
                };
                _dbContext.Employees.Add(employee);
                _dbContext.SaveChanges();

                var employeeQualification = new EmployeeQualification()
                {
                    Employee_Id = employee.EmployeeId,
                    Q_Id = viewModel.QualificationId,
                    Marks = viewModel.Marks
                };
                _dbContext.EmployeeQualifications.Add(employeeQualification);
            }
              
            return View();

        }
        [HttpGet]
        public JsonResult GetEmployees()
        {
            try
            {
                var employees = _dbContext.Employees.AsQueryable();
                var employeeList = new List<EmployeeListViewModel>();

                foreach (var employee in employees) 
                {
                    employeeList.Add(new EmployeeListViewModel
                    {
                        Employee_ID = employee.EmployeeId,
                        Name = employee.Emp_Name
                    });
                }
                return Json(new 
                {
                    success = true,
                    employees = employeeList,
                    message = "Employees listed successfully."
                });
            }
            catch (Exception e)
            {
                return Json(new
                {
                    success = false,
                    employees = "",
                    message = "Failed to get employees."
                });
                throw;
            }
        }
    }
}
