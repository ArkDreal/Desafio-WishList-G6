using System;
using System.Collections.Generic;

#nullable disable

namespace WishList.webApi.Domains
{
    public partial class Desejo
    {
        public byte IdDesejo { get; set; }
        public byte? IdUsuario { get; set; }
        public string Descricao { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
