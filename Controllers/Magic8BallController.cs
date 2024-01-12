using Microsoft.AspNetCore.Mvc;
using YounathanAMiniChallengeEightToTen_Endpoints.Services.Magic8Ball;

namespace YounathanAMiniChallengeEightToTen_Endpoints.Controllers;

    [ApiController]
    [Route("[controller]")]

    public class Magic8BallController : ControllerBase
    {
        private readonly IMagic8BallService _Magic8BallService;
        public Magic8BallController(IMagic8BallService ballin)
        {
            _Magic8BallService = ballin;
        }

        [HttpGet]
        [Route("Ballin/{question}")]
        public string MagicBalling(string question)
        {
            return _Magic8BallService.MagicBalling(question);
        }
    }
