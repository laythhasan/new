using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnicityApp.Entites
{
    public class IdeaColctive
    {

        [Key]
        public int IdeaColctiveID { get; set; }

        [Required]
        public string ideaname { get; set; }

        [Required]
        public string descreption { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string GroupName { get; set; }

        public string phoneno { get; set; }

        public string Fileidea { get; set; }
    }
}
