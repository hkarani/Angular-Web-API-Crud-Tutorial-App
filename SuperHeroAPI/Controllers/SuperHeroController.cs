﻿using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Controllers
{
	[Route("/api/[controller]")]
	[ApiController]

	public class SuperHeroController : Controller
	{
		[HttpGet]
		public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
		{
			return new List<SuperHero>
			{
				new SuperHero
				{
					Name= "SpiderMan",
					FirstName = "Peter",
					LastName = "Parker",
					Place = "New York City"
				}
			};
		}
	}
}
