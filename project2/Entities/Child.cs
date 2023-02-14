using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.Entities
{
    public class Child
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChildTz { get; set; }
        public DateTime BirthDate { get; set; }
        public int ParentId { get; set; }
        
       
       
    }
}
