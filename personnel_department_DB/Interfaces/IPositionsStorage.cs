using Microsoft.EntityFrameworkCore;
using personnel_department_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnel_department_DB.Interfaces
{
    public interface IPositionsStorage
    {
        public List<Position> GetAll();
        public void Add(Position position);
        public void Edit(Position position);
        public void Delete(Guid id);
        public Position GetById(Guid id);
    }
}
