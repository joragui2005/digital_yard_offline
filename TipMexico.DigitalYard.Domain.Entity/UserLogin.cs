using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipMexico.DigitalYard.Domain.Entity
{
    public  class UserLogin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Token { get; set; }
        public int Sitio { get; set; }
        public int IdRol { get; set; }
        public string Rol { get; set; }
        public string Status { get; set; }
    }
}
