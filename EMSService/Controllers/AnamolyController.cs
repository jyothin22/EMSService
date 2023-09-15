using EMS.BAL.Services;
using EMSEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMSService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnamolyController : ControllerBase
    {
        private AnamolyService _AnamolyService;
        public AnamolyController(AnamolyService anamolyService)
        {
            _AnamolyService = anamolyService;
        }

        [HttpPost("AddAnamoly")]
        public IActionResult AddAnamoly(AnamolyModel anamoly)
        {
           string res= _AnamolyService.AddAnamoly(anamoly);
            //_logger.LogInformation("Seri Log is Working (Anamoly)");
            List<object> list = new List<object>();
            list.Add(res);
            return Ok(list);

        }

        [HttpGet("GetAnamolyById")]

        public AnamolyModel GetAnamolyById(int id)
        {
            return _AnamolyService.GetAnamolyById(id);

        }

        [HttpPut("UpdateAnamoly")]
        public IActionResult UpdateAnamoly(AnamolyModel anamoly)
        {

            _AnamolyService.UpdateAnamoly(anamoly);
            List<object> list = new List<object>();
            list.Add("Anamoly Updated");
            return Ok(list);
        }
        [HttpGet("GetAll")]
        public IEnumerable<AnamolyModel> GetAllAnamoly()
        {
            return _AnamolyService.GetAllAnamoly();
        }


            [HttpDelete("DeleteAnamolyById")]

            public IActionResult DeleteAnamoly(int id)
            {
                _AnamolyService.DeleteAnamoly(id);
                List<object> list = new List<object>();
                list.Add("Deleted the anamoly");
                return Ok(list);

            }
        }
    }
