using FluentValidation;
using FluentValidationsSample.Models;
using FluentValidationsSample.Validators;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationsSample.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomertController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(CreateCustomerModel customer) {
           
            return Ok();
        }
    }
}