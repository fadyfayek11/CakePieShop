using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakePieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _dbContext;

        public PieRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _dbContext.Pies.Include(p => p.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _dbContext.Pies.Include(p => p.Category).Where(p=>p.IsPieOfTheWeek);
            }
        }

        public Pie GetPieById(int pieId)
        {
            return _dbContext.Pies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
