using System;
using System.Threading.Tasks;

namespace DesafioVitreo.Domain.Interface
{
    public interface ICharactersService
    {
        Task<String> ListCharacters(string apiKey_hash);
        Task<String> GetCharacterById(int idCharacter, string apiKey_hash);
    }
}
