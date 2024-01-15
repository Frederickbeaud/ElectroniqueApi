using ElectroniqueApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ElectroniqueApi.Services
{
    public class FactureLigneService : IFactureLigneService<LigneFacture>
    {
        private readonly AppDbContext context;
        public FactureLigneService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<LigneFacture> Add(LigneFacture t)
        {
            var result = await context.LignesFactures.AddAsync(t);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<LigneFacture> Delete(int Id)
        {
            var p = await this.context.LignesFactures.FirstOrDefaultAsync(e => e.Id == Id);
            if (p != null)
            {
                context.LignesFactures.Remove(p);
                await context.SaveChangesAsync();
                return p;
            }
            return null;
        }

        public async Task<LigneFacture> Get(int Id)
        {
            return await context.LignesFactures.FirstOrDefaultAsync(e => e.Id == Id);
        }

        public async Task<IEnumerable<LigneFacture>> GetAll()
        {
            return await context.LignesFactures.ToListAsync();
        }

        public async Task<LigneFacture> Update(LigneFacture t)
        {
            var p = await this.context.LignesFactures.FirstOrDefaultAsync(
             e => e.Id == t.Id);
            if (p != null)
            {

                p.Facture = t.Facture;
                p.Facture = t.Facture;
                p.Produit = t.Produit;
                p.ProduitId = t.ProduitId;
                p.quantité = t.quantité;





                await context.SaveChangesAsync();
                return p;
            }
            return null;
        }
    }
}
