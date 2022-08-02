// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of Adjudication Value codes which includes codes to indicate the amounts eligible under the plan, the amount of benefit, copays etc.
  /// </summary>
  public static class AdjudicationCodes
  {
    /// <summary>
    /// Amount payable under the coverage
    /// </summary>
    public static readonly Coding BenefitAmount = new Coding
    {
      Code = "benefit",
      Display = "Benefit Amount",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// Patient Co-Payment
    /// </summary>
    public static readonly Coding CoPay = new Coding
    {
      Code = "copay",
      Display = "CoPay",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// Amount deducted from the eligible amount prior to adjudication.
    /// </summary>
    public static readonly Coding Deductible = new Coding
    {
      Code = "deductible",
      Display = "Deductible",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// Amount of the change which is considered for adjudication.
    /// </summary>
    public static readonly Coding EligibleAmount = new Coding
    {
      Code = "eligible",
      Display = "Eligible Amount",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// Eligible Percentage.
    /// </summary>
    public static readonly Coding EligiblePercent = new Coding
    {
      Code = "eligpercent",
      Display = "Eligible %",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// The total submitted amount for the claim or group or line item.
    /// </summary>
    public static readonly Coding SubmittedAmount = new Coding
    {
      Code = "submitted",
      Display = "Submitted Amount",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// The amount of tax.
    /// </summary>
    public static readonly Coding Tax = new Coding
    {
      Code = "tax",
      Display = "Tax",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// The amount of deductible which could not allocated to other line items.
    /// </summary>
    public static readonly Coding UnallocatedDeductible = new Coding
    {
      Code = "unallocdeduct",
      Display = "Unallocated Deductible",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };

    /// <summary>
    /// Literal for code: BenefitAmount
    /// </summary>
    public const string LiteralBenefitAmount = "benefit";

    /// <summary>
    /// Literal for code: AdjudicationBenefitAmount
    /// </summary>
    public const string LiteralAdjudicationBenefitAmount = "http://terminology.hl7.org/CodeSystem/adjudication#benefit";

    /// <summary>
    /// Literal for code: CoPay
    /// </summary>
    public const string LiteralCoPay = "copay";

    /// <summary>
    /// Literal for code: AdjudicationCoPay
    /// </summary>
    public const string LiteralAdjudicationCoPay = "http://terminology.hl7.org/CodeSystem/adjudication#copay";

    /// <summary>
    /// Literal for code: Deductible
    /// </summary>
    public const string LiteralDeductible = "deductible";

    /// <summary>
    /// Literal for code: AdjudicationDeductible
    /// </summary>
    public const string LiteralAdjudicationDeductible = "http://terminology.hl7.org/CodeSystem/adjudication#deductible";

    /// <summary>
    /// Literal for code: EligibleAmount
    /// </summary>
    public const string LiteralEligibleAmount = "eligible";

    /// <summary>
    /// Literal for code: AdjudicationEligibleAmount
    /// </summary>
    public const string LiteralAdjudicationEligibleAmount = "http://terminology.hl7.org/CodeSystem/adjudication#eligible";

    /// <summary>
    /// Literal for code: EligiblePercent
    /// </summary>
    public const string LiteralEligiblePercent = "eligpercent";

    /// <summary>
    /// Literal for code: AdjudicationEligiblePercent
    /// </summary>
    public const string LiteralAdjudicationEligiblePercent = "http://terminology.hl7.org/CodeSystem/adjudication#eligpercent";

    /// <summary>
    /// Literal for code: SubmittedAmount
    /// </summary>
    public const string LiteralSubmittedAmount = "submitted";

    /// <summary>
    /// Literal for code: AdjudicationSubmittedAmount
    /// </summary>
    public const string LiteralAdjudicationSubmittedAmount = "http://terminology.hl7.org/CodeSystem/adjudication#submitted";

    /// <summary>
    /// Literal for code: Tax
    /// </summary>
    public const string LiteralTax = "tax";

    /// <summary>
    /// Literal for code: AdjudicationTax
    /// </summary>
    public const string LiteralAdjudicationTax = "http://terminology.hl7.org/CodeSystem/adjudication#tax";

    /// <summary>
    /// Literal for code: UnallocatedDeductible
    /// </summary>
    public const string LiteralUnallocatedDeductible = "unallocdeduct";

    /// <summary>
    /// Literal for code: AdjudicationUnallocatedDeductible
    /// </summary>
    public const string LiteralAdjudicationUnallocatedDeductible = "http://terminology.hl7.org/CodeSystem/adjudication#unallocdeduct";

    /// <summary>
    /// Dictionary for looking up Adjudication Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "benefit", BenefitAmount }, 
      { "http://terminology.hl7.org/CodeSystem/adjudication#benefit", BenefitAmount }, 
      { "copay", CoPay }, 
      { "http://terminology.hl7.org/CodeSystem/adjudication#copay", CoPay }, 
      { "deductible", Deductible }, 
      { "http://terminology.hl7.org/CodeSystem/adjudication#deductible", Deductible }, 
      { "eligible", EligibleAmount }, 
      { "http://terminology.hl7.org/CodeSystem/adjudication#eligible", EligibleAmount }, 
      { "eligpercent", EligiblePercent }, 
      { "http://terminology.hl7.org/CodeSystem/adjudication#eligpercent", EligiblePercent }, 
      { "submitted", SubmittedAmount }, 
      { "http://terminology.hl7.org/CodeSystem/adjudication#submitted", SubmittedAmount }, 
      { "tax", Tax }, 
      { "http://terminology.hl7.org/CodeSystem/adjudication#tax", Tax }, 
      { "unallocdeduct", UnallocatedDeductible }, 
      { "http://terminology.hl7.org/CodeSystem/adjudication#unallocdeduct", UnallocatedDeductible }, 
    };
  };
}