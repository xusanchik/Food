using System.ComponentModel.Design;

namespace Food.Models;
public class User
{
    public int Id {  get; set; }
    public string? Name { get; set; }
    public string? Password { get; set; }
    public Registration? Registration { get; set; }
    public Menu? menu { get; set; }
}
