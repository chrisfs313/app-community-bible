using MvvmHelpers;
using System;

namespace AppComunnityBible.Models.Menu
{
    public class MasterPageItem : ObservableObject
    {
        private string _title;
        private string _iconSource;
        private Type _targetType;

        public MasterPageItem()
        {
            TargetType = typeof(MasterPageItem);
            IconSource = string.Empty;
            Title = string.Empty;
        }

        public string Title {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public string IconSource {
            get => _iconSource;
            set => SetProperty(ref _iconSource, value);
        }

        public Type TargetType {
            get => _targetType;
            set => SetProperty(ref _targetType, value);
        }
    }
}