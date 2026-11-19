namespace ShiftTeam.Api.Models; 

public class InstructionStep
{
    public int Id { get; set; }

    public int StepNumber { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Image2dUrl { get; set; } = string.Empty;

    public int InstructionId { get; set; }
}