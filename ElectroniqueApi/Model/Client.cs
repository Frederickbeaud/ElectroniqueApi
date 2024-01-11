namespace ElectroniqueApi.Model
{
    public class Client
    {
        public int Id {  get; set; }   
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public List<Facture> Factures { get; set; } = new List<Facture>();
       
    }
}
