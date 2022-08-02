// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR2.Serialization;

namespace fhirCsR2.Models
{
  /// <summary>
  /// A slot of time on a schedule that may be available for booking appointments.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<Slot>))]
  public class Slot : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Slot";
    /// <summary>
    /// Comments on the slot to describe any extended information. Such as custom constraints on the slot.
    /// </summary>
    public string Comment { get; set; }
    /// <summary>
    /// Extension container element for Comment
    /// </summary>
    public Element _Comment { get; set; }
    /// <summary>
    /// Date/Time that the slot is to conclude.
    /// </summary>
    public string End { get; set; }
    /// <summary>
    /// Extension container element for End
    /// </summary>
    public Element _End { get; set; }
    /// <summary>
    /// busy | free | busy-unavailable | busy-tentative.
    /// </summary>
    public string FreeBusyType { get; set; }
    /// <summary>
    /// Extension container element for FreeBusyType
    /// </summary>
    public Element _FreeBusyType { get; set; }
    /// <summary>
    /// External Ids for this item.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// This slot has already been overbooked, appointments are unlikely to be accepted for this time.
    /// </summary>
    public bool? Overbooked { get; set; }
    /// <summary>
    /// Extension container element for Overbooked
    /// </summary>
    public Element _Overbooked { get; set; }
    /// <summary>
    /// The schedule resource that this slot defines an interval of status information.
    /// </summary>
    public Reference Schedule { get; set; }
    /// <summary>
    /// Date/Time that the slot is to begin.
    /// </summary>
    public string Start { get; set; }
    /// <summary>
    /// Extension container element for Start
    /// </summary>
    public Element _Start { get; set; }
    /// <summary>
    /// The type of appointments that can be booked into this slot (ideally this would be an identifiable service - which is at a location, rather than the location itself). If provided then this overrides the value provided on the availability resource.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR2.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Schedule != null)
      {
        writer.WritePropertyName("schedule");
        Schedule.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(FreeBusyType))
      {
        writer.WriteString("freeBusyType", (string)FreeBusyType!);
      }

      if (_FreeBusyType != null)
      {
        writer.WritePropertyName("_freeBusyType");
        _FreeBusyType.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Start))
      {
        writer.WriteString("start", (string)Start!);
      }

      if (_Start != null)
      {
        writer.WritePropertyName("_start");
        _Start.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(End))
      {
        writer.WriteString("end", (string)End!);
      }

      if (_End != null)
      {
        writer.WritePropertyName("_end");
        _End.SerializeJson(writer, options);
      }

      if (Overbooked != null)
      {
        writer.WriteBoolean("overbooked", (bool)Overbooked!);
      }

      if (_Overbooked != null)
      {
        writer.WritePropertyName("_overbooked");
        _Overbooked.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Comment))
      {
        writer.WriteString("comment", (string)Comment!);
      }

      if (_Comment != null)
      {
        writer.WritePropertyName("_comment");
        _Comment.SerializeJson(writer, options);
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
        case "comment":
          Comment = reader.GetString();
          break;

        case "_comment":
          _Comment = new fhirCsR2.Models.Element();
          _Comment.DeserializeJson(ref reader, options);
          break;

        case "end":
          End = reader.GetString();
          break;

        case "_end":
          _End = new fhirCsR2.Models.Element();
          _End.DeserializeJson(ref reader, options);
          break;

        case "freeBusyType":
          FreeBusyType = reader.GetString();
          break;

        case "_freeBusyType":
          _FreeBusyType = new fhirCsR2.Models.Element();
          _FreeBusyType.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Identifier objIdentifier = new fhirCsR2.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "overbooked":
          Overbooked = reader.GetBoolean();
          break;

        case "_overbooked":
          _Overbooked = new fhirCsR2.Models.Element();
          _Overbooked.DeserializeJson(ref reader, options);
          break;

        case "schedule":
          Schedule = new fhirCsR2.Models.Reference();
          Schedule.DeserializeJson(ref reader, options);
          break;

        case "start":
          Start = reader.GetString();
          break;

        case "_start":
          _Start = new fhirCsR2.Models.Element();
          _Start.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR2.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// <summary>
  /// Code Values for the Slot.freeBusyType field
  /// </summary>
  public static class SlotFreeBusyTypeCodes {
    public const string BUSY = "busy";
    public const string FREE = "free";
    public const string BUSY_UNAVAILABLE = "busy-unavailable";
    public const string BUSY_TENTATIVE = "busy-tentative";
    public static HashSet<string> Values = new HashSet<string>() {
      "busy",
      "free",
      "busy-unavailable",
      "busy-tentative",
    };
  }
}