using ElectroniqueApi.Model;

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
            throw new NotImplementedException();
        }

        public async Task<LigneFacture> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<LigneFacture> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<LigneFacture>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<LigneFacture> Update(LigneFacture t)
        {
            throw new NotImplementedException();
        }
    }
}
