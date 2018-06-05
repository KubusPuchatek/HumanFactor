namespace HumanFactor
{
    public delegate void NavigationEventHandler(object sender, HumanFactorNavigationChangedArgs e);

    public class EventBroker
    {
        public event NavigationEventHandler NavigationChanged;

        public void InvokeNavigationChanged(HumanFactorNavigationChangedArgs e)
        {
            NavigationChanged?.Invoke(this, e);
        }
    }
}
