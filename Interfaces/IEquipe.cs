using System.Collections.Generic;
using Aula37E_Players___Parte_1___Models.Models;

namespace Aula37E_Players___Parte_1___Models.Interfaces
{
    public interface IEquipe
    {
        //metodo do CRUD 
        //Create (Criar)
        //Read(Ler)
        //Update(Alterar)
        //Delet(Excluir)

        void Create(Equipe e );        
        List<Equipe> ReadAll();        
        void Update(Equipe e);        
        void Delet(int id);
    }
}