using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishList.webApi.Contexts;
using WishList.webApi.Domains;
using WishList.webApi.Interfaces;

namespace WishList.webApi.Repositories
{
    
    public class DesejoRepository : IDesejoRepository
    {
        WishListContext ctx = new WishListContext();
        public void Cadastrar(Desejo novoDesejo)
        {
            ctx.Desejos.Add(novoDesejo);

            ctx.SaveChanges();
        }

        public List<Desejo> Listar()
        {
            return ctx.Desejos.Include(n => n.IdUsuarioNavigation).ToList();
        }
    }
}
