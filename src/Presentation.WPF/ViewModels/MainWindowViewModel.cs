namespace PeriodicTableOfElements.Presentation.WPF;

public class WindowMainViewModel : ViewModelBase
  {
  readonly AtomicElements allElements;

  ObservableCollection<ViewModelBase> viewModels;

  public WindowMainViewModel()
  {
    allElements = new AtomicElements();
  }

  public ObservableCollection<ViewModelBase> ViewModels
    {
    get
      {
      if (viewModels == null) viewModels = new ObservableCollection<ViewModelBase>();
      
      return viewModels;
      }
    }
  }
