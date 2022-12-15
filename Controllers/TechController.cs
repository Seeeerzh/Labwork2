using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/technic")]
public class TechController : ControllerBase
{
   
    private readonly TechService _techService;
    private readonly ILogger<TechController> _logger;

    public TechController(
        ILogger<TechController> logger, TechService techService)
    {
        _logger = logger;
        _techService = techService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Technic>>> GetTechnic()
    {
        var technic = await _techService.GetTechnic();
        return Ok(technic);
    }
    
    
    [HttpPost]
    public async Task<ActionResult<object>> CreateProduct(Techniccompany techniccompany)
    {
        var technic = await _techService.Create(techniccompany);
        return Ok(technic);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<object>> GetTechnicID (int id)
    {
        var technic = await _techService.GetTechnicID(id); 
        return Ok(technic);
    }


    [HttpPut("{id}")]
    public async Task<ActionResult<object>> UpdateProduct(int id, [FromBody]Technic technic)
    {
        var technics = await _techService.EditData(id, technic);
        return Ok(technics);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<object>> DeleteProduct(int id)
    {
        
        var technic = await _techService.Delete(id); 
        return Ok(technic);
    }


    private ObjectResult Created(object value)
    {
        return StatusCode(201, value);
    }
}
