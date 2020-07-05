using DesafioVitreo.Domain.Interface;
using DesafioVitreo.Domain.Interface.Utils;
using DesafioVitreo.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DesafioVitreo.ViewModel
{
    public class DescriptionPageViewModel
    {
        #region Properties
        protected IUtils _utils { get; }
        protected ICharactersService _characters { get; }
        public string ApiKey_hash { get; set; }
        public ObservableCollection<Characters> Items { get; set; }
        
        #endregion

        #region Constructor
        public DescriptionPageViewModel(Characters detailsCharacter)
        {
            _utils = DependencyService.Get<IUtils>();
            _characters = DependencyService.Get<ICharactersService>();

            GetItemDetailsAsync(detailsCharacter);
        }
        #endregion

        #region Methods
        private async void GetItemDetailsAsync(Characters detailsCharacter)
        {
            ApiKey_hash = _utils.GerarHash();

            Items = new ObservableCollection<Characters>();
            Items.Clear();

            dynamic result = JsonConvert.DeserializeObject(await _characters.GetCharacterById(detailsCharacter.Id, ApiKey_hash));

            var details = new Characters
            {
                Name = result.data.results[0].name,
                Avatar = result.data.results[0].thumbnail.path + "." + result.data.results[0].thumbnail.extension,
                Description = result.data.results[0].description
            };
            Items.Add(details);

        }
        #endregion
    }
}
