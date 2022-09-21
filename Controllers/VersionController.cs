using Microsoft.AspNetCore.Mvc;

namespace VersionProject.Controllers;

[Route("[controller]")]
public class VersionController : Controller
{
    private const string Version = "3";

    [HttpGet]
    public IActionResult GetVersionNumber()
    {
        return Ok(Version);
    }


}