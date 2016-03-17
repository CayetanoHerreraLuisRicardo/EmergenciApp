using AppStudio.Services;
using AppStudio.ViewModels;

using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AppStudio.Views
{
    public sealed partial class TELEFONOSDEEMERGENCIA1Detail : Page
    {
        private NavigationHelper _navigationHelper;

        private DataTransferManager _dataTransferManager;

        public TELEFONOSDEEMERGENCIA1Detail()
        {
            this.InitializeComponent();
            _navigationHelper = new NavigationHelper(this);

            TELEFONOSDEEMERGENCIA1Model = new TELEFONOSDEEMERGENCIA1ViewModel();
        }

        public TELEFONOSDEEMERGENCIA1ViewModel TELEFONOSDEEMERGENCIA1Model { get; private set; }

        public NavigationHelper NavigationHelper
        {
            get { return _navigationHelper; }
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            _dataTransferManager = DataTransferManager.GetForCurrentView();
            _dataTransferManager.DataRequested += OnDataRequested;

            _navigationHelper.OnNavigatedTo(e);

            if (TELEFONOSDEEMERGENCIA1Model != null)
            {
                await TELEFONOSDEEMERGENCIA1Model.LoadItemsAsync();
                TELEFONOSDEEMERGENCIA1Model.SelectItem(e.Parameter);

                TELEFONOSDEEMERGENCIA1Model.ViewType = ViewTypes.Detail;
            }
            DataContext = this;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            _navigationHelper.OnNavigatedFrom(e);
            _dataTransferManager.DataRequested -= OnDataRequested;
        }

        private void OnDataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            if (TELEFONOSDEEMERGENCIA1Model != null)
            {
                TELEFONOSDEEMERGENCIA1Model.GetShareContent(args.Request);
            }
        }
    }
}
