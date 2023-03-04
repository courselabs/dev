using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorldWeb.Pages;

public class IndexModel : PageModel
{
    public string EnvironmentName {get; set;}
    public string FooterColor {get; set;}

    private readonly IConfiguration _config;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(IConfiguration config, ILogger<IndexModel> logger)
    {
        _config = config;
        _logger = logger;
    }

    public void OnGet()
    {
        var envName = _config["EnvironmentName"];
        if (string.IsNullOrEmpty(envName))
        {
            EnvironmentName = "PROD";
        }
        else
        {
            EnvironmentName = envName.ToUpper();
            FooterColor = EnvironmentName == "STAGING" ? "BlueViolet" : "Coral";
        }
    }
}
