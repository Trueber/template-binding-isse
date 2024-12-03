using TemplatedControlBindingIssue.Models;

namespace TemplatedControlBindingIssue.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static

    public ObservableControlModel Model1 { get; set; } = new() { State = ETemplateControlState.State1 };
    public ObservableControlModel Model2 { get; set; } = new() { State = ETemplateControlState.State2 };
    public ObservableControlModel Model3 { get; set; } = new() { State = ETemplateControlState.State3 };
    public ObservableControlModel Model4 { get; set; } = new() { State = ETemplateControlState.Default };
}
