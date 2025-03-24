using System.ComponentModel.DataAnnotations; // Permet de pointer sur sql le type de données et de lui passer des conditions
using System.ComponentModel.DataAnnotations.Schema;

namespace MonApplication.Models
{
    public class Utilisateur
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // On commence à 1 et on incrémente de 1
        public int IdUtilisateur { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire.")] // Rend le champ obligatoire.
        [StringLength(50, ErrorMessage = "Le nom ne peut pas dépasser 50 caractères.")]
        public required string Nom { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire.")]
        [StringLength(50, ErrorMessage = "Le prénom ne peut pas dépasser 50 caractères.")]
        public required string Prenom { get; set; }

        [Required(ErrorMessage = "L'email est obligatoire.")]
        [EmailAddress(ErrorMessage = "L'email n'est pas valide.")] // Vérifie si l'email est bon. 
        public required string Email { get; set; }


        [Required(ErrorMessage = "Le login est obligatoire.")]
        [MinLength(6, ErrorMessage ="Le login doit contenir au moins 6 caractères")]
        public required string Login {get; set;}


        [Required(ErrorMessage = "Le mot de passe est obligatoire.")]
        [MinLength(8, ErrorMessage = "Le mot de passe doit contenir au moins 8 caractères.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", 
            ErrorMessage = "Le mot de passe doit contenir au moins une lettre, un chiffre et un caractère spécial.")]
        public required string MotDePasse { get; set; }

        [Required(ErrorMessage = "L'adresse est obligatoire.")]
        [StringLength(255, ErrorMessage = "L'adresse ne peut pas dépasser 255 caractères.")]
        public required string Adresse { get; set; }

        [Required(ErrorMessage = "Le rôle est obligatoire.")]
        [ForeignKey("Role")]
        public int IdRole { get; set; }

        [Required(ErrorMessage = "La localité est obligatoire.")]
        [ForeignKey("Localite")]
        public int IdLocalite { get; set; }
    }
}

