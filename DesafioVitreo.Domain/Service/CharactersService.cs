using DesafioVitreo.Domain.Interface;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesafioVitreo.Domain.Service
{
    public class CharactersService : ICharactersService
    {
        public async Task<String> ListCharacters(string apiKey_hash)
        {

            string resultString = null;

            try
            {
                using (var client = new HttpClient())
                {

                    string uri = "http://gateway.marvel.com/v1/public/characters?" + apiKey_hash;

                    HttpResponseMessage retorno = await client.GetAsync(uri);

                    resultString = await retorno.Content.ReadAsStringAsync();

                }

                return resultString;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<String> GetCharacterById(int idCharacter, string apiKey_hash)
        {

            string resultString = null;

            try
            {
                using (var client = new HttpClient())
                {

                    string uri = "http://gateway.marvel.com/v1/public/characters/" + idCharacter + "?" + apiKey_hash;

                    HttpResponseMessage retorno = await client.GetAsync(uri);

                    resultString = await retorno.Content.ReadAsStringAsync();

                }

                return resultString;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
