using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class AtoresService : IAtoresService
    {

        private readonly AppDbContext _context;

        public AtoresService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Ator ator)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<IEnumerable<Ator>> GetAll()
        {
            var result = await _context.Atores.ToListAsync();
            return result;

            throw new NotImplementedException();
        }
        public Ator GetById(int id)
        {
            throw new NotImplementedException();
        }
        public Ator Update(int id, Ator newAtor)
        {
            throw new NotImplementedException();
        }
    }
}
