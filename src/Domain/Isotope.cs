using System;

namespace SJB.Science.PeriodicTable.Model;

public class Isotope : AtomicElement 
  {
  private int _protonCount;
  private int _neutronCount;
  private DecayType _decaymethod;
  
  public Isotope(AtomicElement element, int neutronCount, DecayType decaymethod) : base()
    {
    this._protonCount = element.AtomicNumber;
    this._neutronCount = neutronCount;
    this._decaymethod = decaymethod;
    }
  }
