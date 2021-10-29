using Microsoft.EntityFrameworkCore;
using Model.Cards;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FieldService
    {
        private readonly GameTableContext _context;

        public Task<List<Field>> GetAll()
        {
            return _context.Fields.ToListAsync();
        }

        public Task<Field> GetById(int? id)
        {
            return _context.Fields.FirstOrDefaultAsync(field => field.Id == id);
        }
    }
}
