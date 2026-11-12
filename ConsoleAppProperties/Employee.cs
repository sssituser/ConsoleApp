using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProperties
{
    internal class Employee
    {
      private  int _employeeId;
      private  string _employeeName;
      private  int _employeeSal;

      public int EmployeeId
        {

            get
            {
                return _employeeId;
            }
            set
            {
                _employeeId = value;
            }
        }
        public string EmployeeName
        {

            get
            {
                return _employeeName;
            }
            set
            {
                _employeeName = value;
            }
        }

        public int EmployeeSal
        {
            get
            {
                return _employeeSal;
            }
            set
            {
                _employeeSal = value;
            }
        }

    }
}
