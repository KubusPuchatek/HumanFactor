namespace HumanFactor
{
    public delegate void NavigationEventHandler(object sender, HumanFactorNavigationChangetArgs e);

    public class EventBroker
    {
        public event NavigationEventHandler NavigationChanged;

        public void InvokeNavigationChanged(HumanFactorNavigationChangetArgs e)
        {
            NavigationChanged?.Invoke(this, e);
        }
    }
}
