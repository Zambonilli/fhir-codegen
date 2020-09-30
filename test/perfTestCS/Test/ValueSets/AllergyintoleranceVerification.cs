// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Preferred value set for AllergyIntolerance Verification Status.
  /// </summary>
  public static class AllergyintoleranceVerificationCodes
  {
    /// <summary>
    /// A high level of certainty about the propensity for a reaction to the identified substance, which may include clinical evidence by testing or rechallenge.
    /// </summary>
    public static readonly Coding Confirmed = new Coding
    {
      Code = "confirmed",
      Display = "Confirmed",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// The statement was entered in error and is not valid.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// A propensity for a reaction to the identified substance has been disputed or disproven with a sufficient level of clinical certainty to justify invalidating the assertion. This might or might not include testing or rechallenge.
    /// </summary>
    public static readonly Coding Refuted = new Coding
    {
      Code = "refuted",
      Display = "Refuted",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
    /// <summary>
    /// A low level of certainty about the propensity for a reaction to the identified substance.
    /// </summary>
    public static readonly Coding Unconfirmed = new Coding
    {
      Code = "unconfirmed",
      Display = "Unconfirmed",
      System = "http://terminology.hl7.org/CodeSystem/allergyintolerance-verification"
    };
  };
}