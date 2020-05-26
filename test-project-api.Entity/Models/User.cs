using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_project_api.Entity.models
{
    [Table("users", Schema = "public")]
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("created")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime created { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }
    }
}