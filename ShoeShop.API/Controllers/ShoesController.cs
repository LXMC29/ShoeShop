using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoeShop.Application.DTOs.Shoe;
using ShoeShop.Application.Features.Shoe.Requests.Commands;
using ShoeShop.Application.Features.Shoe.Requests.Queries;

namespace ShoeShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrator")]
    public class ShoesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShoesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [AllowAnonymous] // khong dang nhap van lay duoc
        public async Task<IActionResult> GetAllShoe()
        {
            var response = await _mediator.Send(new GetProductListRequest());
            return Ok(response);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetShoeById(Guid id)
        {
            var response = await _mediator.Send(new GetProductDetailRequest(id));
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateShoe(CreateShoeDto createShoeDto)
        {
            var response = await _mediator.Send(new CreateShoeRequest() { CreateShoe = createShoeDto });
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateShoe(UpdateShoeDto updateShoeDto)
        {
            await _mediator.Send(new UpdateShoeRequest() { Id = updateShoeDto.Id, UpdateShoe = updateShoeDto });
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteShoe(Guid id)
        {
            await _mediator.Send(new DeleteShoeRequest() { Id = id });
            return Ok();
        }
    }
}
