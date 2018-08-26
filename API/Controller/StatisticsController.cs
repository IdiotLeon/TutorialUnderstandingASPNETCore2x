using API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace API.Controller
{
    [Route("v1/[controller]")]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRepo repo;

        public StatisticsController(IStatisticsRepo repo)
        {
            this.repo = repo;
        }
        public StatisticsModel Get()
        {
            return repo.GetStatistics();
        }
    }
}
