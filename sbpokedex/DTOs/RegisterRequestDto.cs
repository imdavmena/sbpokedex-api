﻿using System.ComponentModel.DataAnnotations;
namespace sbpokedex.DTOs
{
	public class RegisterReques
	{
		[Required]
		public string? UserName { get; set; }

		[Required]
		public string? Email { get; set; }

		[Required]
		public string? Password { get; set; }
	}
}

