namespace Food.Models;  
public class Payment

{
    public int Id { get; set; }
    public int CardNumber { get; set; }
    public string Type { get; set; } = string.Empty;

    public string Cvv { get; set; } = string.Empty; 
    public string TableNumber { get; set; } = string.Empty;

}
