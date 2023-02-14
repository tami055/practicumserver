using Microsoft.AspNetCore.Mvc;
using Project2.Common.DTOS;
using Project2.Services.Interface;
using Project2.Services.Services;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IDataService<DTOSUser> _userService;

        public UserController(IDataService<DTOSUser> userService)
        {
            _userService = userService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<List<DTOSUser>> Get()
        {
            return await _userService.GetAllAsync();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task <DTOSUser> Get(int id)
        {
            return await _userService.GetByIdAsync(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<DTOSUser>> Post([FromBody] UserModel postmodel)
        {

                DTOSUser dTOSUser = new DTOSUser();
          //  dTOSUser.Id = postmodel.Id;
            dTOSUser.BirthDate = postmodel.BirthDate;
            dTOSUser.FName = postmodel.FName;
            dTOSUser.LName = postmodel.LName;
            dTOSUser.tz = postmodel.tz;
            dTOSUser.min = postmodel.min;
            dTOSUser.HMO = postmodel.HMO;

            return await _userService.AddAsync(dTOSUser);

        }

       

    }
}
