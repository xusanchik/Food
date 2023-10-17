using System.Runtime;

namespace Food.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public List<Foods> ?foods { get; set; }
        public Profile? profil  { get; set; }
        public Functions ? functions { get; set; }
    }
}
