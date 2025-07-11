using System;

namespace PeriodicTableOfElements.Presentation.WPF.StartUp;

public class AppEntryMain
{
  [STAThread]
  public static void Main(String[] args)
  {
    SingleInstanceApp singleInstanceApp = new SingleInstanceApp();
    singleInstanceApp.Run(args);
  }
}
