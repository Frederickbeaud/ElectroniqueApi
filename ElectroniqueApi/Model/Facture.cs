namespace ElectroniqueApi.Model
{
    public class Facture
    {
        public int Id { get; set; } 
        public Client Client { get; set; }
        private DateTime DateTime { get; set; } = DateTime.Now;
        public int ClienId { get; set; }
        public List<LigneFacture> ligneFactures { get; set; } 
    }
}
