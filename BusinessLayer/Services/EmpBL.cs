using BusinessLayer.Interfaces;
using CommonLayer.EmployeeModels;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public class EmpBL : IEmpBL
    {
        IEmpRL EmpRL;
        public EmpBL(IEmpRL EmpRL)
        {
            this.EmpRL = EmpRL;
        }

        public int AddEmployee(EmpPostModel empPostModel)
        {
            try
            {
                return EmpRL.AddEmployee(empPostModel);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<EmpGetModel> GetAllEmp()
        {
            try
            {
                return EmpRL.GetAllEmp();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int UpdateEmployee(int EmpId, EmpPostModel empPostModel)
        {
            try
            {
                return EmpRL.UpdateEmployee(EmpId,empPostModel);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteEmployee(int empId)
        {
            try
            {
                return EmpRL.DeleteEmployee(empId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
