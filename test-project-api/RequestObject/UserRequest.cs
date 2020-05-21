using System.ComponentModel.DataAnnotations;

namespace test_project_api.RequestObject
{
    public class UserRequestDto
    {
       
        [Required]
        public string name { get; set; }
    }
}
