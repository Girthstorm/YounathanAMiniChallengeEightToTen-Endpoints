
using Microsoft.AspNetCore.Mvc;
using YounathanAMiniChallengeEightToTen_Endpoints.Services.GuessIt;

namespace YounathanAMiniChallengeEightToTen_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]

    public class GuessItController : ControllerBase
    {
        private readonly IGuessItService _GuessItService;
        public GuessItController(IGuessItService guessing)
        {
            _GuessItService = guessing;
        }

        [HttpGet]
        [Route("GuessEasy/{num1}")]
        public string GuessEz(string num1) 
        {
            return _GuessItService.GuessEz(num1);
        }

        [HttpGet]
        [Route("GuessMedium/{num1}")]
        public string GuessMed(string num1)
        {
            return _GuessItService.GuessMed(num1);
        }

        [HttpGet]
        [Route("GuessHard/{num1}")]
        public string GuessHard(string num1)
        {
            return _GuessItService.GuessHard(num1);
        }

    }
