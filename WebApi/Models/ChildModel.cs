using Project2.Common.DTOS;

namespace WebApi.Models
{
    public class ChildModel
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string ChildTz { get; set; }
        public DateTime BirthDate { get; set; }
        public int ParentId { get; set; }

    }
}
