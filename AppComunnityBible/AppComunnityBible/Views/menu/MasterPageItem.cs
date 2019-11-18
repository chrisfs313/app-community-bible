using System;

namespace AppComunnityBible.Views
{

    public class MasterPageItem
    {
        public MasterPageItem()
        {
            TargetType = typeof(MasterPageItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Type TargetType { get; set; }
    }
}