using BusinessLayer.Interfaces;
using CommonLayer.EmployeeModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Employee_payroll_Dapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        IEmpBL EmpBL;

        public EmployeeController(IEmpBL empBL)
        {
            EmpBL = empBL;
        }

        [HttpPost]
        public IActionResult AddEmployee(EmpPostModel empPostModel)
        {
            try
            {
                var result= EmpBL.AddEmployee(empPostModel);
                if(result==0)
                {
                    return this.BadRequest(new { sucess = false, Message = "Something went wrong while adding Employee!!" });
                }
                return this.Ok(new { sucess = true, Message = "Employee Added Sucessfully..." });
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]
        public IActionResult getAllEmp()
        {
            try
            {
                List<EmpGetModel> empList = new List<EmpGetModel>();
                var EmpList = EmpBL.GetAllEmp();
                return Ok(new { sucess = true, Message = "Employee's data fetched Successfully...", data = EmpList });
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
        }

        [HttpPut]
        public IActionResult UpdateEmployee(int EmpId,EmpPostModel empPostModel)
        {
            try
            {
                var result = EmpBL.UpdateEmployee(EmpId,empPostModel);
                if (result == 0)
                {
                    return this.BadRequest(new { sucess = false, Message = "Something went wrong while Updating Employee Details!!" });
                }
                return this.Ok(new { sucess = true, Message = "Employee details Updated Sucessfully..." });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
