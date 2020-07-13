using System.Collections.Generic;
using Aula37E_Players___Parte_1___Models.Models;

namespace Aula37E_Players___Parte_1___Models.Interfaces
{
    public interface INoticias
    {
        //metodo do CRUD 
        //Create (Criar)
        //Read(Ler)
        //Update(Alterar)
        //Delet(Excluir)

        void Create( Noticias n );
        List<Noticias> ReadAll();
        void Update( Noticias n );
        void Delet(int id);

    }
}