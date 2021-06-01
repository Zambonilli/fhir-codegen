// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The scoring type of the measure.
  /// </summary>
  public static class MeasureScoringCodes
  {
    /// <summary>
    /// The measure is a cohort definition.
    /// </summary>
    public static readonly Coding Cohort = new Coding
    {
      Code = "cohort",
      Display = "Cohort",
      System = "http://terminology.hl7.org/CodeSystem/measure-scoring"
    };
    /// <summary>
    /// The score is defined by a calculation of some quantity.
    /// </summary>
    public static readonly Coding ContinuousVariable = new Coding
    {
      Code = "continuous-variable",
      Display = "Continuous Variable",
      System = "http://terminology.hl7.org/CodeSystem/measure-scoring"
    };
    /// <summary>
    /// The measure score is defined using a proportion.
    /// </summary>
    public static readonly Coding Proportion = new Coding
    {
      Code = "proportion",
      Display = "Proportion",
      System = "http://terminology.hl7.org/CodeSystem/measure-scoring"
    };
    /// <summary>
    /// The measure score is defined using a ratio.
    /// </summary>
    public static readonly Coding Ratio = new Coding
    {
      Code = "ratio",
      Display = "Ratio",
      System = "http://terminology.hl7.org/CodeSystem/measure-scoring"
    };
  };
}