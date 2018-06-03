using System;
using System.Windows.Navigation;
using HumanFactor;
using UI.Helpers;

namespace UI
{

    public abstract class NavigableViewModel : ObservableObject, IDisposable
    {
        protected static EventBroker Broker;

        protected abstract void SubscribeToEvents();
        protected abstract void UnsubscribeFromEvents();

        protected void Initialize()
        {
            Broker = new EventBroker();
            SubscribeToEvents();
        }

        public void Dispose()
        {
            UnsubscribeFromEvents();
        }
    }
}
