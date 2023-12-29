using Laboratory_Standard.Database.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_9.Database.Entities
{
    [Table("account")]
    public class AccountDb
    {
        [Key]
        [Column("id")]
        public int Id { get; init; }
        [Required]
        [Column("login")]
        public string Login { get; set; } = null!;
        [Required]
        [Column("password")]
        public string Password { get; set; } = null!;

        [Column("role")]
        public Role Role { get; set; } = Role.USER;

    }
}
