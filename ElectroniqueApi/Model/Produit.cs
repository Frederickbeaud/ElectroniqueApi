using System.ComponentModel.DataAnnotations;

namespace ElectroniqueApi.Model
{
    public class Produit
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Désignation { get; set; }
        [Required]
        [Display(Name = "Prix en dinar :")]
        public float Prix { get; set; }
        [Required]
        [Display(Name = "Quantité en unité :")]
        public int Quantite { get; set; }
        public int? LigneFactureId { get; set; }
        
        public string photo { get; set; }
        public byte CategorieId { get; set; }
        
        public Categorie? Categorie { get; set; }
    }
}
