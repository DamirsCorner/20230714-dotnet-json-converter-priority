using JsonConverterAttributePriority.Models;
using Microsoft.AspNetCore.Mvc;

namespace JsonConverterAttributePriority.Controllers;
[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    private readonly ILogger<SampleController> _logger;

    public SampleController(ILogger<SampleController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetSample")]
    public SampleObject Get()
    {
        return new SampleObject
        {
            NameValue = NameEnum.ValueA,
            MemberValue = MemberEnum.ValueTwo,
        };
    }
}
