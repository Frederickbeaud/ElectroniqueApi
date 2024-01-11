namespace ElectroniqueApi.Model
{
    public class LigneFacture
    {
        public int Id { get; set; }
        public Produit Produit { get; set; }
        public int ProduitId { get; set; }
        public int quantité { get; set; }
        public int FactureId { get; set; }
        public Facture Facture { get; set;}
    }
}
