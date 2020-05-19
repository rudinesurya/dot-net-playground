using dot_net_playground.Models.Base;
using System;
using System.Windows;
using System.Windows.Input;

namespace dot_net_playground.ViewModels
{
    public class ExceptionExampleViewModel : ObservableObject
    {
        private ICommand _getArrayOutOfBoundsExceptionCommand;

        public ICommand GetArrayOutOfBoundsExceptionCommand
        {
            get
            {
                if (_getArrayOutOfBoundsExceptionCommand == null)
                {
                    _getArrayOutOfBoundsExceptionCommand = new RelayCommand(
                        param => GetArrayOutOfBoundsException()
                    );
                }
                return _getArrayOutOfBoundsExceptionCommand;
            }
        }

        private void GetArrayOutOfBoundsException()
        {
            try
            {
                var arr = new int[] { 1, 2, 3 };
                var item = arr[5];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
