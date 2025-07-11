using System;
using System.Windows;
using Microsoft.VisualBasic.ApplicationServices;
using PeriodicTableOfElements.Infrastructure;

namespace PeriodicTableOfElements.Presentation.WPF;

public partial class App : Application
{  
}

public class SingleInstanceApp : WindowsFormsApplicationBase
{
  private App app;

  public SingleInstanceApp()
  {
    this.IsSingleInstance = true;
  }

  protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
  {
    app = new App();
    PeriodicTableDAL dal = PeriodicTableDAL.Instance;
    WindowMain mainWindow = new WindowMain();

    mainWindow.DataContext = dal.GetPeriodicTableData();
    mainWindow.Title = "Periodic Table of Elements";

    app.Run(mainWindow);
    return false;
  }

  protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
  {
    e.BringToForeground = true;
    app.MainWindow.Activate();
  }
}
