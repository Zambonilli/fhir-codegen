// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR3.Serialization;

namespace fhirCsR3.Models
{
  /// <summary>
  /// A reference from one resource to another.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<Reference>))]
  public class Reference : Element,  IFhirJsonSerializable {
    /// <summary>
    /// This is generally not the same as the Resource.text of the referenced resource.  The purpose is to identify what's being referenced, not to fully describe it.
    /// </summary>
    public string Display { get; set; }
    /// <summary>
    /// Extension container element for Display
    /// </summary>
    public Element _Display { get; set; }
    /// <summary>
    /// When an identifier is provided in place of a reference, any system processing the reference will only be able to resolve the identifier to a reference if it understands the business context in which the identifier is used. Sometimes this is global (e.g. a national identifier) but often it is not. For this reason, none of the useful mechanisms described for working with references (e.g. chaining, includes) are possible, nor should servers be expected to be able resolve the reference. Servers may accept an identifier based reference untouched, resolve it, and/or reject it - see CapabilityStatement.rest.resource.referencePolicy. 
    /// When both an identifier and a literal reference are provided, the literal reference is preferred. Applications processing the resource are allowed - but not required - to check that the identifier matches the literal reference
    /// Applications converting a logical reference to a literal reference may choose to leave the logical reference present, or remove it.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// Using absolute URLs provides a stable scalable approach suitable for a cloud/web context, while using relative/logical references provides a flexible approach suitable for use when trading across closed eco-system boundaries.   Absolute URLs do not need to point to a FHIR RESTful server, though this is the preferred approach. If the URL conforms to the structure "/[type]/[id]" then it should be assumed that the reference is to a FHIR RESTful server.
    /// </summary>
    public string ReferenceField { get; set; }
    /// <summary>
    /// Extension container element for Reference
    /// </summary>
    public Element _ReferenceField { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.Element)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(ReferenceField))
      {
        writer.WriteString("reference", (string)ReferenceField!);
      }

      if (_ReferenceField != null)
      {
        writer.WritePropertyName("_reference");
        _ReferenceField.SerializeJson(writer, options);
      }

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Display))
      {
        writer.WriteString("display", (string)Display!);
      }

      if (_Display != null)
      {
        writer.WritePropertyName("_display");
        _Display.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "display":
          Display = reader.GetString();
          break;

        case "_display":
          _Display = new fhirCsR3.Models.Element();
          _Display.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new fhirCsR3.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "reference":
          ReferenceField = reader.GetString();
          break;

        case "_reference":
          _ReferenceField = new fhirCsR3.Models.Element();
          _ReferenceField.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}