using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WishList.webApi.Domains;

namespace WishList.webApi.Interfaces
{
    interface IDesejoRepository
    {
        List<Desejo> Listar();

        void Cadastrar(Desejo novoDesejo);
    }
}
