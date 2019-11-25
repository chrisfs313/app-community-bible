using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCommunityBible.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMasterDetailPage : MasterDetailPage
    {
        public MainMasterDetailPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
        }
    }
}