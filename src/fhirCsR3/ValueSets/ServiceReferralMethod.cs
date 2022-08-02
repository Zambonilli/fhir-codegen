// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// The methods of referral can be used when referring to a specific HealthCareService resource.
  /// </summary>
  public static class ServiceReferralMethodCodes
  {
    /// <summary>
    /// Referrals may be accepted via a secure messaging system. To determine the types of secure messaging systems supported, refer to the identifiers collection. Callers will need to understand the specific identifier system used to know that they are able to transmit messages.
    /// </summary>
    public static readonly Coding SecureMessaging = new Coding
    {
      Code = "elec",
      Display = "Secure Messaging",
      System = "http://hl7.org/fhir/service-referral-method"
    };
    /// <summary>
    /// Referrals may be accepted by fax.
    /// </summary>
    public static readonly Coding Fax = new Coding
    {
      Code = "fax",
      Display = "Fax",
      System = "http://hl7.org/fhir/service-referral-method"
    };
    /// <summary>
    /// Referrals may be accepted via regular postage (or hand delivered).
    /// </summary>
    public static readonly Coding Mail = new Coding
    {
      Code = "mail",
      Display = "Mail",
      System = "http://hl7.org/fhir/service-referral-method"
    };
    /// <summary>
    /// Referrals may be accepted over the phone from a practitioner.
    /// </summary>
    public static readonly Coding Phone = new Coding
    {
      Code = "phone",
      Display = "Phone",
      System = "http://hl7.org/fhir/service-referral-method"
    };
    /// <summary>
    /// Referrals may be accepted via a secure email. To send please encrypt with the services public key.
    /// </summary>
    public static readonly Coding SecureEmail = new Coding
    {
      Code = "semail",
      Display = "Secure Email",
      System = "http://hl7.org/fhir/service-referral-method"
    };

    /// <summary>
    /// Literal for code: SecureMessaging
    /// </summary>
    public const string LiteralSecureMessaging = "elec";

    /// <summary>
    /// Literal for code: ServiceReferralMethodSecureMessaging
    /// </summary>
    public const string LiteralServiceReferralMethodSecureMessaging = "http://hl7.org/fhir/service-referral-method#elec";

    /// <summary>
    /// Literal for code: Fax
    /// </summary>
    public const string LiteralFax = "fax";

    /// <summary>
    /// Literal for code: ServiceReferralMethodFax
    /// </summary>
    public const string LiteralServiceReferralMethodFax = "http://hl7.org/fhir/service-referral-method#fax";

    /// <summary>
    /// Literal for code: Mail
    /// </summary>
    public const string LiteralMail = "mail";

    /// <summary>
    /// Literal for code: ServiceReferralMethodMail
    /// </summary>
    public const string LiteralServiceReferralMethodMail = "http://hl7.org/fhir/service-referral-method#mail";

    /// <summary>
    /// Literal for code: Phone
    /// </summary>
    public const string LiteralPhone = "phone";

    /// <summary>
    /// Literal for code: ServiceReferralMethodPhone
    /// </summary>
    public const string LiteralServiceReferralMethodPhone = "http://hl7.org/fhir/service-referral-method#phone";

    /// <summary>
    /// Literal for code: SecureEmail
    /// </summary>
    public const string LiteralSecureEmail = "semail";

    /// <summary>
    /// Literal for code: ServiceReferralMethodSecureEmail
    /// </summary>
    public const string LiteralServiceReferralMethodSecureEmail = "http://hl7.org/fhir/service-referral-method#semail";

    /// <summary>
    /// Dictionary for looking up ServiceReferralMethod Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "elec", SecureMessaging }, 
      { "http://hl7.org/fhir/service-referral-method#elec", SecureMessaging }, 
      { "fax", Fax }, 
      { "http://hl7.org/fhir/service-referral-method#fax", Fax }, 
      { "mail", Mail }, 
      { "http://hl7.org/fhir/service-referral-method#mail", Mail }, 
      { "phone", Phone }, 
      { "http://hl7.org/fhir/service-referral-method#phone", Phone }, 
      { "semail", SecureEmail }, 
      { "http://hl7.org/fhir/service-referral-method#semail", SecureEmail }, 
    };
  };
}