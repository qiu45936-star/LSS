using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        // 模擬使用者登入的模型
        public class LoginRequest
        {
            public string Name { get; set; } = string.Empty;
        }


        // POST: api/login/postname
        [HttpPost("postname")]
        public IActionResult PostName([FromBody] LoginRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                return BadRequest(new { Message = "請輸入姓名" });
            }

            return Ok(new { Message = $"登入成功，歡迎 {request.Name}！" });
        }

        // GET: api/login/hello?name=Tom
        [HttpGet("hello")]
        public IActionResult Hello([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest(new { Message = "請輸入姓名" });
            }

            return Ok(new { Message = $"Hello, {name}!" });
        }
    }
}

    
