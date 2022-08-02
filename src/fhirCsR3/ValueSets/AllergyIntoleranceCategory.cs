// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Category of an identified substance.
  /// </summary>
  public static class AllergyIntoleranceCategoryCodes
  {
    /// <summary>
    /// A preparation that is synthesized from living organisms or their products, especially a human or animal protein, such as a hormone or antitoxin, that is used as a diagnostic, preventive, or therapeutic agent. Examples of biologic medications include: vaccines; allergenic extracts, which are used for both diagnosis and treatment (for example, allergy shots); gene therapies; cellular therapies.  There are other biologic products, such as tissues, that are not typically associated with allergies.
    /// </summary>
    public static readonly Coding Biologic = new Coding
    {
      Code = "biologic",
      Display = "Biologic",
      System = "http://hl7.org/fhir/allergy-intolerance-category"
    };
    /// <summary>
    /// Any substances that are encountered in the environment, including any substance not already classified as food, medication, or biologic.
    /// </summary>
    public static readonly Coding Environment = new Coding
    {
      Code = "environment",
      Display = "Environment",
      System = "http://hl7.org/fhir/allergy-intolerance-category"
    };
    /// <summary>
    /// Any substance consumed to provide nutritional support for the body.
    /// </summary>
    public static readonly Coding Food = new Coding
    {
      Code = "food",
      Display = "Food",
      System = "http://hl7.org/fhir/allergy-intolerance-category"
    };
    /// <summary>
    /// Substances administered to achieve a physiological effect.
    /// </summary>
    public static readonly Coding Medication = new Coding
    {
      Code = "medication",
      Display = "Medication",
      System = "http://hl7.org/fhir/allergy-intolerance-category"
    };

    /// <summary>
    /// Literal for code: Biologic
    /// </summary>
    public const string LiteralBiologic = "biologic";

    /// <summary>
    /// Literal for code: AllergyIntoleranceCategoryBiologic
    /// </summary>
    public const string LiteralAllergyIntoleranceCategoryBiologic = "http://hl7.org/fhir/allergy-intolerance-category#biologic";

    /// <summary>
    /// Literal for code: Environment
    /// </summary>
    public const string LiteralEnvironment = "environment";

    /// <summary>
    /// Literal for code: AllergyIntoleranceCategoryEnvironment
    /// </summary>
    public const string LiteralAllergyIntoleranceCategoryEnvironment = "http://hl7.org/fhir/allergy-intolerance-category#environment";

    /// <summary>
    /// Literal for code: Food
    /// </summary>
    public const string LiteralFood = "food";

    /// <summary>
    /// Literal for code: AllergyIntoleranceCategoryFood
    /// </summary>
    public const string LiteralAllergyIntoleranceCategoryFood = "http://hl7.org/fhir/allergy-intolerance-category#food";

    /// <summary>
    /// Literal for code: Medication
    /// </summary>
    public const string LiteralMedication = "medication";

    /// <summary>
    /// Literal for code: AllergyIntoleranceCategoryMedication
    /// </summary>
    public const string LiteralAllergyIntoleranceCategoryMedication = "http://hl7.org/fhir/allergy-intolerance-category#medication";

    /// <summary>
    /// Dictionary for looking up AllergyIntoleranceCategory Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "biologic", Biologic }, 
      { "http://hl7.org/fhir/allergy-intolerance-category#biologic", Biologic }, 
      { "environment", Environment }, 
      { "http://hl7.org/fhir/allergy-intolerance-category#environment", Environment }, 
      { "food", Food }, 
      { "http://hl7.org/fhir/allergy-intolerance-category#food", Food }, 
      { "medication", Medication }, 
      { "http://hl7.org/fhir/allergy-intolerance-category#medication", Medication }, 
    };
  };
}