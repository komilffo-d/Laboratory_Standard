using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Laboratory_Standard.Database.Enum;
using System.ComponentModel;

namespace Laboratory_Standard.Database.Entities
{
    [Table("expert")]
    public class ExpertDb
    {
        [Key]
        [Column("id")]
        public int Id { get; init; }


        [Required]
        [DisplayName("Фамилия")]
        [Column("last_name")]
        public string LastName { get; set; } = null!;


        [Required]
        [DisplayName("Имя")]
        [Column("first_name")]
        public string FirstName { get; set; } = null!;

        [DisplayName("Отчество")]
        [Column("middle_name")]
        public string MiddleName { get; set; } = null!;


        [Column("email")]
        public string? Email { get; set; } = null;


        [Column("phone")]
        public string? Phone { get; set; } = null;


        [Required]
        [Column("register_number")]
        public string RegisterNumber { get; set; } = null!;

        [Required]
        [Column("type_organisation")]
        public TypeOrganisation TypeOrganisation { get; set; } = TypeOrganisation.Main;

    }
}
