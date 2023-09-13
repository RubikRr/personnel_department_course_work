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

        public void Add(Position position)
        {
            dbContext.Positions.Add(position);
            dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var position=GetById(id);
            dbContext.Positions.Remove(position);
            dbContext.SaveChanges();
        }

        public void Edit(Position position)
        {
            var existingPosition = GetById(position.Id);
            existingPosition.Name = position.Name;
            dbContext.SaveChanges();
        }

        public Position GetById(Guid id)
        {
            return dbContext.Positions.FirstOrDefault(position => position.Id == id);
        }
        public Position GetByName(string name)
        {
            return dbContext.Positions.FirstOrDefault(position => position.Name==name);
        }

    }
}
