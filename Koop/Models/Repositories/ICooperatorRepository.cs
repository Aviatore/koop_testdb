using System.Collections.Generic;

namespace Koop.Models.Repositories
{
    public interface ICooperatorRepository
    {
        IEnumerable<Cooperator> AllCooperators { get; }
        Cooperator GetCooperatorById(int id);
        IEnumerable<CoopOrderHistory> GetOrderHistoryById(int id);
    }
}