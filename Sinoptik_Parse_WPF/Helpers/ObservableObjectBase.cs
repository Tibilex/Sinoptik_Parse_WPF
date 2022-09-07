using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Sinoptik_Parse_WPF.Helpers
{
    public class ObservableObjectBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
