using CycleCount.Services;
using Microsoft.AspNetCore.Mvc;

namespace CycleCount.Controllers;

[ApiController]
public class CountCompletedController : ControllerBase
{
    private readonly CycleCountService _service;

    public CountCompletedController(CycleCountService service)
    {
        _service = service;
    }

    [HttpGet("CountCompleted")]
    public async Task<ActionResult<bool>> Get(long storeSid)
    {
        bool result = await _service.HasCountBeenCompletedToday(storeSid);
        return Ok(result);
    }
}