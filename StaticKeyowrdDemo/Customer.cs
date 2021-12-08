using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyowrdDemo
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        private string MachineName = "";
        public Customer()
        {
            CommonTask commonTask = new CommonTask();
            MachineName = commonTask.GetComputerName();
        }
        //public bool IsEmpty(string value)
        //{
        //    if (value.Length > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public void Insert()
        {
            CommonTask commonTask = new CommonTask();
            if (!commonTask.IsEmpty(CustomerCode) && !commonTask.IsEmpty(CustomerName))
            {
                //Insert the data
            }
        }
    }
}
