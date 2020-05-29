using dot_net_playground.Models.Base;

namespace dot_net_playground.ViewModels
{
    public class CheckBoxExampleViewModel : ObservableObject
    {
        private bool _isChecked;

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                if (value != _isChecked)
                {
                    _isChecked = value;
                    OnPropertyChanged("IsChecked");
                }
            }
        }
    }
}
