using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models_
{
    namespace WebApplication.Models
    {
        [Table("Employee")]
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Nationality { get; set; }
            public string State { get; set; }
        }
    }

}
