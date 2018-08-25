using Globoma.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Globoma.ViewComponents
{
    public class StatisticsViewComponent : ViewComponent
    {
        private readonly IConferenceService service;

        public StatisticsViewComponent(IConferenceService service)
        {
            this.service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync(string statsCaption)
        {
            ViewBag.Caption = statsCaption;
            return View(await service.GetStatistics());
        }
    }
}
