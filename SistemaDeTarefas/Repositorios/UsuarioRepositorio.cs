using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        Task<UsuarioModel> IUsuarioRepositorio.Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUsuarioRepositorio.Apagar(int id)
        {
            throw new NotImplementedException();
        }

        Task<UsuarioModel> IUsuarioRepositorio.Atualizar(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }

        Task<UsuarioModel> IUsuarioRepositorio.BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<UsuarioModel>> IUsuarioRepositorio.BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
