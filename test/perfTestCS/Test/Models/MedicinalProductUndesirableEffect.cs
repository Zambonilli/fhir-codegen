// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.R4.ValueSets;
using Fhir.R4.Serialization;

namespace Fhir.R4.Models
{
  /// <summary>
  /// Describe the undesirable effects of the medicinal product.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<MedicinalProductUndesirableEffect>))]
  public class MedicinalProductUndesirableEffect : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "MedicinalProductUndesirableEffect";
    /// <summary>
    /// Classification of the effect.
    /// </summary>
    public CodeableConcept Classification { get; set; }
    /// <summary>
    /// The frequency of occurrence of the effect.
    /// </summary>
    public CodeableConcept FrequencyOfOccurrence { get; set; }
    /// <summary>
    /// The population group to which this applies.
    /// </summary>
    public List<Population> Population { get; set; }
    /// <summary>
    /// The medication for which this is an indication.
    /// </summary>
    public List<Reference> Subject { get; set; }
    /// <summary>
    /// The symptom, condition or undesirable effect.
    /// </summary>
    public CodeableConcept SymptomConditionEffect { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(ref Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((Fhir.R4.Models.DomainResource)this).SerializeJson(ref writer, options, false);

      if ((Subject != null) && (Subject.Count != 0))
      {
        writer.WritePropertyName("subject");
        writer.WriteStartArray();

        foreach (Reference valSubject in Subject)
        {
          valSubject.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (SymptomConditionEffect != null)
      {
        writer.WritePropertyName("symptomConditionEffect");
        SymptomConditionEffect.SerializeJson(ref writer, options);
      }

      if (Classification != null)
      {
        writer.WritePropertyName("classification");
        Classification.SerializeJson(ref writer, options);
      }

      if (FrequencyOfOccurrence != null)
      {
        writer.WritePropertyName("frequencyOfOccurrence");
        FrequencyOfOccurrence.SerializeJson(ref writer, options);
      }

      if ((Population != null) && (Population.Count != 0))
      {
        writer.WritePropertyName("population");
        writer.WriteStartArray();

        foreach (Population valPopulation in Population)
        {
          valPopulation.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
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
        case "classification":
          Classification = new Fhir.R4.Models.CodeableConcept();
          Classification.DeserializeJson(ref reader, options);
          break;

        case "frequencyOfOccurrence":
          FrequencyOfOccurrence = new Fhir.R4.Models.CodeableConcept();
          FrequencyOfOccurrence.DeserializeJson(ref reader, options);
          break;

        case "population":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Population = new List<Population>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Population objPopulation = new Fhir.R4.Models.Population();
            objPopulation.DeserializeJson(ref reader, options);
            Population.Add(objPopulation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Population.Count == 0)
          {
            Population = null;
          }

          break;

        case "subject":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Subject = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objSubject = new Fhir.R4.Models.Reference();
            objSubject.DeserializeJson(ref reader, options);
            Subject.Add(objSubject);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Subject.Count == 0)
          {
            Subject = null;
          }

          break;

        case "symptomConditionEffect":
          SymptomConditionEffect = new Fhir.R4.Models.CodeableConcept();
          SymptomConditionEffect.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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