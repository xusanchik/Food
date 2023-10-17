using Food.Models;

namespace Food.Dto_s;

public class UserDto
{
    public string? Name { get; set; }
    public string? Password { get; set; }
    public Registration? Registration { get; set; }
    public Menu? menu { get; set; }
}
