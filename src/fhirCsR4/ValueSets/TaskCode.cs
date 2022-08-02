// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Codes indicating the type of action that is expected to be performed
  /// </summary>
  public static class TaskCodeCodes
  {
    /// <summary>
    /// Abort, cancel or withdraw the focal resource, as appropriate for the type of resource.
    /// </summary>
    public static readonly Coding MarkTheFocalResourceAsNoLongerActive = new Coding
    {
      Code = "abort",
      Display = "Mark the focal resource as no longer active",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Take what actions are needed to transition the focus resource from 'draft' to 'active' or 'in-progress', as appropriate for the resource type.  This may involve additing additional content, approval, validation, etc.
    /// </summary>
    public static readonly Coding ActivateApproveTheFocalResource = new Coding
    {
      Code = "approve",
      Display = "Activate/approve the focal resource",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Update the focal resource of the owning system to reflect the content specified as the Task.focus
    /// </summary>
    public static readonly Coding ChangeTheFocalResource = new Coding
    {
      Code = "change",
      Display = "Change the focal resource",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Act to perform the actions defined in the focus request.  This might result in a 'more assertive' request (order for a plan or proposal, filler order for a placer order), but is intend to eventually result in events.  The degree of fulfillment requested might be limited by Task.restriction.
    /// </summary>
    public static readonly Coding FulfillTheFocalRequest = new Coding
    {
      Code = "fulfill",
      Display = "Fulfill the focal request",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Replace the focal resource with the specified input resource
    /// </summary>
    public static readonly Coding ReplaceTheFocalResourceWithTheInputResource = new Coding
    {
      Code = "replace",
      Display = "Replace the focal resource with the input resource",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Transition the focal resource from 'suspended' to 'active' or 'in-progress' as appropriate for the resource type.
    /// </summary>
    public static readonly Coding ReActivateTheFocalResource = new Coding
    {
      Code = "resume",
      Display = "Re-activate the focal resource",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };
    /// <summary>
    /// Transition the focal resource from 'active' or 'in-progress' to 'suspended'
    /// </summary>
    public static readonly Coding SuspendTheFocalResource = new Coding
    {
      Code = "suspend",
      Display = "Suspend the focal resource",
      System = "http://hl7.org/fhir/CodeSystem/task-code"
    };

    /// <summary>
    /// Literal for code: MarkTheFocalResourceAsNoLongerActive
    /// </summary>
    public const string LiteralMarkTheFocalResourceAsNoLongerActive = "abort";

    /// <summary>
    /// Literal for code: TaskCodeMarkTheFocalResourceAsNoLongerActive
    /// </summary>
    public const string LiteralTaskCodeMarkTheFocalResourceAsNoLongerActive = "http://hl7.org/fhir/CodeSystem/task-code#abort";

    /// <summary>
    /// Literal for code: ActivateApproveTheFocalResource
    /// </summary>
    public const string LiteralActivateApproveTheFocalResource = "approve";

    /// <summary>
    /// Literal for code: TaskCodeActivateApproveTheFocalResource
    /// </summary>
    public const string LiteralTaskCodeActivateApproveTheFocalResource = "http://hl7.org/fhir/CodeSystem/task-code#approve";

    /// <summary>
    /// Literal for code: ChangeTheFocalResource
    /// </summary>
    public const string LiteralChangeTheFocalResource = "change";

    /// <summary>
    /// Literal for code: TaskCodeChangeTheFocalResource
    /// </summary>
    public const string LiteralTaskCodeChangeTheFocalResource = "http://hl7.org/fhir/CodeSystem/task-code#change";

    /// <summary>
    /// Literal for code: FulfillTheFocalRequest
    /// </summary>
    public const string LiteralFulfillTheFocalRequest = "fulfill";

    /// <summary>
    /// Literal for code: TaskCodeFulfillTheFocalRequest
    /// </summary>
    public const string LiteralTaskCodeFulfillTheFocalRequest = "http://hl7.org/fhir/CodeSystem/task-code#fulfill";

    /// <summary>
    /// Literal for code: ReplaceTheFocalResourceWithTheInputResource
    /// </summary>
    public const string LiteralReplaceTheFocalResourceWithTheInputResource = "replace";

    /// <summary>
    /// Literal for code: TaskCodeReplaceTheFocalResourceWithTheInputResource
    /// </summary>
    public const string LiteralTaskCodeReplaceTheFocalResourceWithTheInputResource = "http://hl7.org/fhir/CodeSystem/task-code#replace";

    /// <summary>
    /// Literal for code: ReActivateTheFocalResource
    /// </summary>
    public const string LiteralReActivateTheFocalResource = "resume";

    /// <summary>
    /// Literal for code: TaskCodeReActivateTheFocalResource
    /// </summary>
    public const string LiteralTaskCodeReActivateTheFocalResource = "http://hl7.org/fhir/CodeSystem/task-code#resume";

    /// <summary>
    /// Literal for code: SuspendTheFocalResource
    /// </summary>
    public const string LiteralSuspendTheFocalResource = "suspend";

    /// <summary>
    /// Literal for code: TaskCodeSuspendTheFocalResource
    /// </summary>
    public const string LiteralTaskCodeSuspendTheFocalResource = "http://hl7.org/fhir/CodeSystem/task-code#suspend";

    /// <summary>
    /// Dictionary for looking up TaskCode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "abort", MarkTheFocalResourceAsNoLongerActive }, 
      { "http://hl7.org/fhir/CodeSystem/task-code#abort", MarkTheFocalResourceAsNoLongerActive }, 
      { "approve", ActivateApproveTheFocalResource }, 
      { "http://hl7.org/fhir/CodeSystem/task-code#approve", ActivateApproveTheFocalResource }, 
      { "change", ChangeTheFocalResource }, 
      { "http://hl7.org/fhir/CodeSystem/task-code#change", ChangeTheFocalResource }, 
      { "fulfill", FulfillTheFocalRequest }, 
      { "http://hl7.org/fhir/CodeSystem/task-code#fulfill", FulfillTheFocalRequest }, 
      { "replace", ReplaceTheFocalResourceWithTheInputResource }, 
      { "http://hl7.org/fhir/CodeSystem/task-code#replace", ReplaceTheFocalResourceWithTheInputResource }, 
      { "resume", ReActivateTheFocalResource }, 
      { "http://hl7.org/fhir/CodeSystem/task-code#resume", ReActivateTheFocalResource }, 
      { "suspend", SuspendTheFocalResource }, 
      { "http://hl7.org/fhir/CodeSystem/task-code#suspend", SuspendTheFocalResource }, 
    };
  };
}