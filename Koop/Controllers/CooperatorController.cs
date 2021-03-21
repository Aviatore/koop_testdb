using Koop.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Koop.Controllers
{
    public class CooperatorController : Controller
    {
        private readonly ICooperatorRepository _cooperatorRepository;

        public CooperatorController(ICooperatorRepository cooperatorRepository)
        {
            _cooperatorRepository = cooperatorRepository;
        }
        // GET
        public IActionResult All()
        {
            return Ok(_cooperatorRepository.AllCooperators);
        }

        public IActionResult orderhistory(int id)
        {
            return Ok(_cooperatorRepository.GetOrderHistoryById(id));
        }
    }
}