using CharacterManager.APP.DTOs;
using CharacterManager.APP.Mappers.TestMappers;
using CharacterManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CharacterManager.APP.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;
        private readonly TestToTestDTOMapper _testToTestDTOMapper;
        private readonly TestDTOToTestMapper _testDTOToTestMapper;

        public TestController(ITestService testService, TestToTestDTOMapper testToTestDTOMapper,
                              TestDTOToTestMapper testDTOToTestMapper)
        {
            _testService = testService;
            _testToTestDTOMapper = testToTestDTOMapper;
            _testDTOToTestMapper = testDTOToTestMapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_testToTestDTOMapper.Map(await _testService.GetAllAsync()));
        }

        [HttpPost]
        public async Task<IActionResult> PostOne([FromBody] TestDTO testDTO)
        {
            return Created("api/v1/test", await _testService.AddAsync(_testDTOToTestMapper.Map(testDTO)));
        }
    }
}
