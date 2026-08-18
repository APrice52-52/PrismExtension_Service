//using CycleCount.Configuration;
//using CycleCount.Models;
//using CycleCount.Services;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;

//namespace CycleCount.Pages;

//[IgnoreAntiforgeryToken]
//public class CycleCountModel : PageModel
//{
//    private readonly CycleCountService _service;
//    private readonly CycleCountConfig  _config;

//    public CycleCountModel(CycleCountService service, CycleCountConfig config)
//    {
//        _service = service;
//        _config  = config;
//    }

//    [BindProperty]
//    public List<CycleCountItem> Items { get; set; } = new();

//    public string SuccessMessage { get; set; } = "";
//    public string ErrorMessage { get; set; } = "";

//    public async Task OnGetAsync([FromQuery] long? storeSid)
//    {
//        Items = await _service.GetRandomItems(storeSid ?? _config.DefaultStoreSid);
//    }

//    public async Task OnPostAsync()
//    {
//        // Check for today's cycle count FIRST
//        if (await _service.HasCountBeenCompletedToday(Items.First().StoreSid))
//        {
//            ErrorMessage = "A cycle count has already been completed for today.";
//            return;
//        }

//        // Only check if all quantities are 0
//        if (Items.All(i => i.CountedQty == 0))
//        {
//            //ErrorMessage = "Please enter a value in at least one of the boxes.";
//            return;
//        }

//        await _service.SaveCycleCount(Items);

//        Items.Clear();
//        SuccessMessage = "Cycle Count submitted successfully.";
//    }
//    public async Task<IActionResult> OnGetCountCompletedAsync(long storeSid)
//    {
//        var completed = await _service.HasCountBeenCompletedToday(storeSid);

//        return new JsonResult(completed);
//    }
//}

using CycleCount.Configuration;
using CycleCount.Models;
using CycleCount.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CycleCount.Pages;

[IgnoreAntiforgeryToken]
public class CycleCountModel : PageModel
{
    private readonly CycleCountService _service;
    private readonly CycleCountConfig _config;

    public CycleCountModel(CycleCountService service, CycleCountConfig config)
    {
        _service = service;
        _config = config;
    }

    [BindProperty]
    public List<CycleCountItem> Items { get; set; } = new();

    public string SuccessMessage { get; set; } = "";
    public string ErrorMessage { get; set; } = "";

    public async Task OnGetAsync([FromQuery] long? storeSid)
    {
        Items = await _service.GetRandomItems(storeSid ?? _config.DefaultStoreSid);
    }

    public async Task OnPostAsync()
    {
        if (await _service.HasCountBeenCompletedToday(Items.First().StoreSid))
        {
            ErrorMessage = "A cycle count has already been completed for today.";
            return;
        }

        if (Items.All(i => i.CountedQty == 0))
        {
            return;
        }

        await _service.SaveCycleCount(Items);

        Items.Clear();
        SuccessMessage = "Cycle Count submitted successfully.";
    }

    public async Task<IActionResult> OnGetCountCompletedAsync(long storeSid)
    {
        var completed = await _service.HasCountBeenCompletedToday(storeSid);

        return new JsonResult(completed);
    }
}