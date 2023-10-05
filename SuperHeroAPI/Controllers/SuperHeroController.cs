﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Models;
using SuperHeroAPI.Models.Data;

namespace SuperHeroAPI.Controllers
{
	[Route("/api/[controller]")]
	[ApiController]
	public class SuperHeroController : ControllerBase
	{
		private readonly DataContext _context;

		public SuperHeroController(DataContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<List<SuperHero>>> GetSuperHeroes()
		{
			return Ok(await _context.SuperHeroes.ToListAsync());
		}

		[HttpPost]
		public async Task<ActionResult<List<SuperHero>>> CreateSuperHero(SuperHero hero)
		{
			_context.SuperHeroes.Add(hero);
			await _context.SaveChangesAsync();
			return Ok(await _context.SuperHeroes.ToListAsync());
		}

	}
}	
