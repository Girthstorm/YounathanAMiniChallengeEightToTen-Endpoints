using Microsoft.AspNetCore.Mvc;
using YounathanAMiniChallengeEightToTen_Endpoints.Services.RestaurantPicker;

namespace YounathanAMiniChallengeEightToTen_Endpoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly IRestaurantPickerService _RestaurantPickerService;
        public RestaurantPickerController(IRestaurantPickerService picking)
        {
            _RestaurantPickerService = picking;
        }

        [HttpGet]
        [Route("Mexican")]
        public string RestaurantMex()
        {
            return _RestaurantPickerService.RestaurantMex();
        }

        [HttpGet]
        [Route("FastFood")]
        public string RestaurantFast()
        {
            return _RestaurantPickerService.RestaurantFast();
        }

        [HttpGet]
        [Route("Sushi")]
        public string RestaurantSushi()
        {
            return _RestaurantPickerService.RestaurantSushi();
        }

    }
