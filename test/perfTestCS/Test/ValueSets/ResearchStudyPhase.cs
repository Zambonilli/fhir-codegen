// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Codes for the stage in the progression of a therapy from initial experimental use in humans in clinical trials to post-market evaluation.
  /// </summary>
  public static class ResearchStudyPhaseCodes
  {
    /// <summary>
    /// Designation for optional exploratory trials conducted in accordance with the United States Food and Drug Administration's (FDA) 2006 Guidance on Exploratory Investigational New Drug (IND) Studies. Formerly called Phase 0.
    /// </summary>
    public static readonly Coding EarlyPhase1 = new Coding
    {
      Code = "early-phase-1",
      Display = "Early Phase 1",
      System = "http://terminology.hl7.org/CodeSystem/research-study-phase"
    };
    /// <summary>
    /// Trials without phases (for example, studies of devices or behavioral interventions).
    /// </summary>
    public static readonly Coding NA = new Coding
    {
      Code = "n-a",
      Display = "N/A",
      System = "http://terminology.hl7.org/CodeSystem/research-study-phase"
    };
    /// <summary>
    /// Includes initial studies to determine the metabolism and pharmacologic actions of drugs in humans, the side effects associated with increasing doses, and to gain early evidence of effectiveness; may include healthy participants and/or patients.
    /// </summary>
    public static readonly Coding Phase1 = new Coding
    {
      Code = "phase-1",
      Display = "Phase 1",
      System = "http://terminology.hl7.org/CodeSystem/research-study-phase"
    };
    /// <summary>
    /// Trials that are a combination of phases 1 and 2.
    /// </summary>
    public static readonly Coding Phase1Phase2 = new Coding
    {
      Code = "phase-1-phase-2",
      Display = "Phase 1/Phase 2",
      System = "http://terminology.hl7.org/CodeSystem/research-study-phase"
    };
    /// <summary>
    /// Includes controlled clinical studies conducted to evaluate the effectiveness of the drug for a particular indication or indications in participants with the disease or condition under study and to determine the common short-term side effects and risks.
    /// </summary>
    public static readonly Coding Phase2 = new Coding
    {
      Code = "phase-2",
      Display = "Phase 2",
      System = "http://terminology.hl7.org/CodeSystem/research-study-phase"
    };
    /// <summary>
    /// Trials that are a combination of phases 2 and 3.
    /// </summary>
    public static readonly Coding Phase2Phase3 = new Coding
    {
      Code = "phase-2-phase-3",
      Display = "Phase 2/Phase 3",
      System = "http://terminology.hl7.org/CodeSystem/research-study-phase"
    };
    /// <summary>
    /// Includes trials conducted after preliminary evidence suggesting effectiveness of the drug has been obtained, and are intended to gather additional information to evaluate the overall benefit-risk relationship of the drug.
    /// </summary>
    public static readonly Coding Phase3 = new Coding
    {
      Code = "phase-3",
      Display = "Phase 3",
      System = "http://terminology.hl7.org/CodeSystem/research-study-phase"
    };
    /// <summary>
    /// Studies of FDA-approved drugs to delineate additional information including the drug's risks, benefits, and optimal use.
    /// </summary>
    public static readonly Coding Phase4 = new Coding
    {
      Code = "phase-4",
      Display = "Phase 4",
      System = "http://terminology.hl7.org/CodeSystem/research-study-phase"
    };
  };
}