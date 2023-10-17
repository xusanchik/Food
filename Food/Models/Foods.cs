namespace Food.Models;
public class Foods
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal TotilCount { get; set; }
    public string Imgurl { get; set; } = string.Empty;
}
