﻿using ElectroniqueApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ElectroniqueApi.Services
{
    public class FactureService : IFactureService<Facture>
    {
        private readonly AppDbContext context;

        public FactureService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Facture> Add(Facture t)
        {
            var result = await context.Factures.AddAsync(t);
             await  context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Facture> Delete(int Id)
        {
            var p = await this.context.Factures.FirstOrDefaultAsync(e => e.Id == Id);
            if (p != null)
            {
                context.Factures.Remove(p);
                await context.SaveChangesAsync();
                return p;
            }
            return null;
        }

        public async Task<Facture> Get(int Id)
        {
            return await this.context.Factures.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IEnumerable<Facture>> GetAll()
        {
            return await context.Factures.ToListAsync();
        }

        public async Task<Facture> Update(Facture t)
        {
            var p = await this.context.Factures.FirstOrDefaultAsync(
             e => e.Id == t.Id);
            if (p != null)
            {
              
                p.Client = t.Client;
               p.ClientId = t.ClientId;
                p.DateTime= t.DateTime;
                
                                



                await context.SaveChangesAsync();
                return p;
            }
            return null;
        }
    }
}
