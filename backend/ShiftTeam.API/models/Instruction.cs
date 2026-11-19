namespace ShiftTeam.Api.Models;

public class Instruction
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string CarModel { get; set; } = string.Empty;

    public string Model3dUrl { get; set; } = string.Empty;

    public List<InstructionStep> Steps { get; set; } = new();
}