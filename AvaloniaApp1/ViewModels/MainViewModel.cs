using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace AvaloniaApp1.ViewModels;

public class Element : ReactiveObject
{
    public string Text { get; set; } = string.Empty;

    private bool _isSelected;
    public bool IsSelected
    {
        get => _isSelected; 
        set => this.RaiseAndSetIfChanged(ref _isSelected, value);
    }
}

public class MainViewModel : ViewModelBase
{
    private bool _isMultiSelected;
    public bool IsMultiSelected
    {
        get => _isMultiSelected;
        set => this.RaiseAndSetIfChanged(ref _isMultiSelected, value);
    }

    public string Greeting => "Welcome to Avalonia!";

    public ObservableCollection<Element> Elements { get; set; }

    public MainViewModel()
    {
        var elements = Enumerable.Range(0, 800).Select(e => new Element() { Text = e.ToString()}).ToList();
        Elements = new ObservableCollection<Element>(elements);
    }
}
