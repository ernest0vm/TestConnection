using System;
using System.Collections.Generic;

namespace TestConnection.Models
{
    public partial class Users
    {
        public int IdUser { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
    }
}
