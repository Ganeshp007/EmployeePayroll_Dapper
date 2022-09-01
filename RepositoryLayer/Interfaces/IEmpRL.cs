using CommonLayer.EmployeeModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interfaces
{
    public interface IEmpRL
    {
        public int AddEmployee(EmpPostModel empPostModel);
        public List<EmpGetModel> GetAllEmp();
        public int UpdateEmployee(int EmpId, EmpPostModel empPostModel);

    }
}
