using System;
using System.Collections.Generic;

namespace SJB.Science.PeriodicTable.Model;

public class AtomicElement
  {
  public Byte AtomicNumber
    { get; set; }

  public String Symbol
    { get; set; }

  public String Name
    { get; set; }

  public Byte Group
    { get; set; }

  public Byte Period
    { get; set; }

  public Category Category
    { get; set; }

  public Double AtomicWeight
    { get; set; }

  public Double AtomicRadius
    { get; set; }

  public List<Isotope> Isotopes
    { get; set; }
  }
