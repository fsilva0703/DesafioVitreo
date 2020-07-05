using System;
using System.ComponentModel;

namespace DesafioVitreo.Model
{
    public class Characters : INotifyPropertyChanged
    {
        #region Fields

        private int id;
        private string avatar;
        private string name;
        private string description;

        #endregion

        #region Properties

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                this.RaisePropertyChanged("Id");
            }
        }

        public string Avatar
        {
            get
            {
                return avatar;
            }
            set
            {
                avatar = value;
                this.RaisePropertyChanged("Avatar");
            }
        }

        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                this.RaisePropertyChanged("Name");
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
                this.RaisePropertyChanged("Description");
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(String name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion
    }
}
