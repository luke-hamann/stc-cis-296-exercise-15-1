using ClassSchedule.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassSchedule.Components
{
    public class DayFilter : ViewComponent
    {
        private IRepository<Day> days { get; set; }
        public DayFilter(IRepository<Day> rep) => days = rep;

        public IViewComponentResult Invoke()
        {
            var days = this.days.List(new QueryOptions<Day> { OrderBy = d => d.DayId });
            return View(days);
        }
    }
}
