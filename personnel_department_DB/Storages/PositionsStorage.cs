using Microsoft.EntityFrameworkCore;
using personnel_department_DB.Interfaces;
using personnel_department_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Storages
{
    public class PositionsStorage:IPositionsStorage
    {
        private DatabaseContext dbContext;

        public PositionsStorage(DatabaseContext dbContext)
        { 
            this.dbContext = dbContext;
        }
        public List<Position> GetAll()
        {
            return dbContext.Positions.Include(position => position.Employees).ToList();
        }
    }
}
