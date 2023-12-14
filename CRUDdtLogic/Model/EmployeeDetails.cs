using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDdtLogic.Model
{
    public class EmployeeDetails
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public string DoorNumber { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressType { get; set; }
    }
}
