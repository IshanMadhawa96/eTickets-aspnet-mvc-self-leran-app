﻿using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorServices : IActorsServicecs
    {
        private readonly AppDbContext _context;
        public ActorServices(AppDbContext context)
        {
            _context=context;
        }
        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var result =await _context.Actors.ToListAsync();
            return result;
        }

        public Actor GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new System.NotImplementedException();
        }
    }
}