using CommonLayer.EmployeeModels;
using Dapper;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Services
{
    public class EmpRL : IEmpRL
    {
        private readonly string connetionString;
        public EmpRL(IConfiguration configuration)
        {
            connetionString = configuration.GetConnectionString("Emp_payroll");
        }

        public int AddEmployee(EmpPostModel empPostModel)
        {
            SqlConnection sqlConnection = new SqlConnection(connetionString);
            try
            {
                using (sqlConnection)
                {
                    sqlConnection.Open();
                    var sql = "insert into Employee(Firstname,Lastname,Address,MobileNo) values(@Firstname,@Lastname,@Address,@MobileNo)";
                    var result = sqlConnection.Execute(sql,empPostModel);
                    return result;  
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public List<EmpGetModel> GetAllEmp()
        {
            List<EmpGetModel> listOfUsers = new List<EmpGetModel>();
            SqlConnection sqlConnection = new SqlConnection(connetionString);
            try
            {
                using (sqlConnection)
                {
                    sqlConnection.Open();
                    var sql = "select * from Employee";
                    var result = sqlConnection.Query<EmpGetModel>(sql);
                    return result.ToList();
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
