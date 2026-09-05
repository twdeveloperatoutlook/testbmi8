using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebBMI.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public float BmiResult = 0;
    public string HealthDescription { get; private set; } = string.Empty;

    [BindProperty]
    public int fieldHeight { get; set; }
    [BindProperty]
    public int fieldWeight { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        HealthDescription = string.Empty;
    }

    public void OnPostCalculate()
    {
        HealthMgr.BmiCalculator bc = new HealthMgr.BmiCalculator();

        bc.Height = fieldHeight;
        bc.Weight = fieldWeight;

        BmiResult = bc.Calculate();
        HealthDescription = bc.GetHealthDescription();
    }
}
