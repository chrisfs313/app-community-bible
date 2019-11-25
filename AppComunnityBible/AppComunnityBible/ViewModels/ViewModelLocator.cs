using AppCommunityBible.ViewModels.Menu;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCommunityBible.ViewModels
{
    public class ViewModelLocator
    {
        public MainMasterDetailPageViewModel MainMasterDetailPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainMasterDetailPageViewModel>();
            }
        }
    }
}
