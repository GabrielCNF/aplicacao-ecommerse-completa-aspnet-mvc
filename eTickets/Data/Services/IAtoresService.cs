using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IAtoresService
    {
        Task<IEnumerable<Ator>> GetAll();

        Ator GetById(int id);
        void Add(Ator ator);
        Ator Update(int id, Ator newAtor);
        void Delete(int id);
    }
}
