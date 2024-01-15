namespace ElectroniqueApi.Model
{
    public class Facture
    {
        public int Id { get; set; } 
        public Client Client { get; set; }
        public byte ClientId { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
       
        
    }
}
