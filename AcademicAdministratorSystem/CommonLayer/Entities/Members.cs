using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Clase que sirve de Molde para manejar los miembros del sistema
namespace CommonLayer.Entities
{
    public class Members
    {
        public int MemberId { get; set; }
        public int RolId { get; set; }

        public string Names { get; set; }
        public string LastNames { get; set; }
        public string MemberUser { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }   
        public string Phone { get; set; }   
        public DateTime DateEntry { get; set; }   
    }
}
