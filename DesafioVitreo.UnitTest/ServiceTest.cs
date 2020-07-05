using DesafioVitreo.Domain.Interface.Utils;
using DesafioVitreo.Domain.Service;
using DesafioVitreo.Domain.Utils;
using DesafioVitreo.Model;
using Moq;
using Newtonsoft.Json;
using Xunit;

namespace DesafioVitreo.UnitTest
{
    public class ServiceTest
    {
        [Fact]
        public void ValidateGeraHash()
        {
            string expectedResult = "ts=1&apikey=cdb7af1ef4a3c260a36fc5c2ee256748&hash=55a92ac6bc5a277824869d02a9c5ab53";

            Mock<IUtils> mock = new Mock<IUtils>();
            mock.Setup(x => x.GerarHash()).Returns(expectedResult);
            Utils verif = new Utils();

            var resultadoEsperado = mock.Object.GerarHash();
            var resultado = verif.GerarHash();

            Assert.Equal(resultado, resultadoEsperado);            
        }

        [Fact]
        public async void ValidateListCharactersAsync()
        {
            string paramHash = "ts=1&apikey=cdb7af1ef4a3c260a36fc5c2ee256748&hash=55a92ac6bc5a277824869d02a9c5ab53";

            Characters character = new Characters()
            {
                Avatar = "http://i.annihil.us/u/prod/marvel/i/mg/c/e0/535fecbbb9784.png",
                Id = 1011334,
                Name = "3-D Man",
                Description = null
            };

            CharactersService verif = new CharactersService();

            dynamic result = JsonConvert.DeserializeObject(await verif.ListCharacters(paramHash));

            Characters details = new Characters()
            {
                Id = result.data.results[0].id,
                Name = result.data.results[0].name,
                Avatar = result.data.results[0].thumbnail.path + "." + result.data.results[0].thumbnail.extension,
                Description = result.data.results[0].description == "" ? null : result.data.results[0].description
            };

            
            Assert.Equal(character.Name, details.Name);
            
        }               

        [Fact]
        public async void ValidateGetCharacterByIdAsync()
        {
            string paramHash = "ts=1&apikey=cdb7af1ef4a3c260a36fc5c2ee256748&hash=55a92ac6bc5a277824869d02a9c5ab53";

            Characters character = new Characters()
            {
                Avatar = "http://i.annihil.us/u/prod/marvel/i/mg/c/e0/535fecbbb9784.png",
                Id = 1011334,
                Name = "3-D Man",
                Description = null
            };

            CharactersService verif = new CharactersService();

            dynamic result = JsonConvert.DeserializeObject(await verif.GetCharacterById(character.Id, paramHash));

            Characters details = new Characters()
            {
                Id = result.data.results[0].id,
                Name = result.data.results[0].name,
                Avatar = result.data.results[0].thumbnail.path + "." + result.data.results[0].thumbnail.extension,
                Description = result.data.results[0].description == "" ? null : result.data.results[0].description
            };

            Assert.Equal(character.Id, details.Id);

        }



    }
}
 