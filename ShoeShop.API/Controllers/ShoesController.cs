using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoeShop.Application.Features.Shoe.Requests.Queries;

namespace ShoeShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoesController : ControllerBase
    {
        //private readonly IMediator _mediator;

        //public ShoesController(IMediator mediator)
        //{
        //    _mediator = mediator;
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetAllShoe()
        //{
        //    var response = await _mediator.Send(new GetProductListRequest());
        //    return Ok(response);
        //}
    }
}
