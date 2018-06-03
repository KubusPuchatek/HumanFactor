using System.Security.Cryptography;
using System.Windows.Navigation;

namespace UI
{
 
    public interface INavigableViewModel
    {
        event NavigationEventHandler NavigationChanged;
    }
}