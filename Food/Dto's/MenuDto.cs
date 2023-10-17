using Food.Models;

namespace Food.Dto_s
{
    public class MenuDto
    {
        public List<Foods>? foods { get; set; }
        public Profile? profil { get; set; }
        public Functions? functions { get; set; }
    }
}
