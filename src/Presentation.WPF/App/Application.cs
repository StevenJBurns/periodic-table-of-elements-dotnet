namespace PeriodicTableOfElements.Presentation.WPF;

public class App : Application
{
  public App() {}
  
  [STAThread]
  static void Main()
  {
    App app = new App();
    app.Run(new WindowPeriodicTable());
  }
}

