using System.ComponentModel.DataAnnotations;

namespace sbpokedex.DTOs
{
	public class LoginRequest
	{
		[Required]
		public string? Username { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}

