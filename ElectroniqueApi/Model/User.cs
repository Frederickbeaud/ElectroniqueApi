namespace ElectroniqueApi.Model
{
    public class User
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Telephone { get; set; }
        private string Address { get; set; }
        private string City { get; set; }
        private string Email { get; set; } = string.Empty;
    }
}
