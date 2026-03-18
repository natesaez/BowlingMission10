using System.ComponentModel.DataAnnotations;

namespace BowlingMission10.data;

public class Team
{
    [Key]
    public int TeamId { get; set; }
    [Required]
    public string TeamName { get; set; } = "";
    [Required]
    public int CaptainId { get; set; }
}