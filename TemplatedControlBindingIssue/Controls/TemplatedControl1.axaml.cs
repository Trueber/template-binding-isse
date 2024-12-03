using System;
using System.Windows.Input;
using Avalonia;
using Avalonia.Controls.Primitives;
using TemplatedControlBindingIssue.Models;

namespace TemplatedControlBindingIssue.Controls;

public class TemplatedControl1 : TemplatedControl
{
    static TemplatedControl1()
    {
        StateProperty.Changed.Subscribe(
            next =>
            {
                if (next.Sender is not TemplatedControl1 control1)
                {
                    return;
                }

                control1.MenuItem1Visible =
                    next.NewValue.Value is ETemplateControlState.State1 or ETemplateControlState.State2 or ETemplateControlState.Default;
                control1.MenuItem2Visible = next.NewValue.Value is ETemplateControlState.State2 or ETemplateControlState.State3;
                control1.MenuItem3Visible = next.NewValue.Value is ETemplateControlState.State1 or ETemplateControlState.State3;
            }
        );
    }

    public static readonly StyledProperty<ETemplateControlState> StateProperty =
        AvaloniaProperty.Register<TemplatedControl1, ETemplateControlState>(nameof(State));

    public ETemplateControlState State
    {
        get => GetValue(StateProperty);
        set => SetValue(StateProperty, value);
    }

    public static readonly StyledProperty<ICommand?> MenuItem1Property = AvaloniaProperty.Register<TemplatedControl1, ICommand?>(nameof(MenuItem1));

    public ICommand? MenuItem1
    {
        get => GetValue(MenuItem1Property);
        set => SetValue(MenuItem1Property, value);
    }

    public static readonly StyledProperty<bool> MenuItem1VisibleProperty =
        AvaloniaProperty.Register<TemplatedControl1, bool>(nameof(MenuItem1Visible), defaultValue: false);

    public bool MenuItem1Visible
    {
        get => GetValue(MenuItem1VisibleProperty);
        set => SetValue(MenuItem1VisibleProperty, value);
    }

    public static readonly StyledProperty<ICommand?> MenuItem2Property = AvaloniaProperty.Register<TemplatedControl1, ICommand?>(nameof(MenuItem2));

    public ICommand? MenuItem2
    {
        get => GetValue(MenuItem2Property);
        set => SetValue(MenuItem2Property, value);
    }

    public static readonly StyledProperty<bool> MenuItem2VisibleProperty =
        AvaloniaProperty.Register<TemplatedControl1, bool>(nameof(MenuItem2Visible), defaultValue: false);

    public bool MenuItem2Visible
    {
        get => GetValue(MenuItem2VisibleProperty);
        set => SetValue(MenuItem2VisibleProperty, value);
    }

    public static readonly StyledProperty<ICommand?> MenuItem3Property = AvaloniaProperty.Register<TemplatedControl1, ICommand?>(nameof(MenuItem3));

    public ICommand? MenuItem3
    {
        get => GetValue(MenuItem3Property);
        set => SetValue(MenuItem3Property, value);
    }

    public static readonly StyledProperty<bool> MenuItem3VisibleProperty =
        AvaloniaProperty.Register<TemplatedControl1, bool>(nameof(MenuItem3Visible), defaultValue: false);

    public bool MenuItem3Visible
    {
        get => GetValue(MenuItem3VisibleProperty);
        set => SetValue(MenuItem3VisibleProperty, value);
    }
}
