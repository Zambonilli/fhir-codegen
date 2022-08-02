// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of Prescription Product codes.
  /// </summary>
  public static class VisionProductCodes
  {
    /// <summary>
    /// A lens to be fitted for wearing directly on an eye.
    /// </summary>
    public static readonly Coding ContactLens = new Coding
    {
      Code = "contact",
      Display = "Contact Lens",
      System = "http://terminology.hl7.org/CodeSystem/ex-visionprescriptionproduct"
    };
    /// <summary>
    /// A lens to be fitted to a frame to comprise a pair of glasses.
    /// </summary>
    public static readonly Coding Lens = new Coding
    {
      Code = "lens",
      Display = "Lens",
      System = "http://terminology.hl7.org/CodeSystem/ex-visionprescriptionproduct"
    };

    /// <summary>
    /// Literal for code: ContactLens
    /// </summary>
    public const string LiteralContactLens = "contact";

    /// <summary>
    /// Literal for code: VisionProductContactLens
    /// </summary>
    public const string LiteralVisionProductContactLens = "http://terminology.hl7.org/CodeSystem/ex-visionprescriptionproduct#contact";

    /// <summary>
    /// Literal for code: Lens
    /// </summary>
    public const string LiteralLens = "lens";

    /// <summary>
    /// Literal for code: VisionProductLens
    /// </summary>
    public const string LiteralVisionProductLens = "http://terminology.hl7.org/CodeSystem/ex-visionprescriptionproduct#lens";

    /// <summary>
    /// Dictionary for looking up VisionProduct Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "contact", ContactLens }, 
      { "http://terminology.hl7.org/CodeSystem/ex-visionprescriptionproduct#contact", ContactLens }, 
      { "lens", Lens }, 
      { "http://terminology.hl7.org/CodeSystem/ex-visionprescriptionproduct#lens", Lens }, 
    };
  };
}