using ClassSchedule.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassSchedule.Components
{
    public class DayFilter : ViewComponent
    {
        private IRepository<Day> days { get; set; }
        public DayFilter(IRepository<Day> rep) => days = rep;
    }
}
