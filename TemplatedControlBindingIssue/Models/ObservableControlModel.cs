using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace TemplatedControlBindingIssue.Models;

public class ObservableControlModel : ReactiveObject
{
    [Reactive]
    public ETemplateControlState State { get; set; }
}
