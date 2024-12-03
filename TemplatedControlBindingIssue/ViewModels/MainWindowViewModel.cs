using System.Linq;
using TemplatedControlBindingIssue.Models;

namespace TemplatedControlBindingIssue.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static

    public ObservableControlModel[] ControlModels { get; set; } =
        Enumerable.Range(0, 9).Select(i => new ObservableControlModel { State = (ETemplateControlState) (i % 4) }).ToArray();
}
