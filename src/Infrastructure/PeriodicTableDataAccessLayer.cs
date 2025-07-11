namespace PeriodicTableOfElements.Infrastructure;

public class PeriodicTableDAL
{
  private static PeriodicTableDAL instance;
  public static PeriodicTableDAL Instance
  {
    get
    {
      if (instance == null) instance = new PeriodicTableDAL();
      return instance;
    }
  }

  private ObservableCollection<AtomicElement> AE;

  private PeriodicTableDAL()
  {

    allElements = new ObservableCollection<AtomicElement>();

    XmlReader reader = XmlReader.Create(Assembly.GetExecutingAssembly().GetManifestResourceStream("SJB.Science.PeriodicTable.Data.PeriodicTable.xml"));

    XElement XE = XElement.Load(reader);

    foreach (XElement xe in XE.Elements("Element"))
    {
      AtomicElement e = new AtomicElement
      {
        AtomicNumber = byte.Parse(xe.Attribute("Z").Value),
        Symbol = xe.Attribute("symbol").Value,
        Name = xe.Attribute("name").Value,
        Period = byte.Parse(xe.Attribute("period").Value),
        Group = byte.Parse(xe.Attribute("group").Value)
      };


      allElements.Add(e);
    }
  }

  public ObservableCollection<AtomicElement> GetPeriodicTableData()
  {
    return allElements;
  }
}
