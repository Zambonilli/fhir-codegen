// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Overall nature of the adverse event, e.g. real or potential.
  /// </summary>
  public static class AdverseEventActualityCodes
  {
    /// <summary>
    /// The adverse event actually happened regardless of whether anyone was affected or harmed.
    /// </summary>
    public static readonly Coding AdverseEvent = new Coding
    {
      Code = "actual",
      Display = "Adverse Event",
      System = "http://hl7.org/fhir/adverse-event-actuality"
    };
    /// <summary>
    /// A potential adverse event.
    /// </summary>
    public static readonly Coding PotentialAdverseEvent = new Coding
    {
      Code = "potential",
      Display = "Potential Adverse Event",
      System = "http://hl7.org/fhir/adverse-event-actuality"
    };
  };
}