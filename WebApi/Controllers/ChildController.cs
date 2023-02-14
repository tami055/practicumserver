using Microsoft.AspNetCore.Mvc;
using Project2.Common.DTOS;
using Project2.Services.Interface;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IDataService<DTOSChild> _childService;

        public ChildController(IDataService<DTOSChild> childService)
        {
            _childService = childService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<List<DTOSChild>> Get()
        {
            return await _childService.GetAllAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<DTOSChild> Get(int id)
        {
            return await _childService.GetByIdAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<DTOSChild> Post([FromBody] ChildModel postmodel)
        {
            DTOSChild dTOSChild=new DTOSChild();
            dTOSChild.BirthDate = postmodel.BirthDate;
            //dTOSChild.Id = postmodel.Id;
            dTOSChild.Name = postmodel.Name;
            dTOSChild.ChildTz = postmodel.ChildTz;
            dTOSChild.ParentId = postmodel.ParentId;
            return await _childService.AddAsync(dTOSChild);

        }

       

       
    }
}
