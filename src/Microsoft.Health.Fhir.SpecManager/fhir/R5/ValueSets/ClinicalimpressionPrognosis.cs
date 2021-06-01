// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Example value set for clinical impression prognosis.
  /// </summary>
  public static class ClinicalimpressionPrognosisCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrognosisGood = new Coding
    {
      Code = "170968001",
      Display = "Prognosis good",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrognosisBad = new Coding
    {
      Code = "170969009",
      Display = "Prognosis bad",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrognosisUncertain = new Coding
    {
      Code = "170970005",
      Display = "Prognosis uncertain",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrognosisOutlookFinding = new Coding
    {
      Code = "365858006",
      Display = "Prognosis/outlook finding",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ConditionalPrognosis = new Coding
    {
      Code = "60484009",
      Display = "Conditional prognosis",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FairPrognosis = new Coding
    {
      Code = "65872000",
      Display = "Fair prognosis",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding GuardedPrognosis = new Coding
    {
      Code = "67334001",
      Display = "Guarded prognosis",
      System = "http://snomed.info/sct"
    };
  };
}