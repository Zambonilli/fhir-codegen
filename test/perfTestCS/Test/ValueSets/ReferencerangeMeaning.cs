// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// This value set defines a set of codes that can be used to indicate the meaning/use of a reference range for a particular target population.
  /// </summary>
  public static class ReferencerangeMeaningCodes
  {
    /// <summary>
    /// Endocrine related states that change the expected value.
    /// </summary>
    public static readonly Coding Endocrine = new Coding
    {
      Code = "endocrine",
      Display = "Endocrine",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// An expected range in an individual during the follicular stage of the cycle.
    /// </summary>
    public static readonly Coding FollicularStage = new Coding
    {
      Code = "follicular",
      Display = "Follicular Stage",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// An expected range in an individual during the luteal stage of the cycle.
    /// </summary>
    public static readonly Coding Luteal = new Coding
    {
      Code = "luteal",
      Display = "Luteal",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// An expected range in an individual during the midcycle stage of the cycle.
    /// </summary>
    public static readonly Coding MidCycle = new Coding
    {
      Code = "midcycle",
      Display = "MidCycle",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// Values expected for a normal member of the relevant control population being measured. Typically each results producer such as a laboratory has specific normal ranges and they are usually defined as within two standard deviations from the mean and account for 95.45% of this population.
    /// </summary>
    public static readonly Coding NormalRange = new Coding
    {
      Code = "normal",
      Display = "Normal Range",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// The optimal range for best therapeutic outcomes for a specimen taken immediately after administration.
    /// </summary>
    public static readonly Coding PostTherapeuticDesiredLevel = new Coding
    {
      Code = "post",
      Display = "Post Therapeutic Desired Level",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// An expected range in an individual post-menopause.
    /// </summary>
    public static readonly Coding PostMenopause = new Coding
    {
      Code = "postmenopausal",
      Display = "Post-Menopause",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// The optimal range for best therapeutic outcomes for a specimen taken immediately before administration.
    /// </summary>
    public static readonly Coding PreTherapeuticDesiredLevel = new Coding
    {
      Code = "pre",
      Display = "Pre Therapeutic Desired Level",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// An expected range in an individual prior to puberty.
    /// </summary>
    public static readonly Coding PrePuberty = new Coding
    {
      Code = "pre-puberty",
      Display = "Pre-Puberty",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// The range that is recommended by a relevant professional body.
    /// </summary>
    public static readonly Coding RecommendedRange = new Coding
    {
      Code = "recommended",
      Display = "Recommended Range",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// The optimal range for best therapeutic outcomes.
    /// </summary>
    public static readonly Coding TherapeuticDesiredLevel = new Coding
    {
      Code = "therapeutic",
      Display = "Therapeutic Desired Level",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// The range at which treatment would/should be considered.
    /// </summary>
    public static readonly Coding TreatmentRange = new Coding
    {
      Code = "treatment",
      Display = "Treatment Range",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
    /// <summary>
    /// General types of reference range.
    /// </summary>
    public static readonly Coding Type = new Coding
    {
      Code = "type",
      Display = "Type",
      System = "http://terminology.hl7.org/CodeSystem/referencerange-meaning"
    };
  };
}