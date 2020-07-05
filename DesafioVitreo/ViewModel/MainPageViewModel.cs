using DesafioVitreo.Domain.Interface;
using DesafioVitreo.Domain.Interface.Utils;
using DesafioVitreo.Model;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DesafioVitreo.ViewModel
{
    [Preserve(AllMembers = true)]
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties
        protected IUtils _utils { get; }
        protected ICharactersService _characters { get; }
        public string ApiKey_hash { get; set; }
        public ObservableCollection<Characters> Items { get; set; }
        
        private bool isBusy;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        #endregion

        #region Constructor
        public MainPageViewModel()
        {
            _utils = DependencyService.Get<IUtils>();
            _characters = DependencyService.Get<ICharactersService>();

            AddItemDetailsAsync();
        }
        #endregion

        #region Methods
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private async void AddItemDetailsAsync()
        {
            ApiKey_hash = _utils.GerarHash();

            IsBusy = true;

            Items = new ObservableCollection<Characters>();
            Items.Clear();

            dynamic result = JsonConvert.DeserializeObject(await _characters.ListCharacters(ApiKey_hash));

            foreach (var item in result.data.results)
            {
                var details = new Characters()
                {
                    Id = item.id,
                    Name = item.name,
                    Avatar = item.thumbnail.path + "." + item.thumbnail.extension
                };
                Items.Add(details);
            }

            IsBusy = false;

        }
        #endregion

        
    }
}
