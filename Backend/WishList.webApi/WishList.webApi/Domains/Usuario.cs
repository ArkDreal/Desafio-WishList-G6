using System;
using System.Collections.Generic;

#nullable disable

namespace WishList.webApi.Domains
{
    public partial class Usuario
    {
        public byte IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
