// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// General reasons for a list to be empty. Reasons are either related to a summary list (i.e. problem or medication list) or to a workflow related list (i.e. consultation list).
  /// </summary>
  public static class ListEmptyReasonCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Closed = new Coding
    {
      Code = "closed",
      Display = "Closed",
      System = "http://terminology.hl7.org/CodeSystem/list-empty-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NilKnown = new Coding
    {
      Code = "nilknown",
      Display = "Nil Known",
      System = "http://terminology.hl7.org/CodeSystem/list-empty-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NotAsked = new Coding
    {
      Code = "notasked",
      Display = "Not Asked",
      System = "http://terminology.hl7.org/CodeSystem/list-empty-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NotStarted = new Coding
    {
      Code = "notstarted",
      Display = "Not Started",
      System = "http://terminology.hl7.org/CodeSystem/list-empty-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Unavailable = new Coding
    {
      Code = "unavailable",
      Display = "Unavailable",
      System = "http://terminology.hl7.org/CodeSystem/list-empty-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding InformationWithheld = new Coding
    {
      Code = "withheld",
      Display = "Information Withheld",
      System = "http://terminology.hl7.org/CodeSystem/list-empty-reason"
    };
  };
}