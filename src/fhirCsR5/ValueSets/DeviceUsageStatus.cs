// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// A coded concept indicating the current status of the Device Usage.
  /// </summary>
  public static class DeviceUsageStatusCodes
  {
    /// <summary>
    /// The device is still being used.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// The device is no longer being used.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// The statement was recorded incorrectly.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// The device may be used at some time in the future.
    /// </summary>
    public static readonly Coding Intended = new Coding
    {
      Code = "intended",
      Display = "Intended",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// The device was not used.
    /// </summary>
    public static readonly Coding NotDone = new Coding
    {
      Code = "not-done",
      Display = "Not done",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// Actions implied by the statement have been temporarily halted, but are expected to continue later. May also be called "suspended".
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On Hold",
      System = "http://hl7.org/fhir/device-usage-status"
    };
    /// <summary>
    /// Actions implied by the statement have been permanently halted, before all of them occurred.
    /// </summary>
    public static readonly Coding Stopped = new Coding
    {
      Code = "stopped",
      Display = "Stopped",
      System = "http://hl7.org/fhir/device-usage-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: DeviceUsageStatusActive
    /// </summary>
    public const string LiteralDeviceUsageStatusActive = "http://hl7.org/fhir/device-usage-status#active";

    /// <summary>
    /// Literal for code: Completed
    /// </summary>
    public const string LiteralCompleted = "completed";

    /// <summary>
    /// Literal for code: DeviceUsageStatusCompleted
    /// </summary>
    public const string LiteralDeviceUsageStatusCompleted = "http://hl7.org/fhir/device-usage-status#completed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: DeviceUsageStatusEnteredInError
    /// </summary>
    public const string LiteralDeviceUsageStatusEnteredInError = "http://hl7.org/fhir/device-usage-status#entered-in-error";

    /// <summary>
    /// Literal for code: Intended
    /// </summary>
    public const string LiteralIntended = "intended";

    /// <summary>
    /// Literal for code: DeviceUsageStatusIntended
    /// </summary>
    public const string LiteralDeviceUsageStatusIntended = "http://hl7.org/fhir/device-usage-status#intended";

    /// <summary>
    /// Literal for code: NotDone
    /// </summary>
    public const string LiteralNotDone = "not-done";

    /// <summary>
    /// Literal for code: DeviceUsageStatusNotDone
    /// </summary>
    public const string LiteralDeviceUsageStatusNotDone = "http://hl7.org/fhir/device-usage-status#not-done";

    /// <summary>
    /// Literal for code: OnHold
    /// </summary>
    public const string LiteralOnHold = "on-hold";

    /// <summary>
    /// Literal for code: DeviceUsageStatusOnHold
    /// </summary>
    public const string LiteralDeviceUsageStatusOnHold = "http://hl7.org/fhir/device-usage-status#on-hold";

    /// <summary>
    /// Literal for code: Stopped
    /// </summary>
    public const string LiteralStopped = "stopped";

    /// <summary>
    /// Literal for code: DeviceUsageStatusStopped
    /// </summary>
    public const string LiteralDeviceUsageStatusStopped = "http://hl7.org/fhir/device-usage-status#stopped";

    /// <summary>
    /// Dictionary for looking up DeviceUsageStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/device-usage-status#active", Active }, 
      { "completed", Completed }, 
      { "http://hl7.org/fhir/device-usage-status#completed", Completed }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/device-usage-status#entered-in-error", EnteredInError }, 
      { "intended", Intended }, 
      { "http://hl7.org/fhir/device-usage-status#intended", Intended }, 
      { "not-done", NotDone }, 
      { "http://hl7.org/fhir/device-usage-status#not-done", NotDone }, 
      { "on-hold", OnHold }, 
      { "http://hl7.org/fhir/device-usage-status#on-hold", OnHold }, 
      { "stopped", Stopped }, 
      { "http://hl7.org/fhir/device-usage-status#stopped", Stopped }, 
    };
  };
}