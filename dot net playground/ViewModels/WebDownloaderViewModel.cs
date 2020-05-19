using dot_net_playground.Models;
using dot_net_playground.Models.Base;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace dot_net_playground.ViewModels
{
    public class WebDownloaderViewModel : ObservableObject
    {
        private ProductModel _currentProduct;
        private ICommand _downloadProduct;
        private ICommand _downloadProductAsync;
        private long _fetchTime;

        public ProductModel CurrentProduct
        {
            get { return _currentProduct; }
            set
            {
                if (value != _currentProduct)
                {
                    _currentProduct = value;
                    OnPropertyChanged("CurrentProduct");
                }
            }
        }

        public ICommand DownloadProductCommand
        {
            get
            {
                if (_downloadProduct == null)
                {
                    _downloadProduct = new RelayCommand(
                        param => DownloadProduct()
                    );
                }
                return _downloadProduct;
            }
        }

        public ICommand DownloadProductAsyncCommand
        {
            get
            {
                if (_downloadProductAsync == null)
                {
                    _downloadProductAsync = new RelayCommand(
                        param => DownloadProductAsync()
                    );
                }
                return _downloadProductAsync;
            }
        }

        public long FetchTime
        {
            get { return _fetchTime; }
            set
            {
                if (value != _fetchTime)
                {
                    _fetchTime = value;
                    OnPropertyChanged("FetchTime");
                }
            }
        }

        private void DownloadProduct()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            CurrentProduct = _DownloadProduct();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            FetchTime = elapsedMs;
        }

        private async void DownloadProductAsync()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            CurrentProduct = await Task.Run(() => _DownloadProduct());

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            FetchTime = elapsedMs;
        }

        private ProductModel _DownloadProduct()
        {
            Thread.Sleep(2000);

            return new ProductModel
            {
                ProductId = new Random().Next(),
                ProductName = string.Format("New Product {0}", new Random().Next()),
                UnitPrice = new Random().Next()
            };
        }
    }
}
