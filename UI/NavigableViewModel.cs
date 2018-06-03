using System;
using System.Windows.Navigation;
using UI.Helpers;

namespace UI
{
    public delegate void NavigationEventHandler(object sender, HumanFactorNavigationChangetArgs e);

    public abstract class NavigableViewModel : ObservableObject, IDisposable
    {
        public event NavigationEventHandler NavigationChanged;

        protected abstract void SubscribeToEvents();
        protected abstract void UnsubscribeFromEvents();

        protected void Initialize()
        {
            SubscribeToEvents();
        }

        public void Dispose()
        {
            UnsubscribeFromEvents();
        }

        protected virtual void OnNavigationChanged(HumanFactorNavigationChangetArgs e)
        {
            NavigationChanged?.Invoke(this, e);
        }
    }
}
