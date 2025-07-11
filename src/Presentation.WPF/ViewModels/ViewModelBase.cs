namespace PeriodicTableOfElements.Presentation.WPF;

public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
  {
  public event PropertyChangedEventHandler PropertyChanged;
  
  protected ViewModelBase()
    {
    }

  protected virtual void OnPropertyChanged(String propertyName)
    {
    PropertyChangedEventHandler handler = this.PropertyChanged;

    var e = new PropertyChangedEventArgs(propertyName);
    handler(this, e);
    }

  public void Dispose()
  {
    this.OnDispose();
  }

  protected virtual void OnDispose()
    {
    }
  }
