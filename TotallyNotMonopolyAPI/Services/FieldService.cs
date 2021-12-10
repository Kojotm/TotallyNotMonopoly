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
    public interface IFieldService
    {
        Task<List<Field>> GetAll();
        Task<Field> GetById(int id);
    }

    public class FieldService : IFieldService
    {
        private readonly GameTableContext context;

        public FieldService(GameTableContext context)
        {
            this.context = context;
        }

        public Task<List<Field>> GetAll()
        {
            return context.Fields.ToListAsync();
        }

        public Task<Field> GetById(int id)
        {
            return context.Fields.FirstOrDefaultAsync(field => field.Id == id);
        }
    }
}
