using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestApi.V1.Domain;
using TestApi.V1.UseCase.Interfaces;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/v1/address")]
    public class AddressController : ControllerBase
    {

        private IAddressUseCase _addressUseCase;
        public AddressController(IAddressUseCase addressUseCase)
        {
            _addressUseCase = addressUseCase;
        }


        [HttpGet]
        [ProducesResponseType(typeof(AddressesApiDataResponse), StatusCodes.Status200OK)]
        public IActionResult GetAddresses([FromQuery] string postcode)
        {
            try
            {
                // pass the postcode to gateway through usecase
                // return list of addresses
                var response = _addressUseCase.ExecuteGetAddresses(postcode);
                return Ok(response);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


    }
}
