using dot_net_playground.Models.Base;
using System.Globalization;
using System.Threading;

namespace dot_net_playground.ViewModels
{
    public class LocalizationExampleViewModel : ObservableObject
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;


        public string Language
        {
            get { return Thread.CurrentThread.CurrentUICulture.DisplayName; }
            private set { }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value != _firstName)
                {
                    _firstName = value;
                    OnPropertyChanged("FirstName");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value != _lastName)
                {
                    _lastName = value;
                    OnPropertyChanged("LastName");
                    OnPropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
            set
            {
                if (value != _fullName)
                {
                    _fullName = value;
                    OnPropertyChanged("FullName");
                }
            }
        }
    }
}
