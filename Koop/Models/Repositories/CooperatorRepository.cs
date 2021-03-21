using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Koop.Models.Repositories
{
    public class CooperatorRepository : ICooperatorRepository
    {
        private readonly koopTmpContext _koopTmpContext;

        public CooperatorRepository(koopTmpContext koopTmpContext)
        {
            _koopTmpContext = koopTmpContext;
        }

        public IEnumerable<Cooperator> AllCooperators => _koopTmpContext.Cooperators.ToList();
        public Cooperator GetCooperatorById(int id)
        {
            return AllCooperators.FirstOrDefault(p => p.CoopId == id);
        }

        public IEnumerable<CoopOrderHistory> GetOrderHistoryById(int id)
        {
            return _koopTmpContext.CoopOrderHistories.Where(p => p.CoopId == id).ToList();
        }
    }
}