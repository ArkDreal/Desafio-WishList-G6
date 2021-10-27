using System;
using System.Collections.Generic;

#nullable disable

namespace WishList.webApi.Domains
{
    public partial class Desejo
    {
        public byte IdDesejo { get; set; }
        public string Descricao { get; set; }
        public object IdUsuarioNavigation { get; internal set; }
    }
}
