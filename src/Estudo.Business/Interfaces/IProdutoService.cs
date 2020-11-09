using AppMvcBasica.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Insert(Produto produto);
        Task Update(Produto produto);
        Task Delete(Guid id);
    }
}
