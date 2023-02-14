using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Common.DTOS
{
    public class DTOSUser
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }
        public string tz { get; set; }
        public string min { get; set; }
        public string HMO { get; set; }
    }
}
