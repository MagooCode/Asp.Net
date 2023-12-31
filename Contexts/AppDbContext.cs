﻿using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.Contexts;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	public DbSet<Slider> Sliders { get; set; } = null!;
	public DbSet<Perk> Perks { get; set; } = null!;
}
