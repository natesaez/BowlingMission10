using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BowlingMission10.data;

public class Bowler
{
    [Key]
    public int BowlerId { get; set; }
    [Required]
    public string BowlerFirstName { get; set; }
    public string? BowlerMiddleInit { get; set; }
    [Required]
    public string BowlerLastName { get; set; }
    [Required]
    public int TeamID { get; set; }
    [Required]
    public string BowlerAddress { get; set; }
    [Required]
    public string BowlerCity { get; set; }
    [Required]
    public string BowlerState { get; set; }
    [Required]
    public int BowlerZip { get; set; }
    [Required]
    public string BowlerPhoneNumber { get; set; }
    [ForeignKey("TeamId")]
    public Team? Team { get; set; }
    

}