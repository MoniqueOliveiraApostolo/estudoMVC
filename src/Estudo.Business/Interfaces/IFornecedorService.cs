using AppMvcBasica.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Business.Interfaces
{
    public interface IFornecedorService : IDisposable
    {
        Task Insert(Fornecedor fornecedor);
        Task Update(Fornecedor fornecedor);
        Task Delete(Guid id);
        Task UpdateEndereco(Endereco endereco);
    }
}
