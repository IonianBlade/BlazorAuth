using BlazorAuth.Shared;
using Microsoft.AspNetCore.Identity;

namespace BlazorAuth.Server.Models
{
	public class ApplicationUser : IdentityUser
	{
		public List<SuperHero> SuperHeroes { get; set; } = new List<SuperHero>();
	}
}