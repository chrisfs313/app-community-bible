using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppComunnityBible.Behaviours
{
    public class ListViewSelectedItemBehavior : Behavior<ListView>
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", 
            typeof(ICommand), typeof(ListViewSelectedItemBehavior), null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public ListView AssociatedObject { get; private set; }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            AssociatedObject = bindable;
            bindable.BindingContextChanged += OnBindingContextChanged;
            bindable.ItemSelected += OnItemSelected;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.BindingContextChanged -= OnBindingContextChanged;
            bindable.ItemSelected -= OnItemSelected;
            AssociatedObject = null;
        }

        private void OnBindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (Command == null)
            {
                return;
            }

            if (Command.CanExecute(e))
            {
                Command.Execute(e);
            }
            (sender as ListView).SelectedItem = null;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociatedObject.BindingContext;
        }
    }
}
