using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDAL.Models
{
    public class Customer
    {

        [Key]
        public int CustId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public string FullNameTest { get; set; } = "TestName";
        public string FullNameTest2  => "TestName2";

        [Timestamp]
        public byte[] Timestamp { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
