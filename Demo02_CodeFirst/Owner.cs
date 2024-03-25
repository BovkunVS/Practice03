using System.ComponentModel.DataAnnotations;

namespace Demo02_CodeFirst
{
    public partial class Owner
    {
        [Key]
        public int id_owner { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public int id_home_address { get; set; }
        public string telephone { get; set; }
    }
}
