using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_project_api.Enitity.models
{
    [Table("users_role", Schema = "public")]
    public class UsersRole
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public User user { get; set; }

        [Required]
        [ForeignKey("Role")]
        public Role role { get; set; }
    }
}