using Microsoft.EntityFrameworkCore;
using ShiftTeam.Api.Models;

namespace ShiftTeam.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Instruction> Instructions => Set<Instruction>();
    public DbSet<InstructionStep> InstructionSteps => Set<InstructionStep>();
}