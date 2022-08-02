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
  /// Indicates who or what performed the event.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ImmunizationPractitioner>))]
  public class ImmunizationPractitioner : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The device, practitioner, etc. who performed the action.
    /// </summary>
    public Reference Actor { get; set; }
    /// <summary>
    /// Describes the type of performance (e.g. ordering provider, administering provider, etc.).
    /// </summary>
    public CodeableConcept Role { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Role != null)
      {
        writer.WritePropertyName("role");
        Role.SerializeJson(writer, options);
      }

      if (Actor != null)
      {
        writer.WritePropertyName("actor");
        Actor.SerializeJson(writer, options);
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
        case "actor":
          Actor = new fhirCsR3.Models.Reference();
          Actor.DeserializeJson(ref reader, options);
          break;

        case "role":
          Role = new fhirCsR3.Models.CodeableConcept();
          Role.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Reasons why a vaccine was or was not administered.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ImmunizationExplanation>))]
  public class ImmunizationExplanation : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Reasons why a vaccine was administered.
    /// </summary>
    public List<CodeableConcept> Reason { get; set; }
    /// <summary>
    /// Reason why a vaccine was not administered.
    /// </summary>
    public List<CodeableConcept> ReasonNotGiven { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if ((Reason != null) && (Reason.Count != 0))
      {
        writer.WritePropertyName("reason");
        writer.WriteStartArray();

        foreach (CodeableConcept valReason in Reason)
        {
          valReason.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ReasonNotGiven != null) && (ReasonNotGiven.Count != 0))
      {
        writer.WritePropertyName("reasonNotGiven");
        writer.WriteStartArray();

        foreach (CodeableConcept valReasonNotGiven in ReasonNotGiven)
        {
          valReasonNotGiven.SerializeJson(writer, options, true);
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
        case "reason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reason = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objReason = new fhirCsR3.Models.CodeableConcept();
            objReason.DeserializeJson(ref reader, options);
            Reason.Add(objReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reason.Count == 0)
          {
            Reason = null;
          }

          break;

        case "reasonNotGiven":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReasonNotGiven = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objReasonNotGiven = new fhirCsR3.Models.CodeableConcept();
            objReasonNotGiven.DeserializeJson(ref reader, options);
            ReasonNotGiven.Add(objReasonNotGiven);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReasonNotGiven.Count == 0)
          {
            ReasonNotGiven = null;
          }

          break;

        default:
          ((fhirCsR3.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// A reaction may be an indication of an allergy or intolerance and, if this is determined to be the case,  it should be recorded as a new [AllergyIntolerance](allergyintolerance.html) resource instance as most systems will not query against  past Immunization.reaction elements.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ImmunizationReaction>))]
  public class ImmunizationReaction : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Date of reaction to the immunization.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// Details of the reaction.
    /// </summary>
    public Reference Detail { get; set; }
    /// <summary>
    /// Self-reported indicator.
    /// </summary>
    public bool? Reported { get; set; }
    /// <summary>
    /// Extension container element for Reported
    /// </summary>
    public Element _Reported { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (Detail != null)
      {
        writer.WritePropertyName("detail");
        Detail.SerializeJson(writer, options);
      }

      if (Reported != null)
      {
        writer.WriteBoolean("reported", (bool)Reported!);
      }

      if (_Reported != null)
      {
        writer.WritePropertyName("_reported");
        _Reported.SerializeJson(writer, options);
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
        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR3.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "detail":
          Detail = new fhirCsR3.Models.Reference();
          Detail.DeserializeJson(ref reader, options);
          break;

        case "reported":
          Reported = reader.GetBoolean();
          break;

        case "_reported":
          _Reported = new fhirCsR3.Models.Element();
          _Reported.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Contains information about the protocol(s) under which the vaccine was administered.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<ImmunizationVaccinationProtocol>))]
  public class ImmunizationVaccinationProtocol : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Indicates the authority who published the protocol.  E.g. ACIP.
    /// </summary>
    public Reference Authority { get; set; }
    /// <summary>
    /// Contains the description about the protocol under which the vaccine was administered.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Nominal position in a series.
    /// </summary>
    public uint? DoseSequence { get; set; }
    /// <summary>
    /// May need to differentiate between status declarations by a provider vs. a CDS engine.
    /// </summary>
    public CodeableConcept DoseStatus { get; set; }
    /// <summary>
    /// Provides an explanation as to why an immunization event should or should not count against the protocol.
    /// </summary>
    public CodeableConcept DoseStatusReason { get; set; }
    /// <summary>
    /// One possible path to achieve presumed immunity against a disease - within the context of an authority.
    /// </summary>
    public string Series { get; set; }
    /// <summary>
    /// Extension container element for Series
    /// </summary>
    public Element _Series { get; set; }
    /// <summary>
    /// The recommended number of doses to achieve immunity.
    /// </summary>
    public uint? SeriesDoses { get; set; }
    /// <summary>
    /// The targeted disease.
    /// </summary>
    public List<CodeableConcept> TargetDisease { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (DoseSequence != null)
      {
        writer.WriteNumber("doseSequence", (uint)DoseSequence!);
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
      }

      if (Authority != null)
      {
        writer.WritePropertyName("authority");
        Authority.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Series))
      {
        writer.WriteString("series", (string)Series!);
      }

      if (_Series != null)
      {
        writer.WritePropertyName("_series");
        _Series.SerializeJson(writer, options);
      }

      if (SeriesDoses != null)
      {
        writer.WriteNumber("seriesDoses", (uint)SeriesDoses!);
      }

      if ((TargetDisease != null) && (TargetDisease.Count != 0))
      {
        writer.WritePropertyName("targetDisease");
        writer.WriteStartArray();

        foreach (CodeableConcept valTargetDisease in TargetDisease)
        {
          valTargetDisease.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (DoseStatus != null)
      {
        writer.WritePropertyName("doseStatus");
        DoseStatus.SerializeJson(writer, options);
      }

      if (DoseStatusReason != null)
      {
        writer.WritePropertyName("doseStatusReason");
        DoseStatusReason.SerializeJson(writer, options);
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
        case "authority":
          Authority = new fhirCsR3.Models.Reference();
          Authority.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new fhirCsR3.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "doseSequence":
          DoseSequence = reader.GetUInt32();
          break;

        case "doseStatus":
          DoseStatus = new fhirCsR3.Models.CodeableConcept();
          DoseStatus.DeserializeJson(ref reader, options);
          break;

        case "doseStatusReason":
          DoseStatusReason = new fhirCsR3.Models.CodeableConcept();
          DoseStatusReason.DeserializeJson(ref reader, options);
          break;

        case "series":
          Series = reader.GetString();
          break;

        case "_series":
          _Series = new fhirCsR3.Models.Element();
          _Series.DeserializeJson(ref reader, options);
          break;

        case "seriesDoses":
          SeriesDoses = reader.GetUInt32();
          break;

        case "targetDisease":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          TargetDisease = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.CodeableConcept objTargetDisease = new fhirCsR3.Models.CodeableConcept();
            objTargetDisease.DeserializeJson(ref reader, options);
            TargetDisease.Add(objTargetDisease);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (TargetDisease.Count == 0)
          {
            TargetDisease = null;
          }

          break;

        default:
          ((fhirCsR3.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Describes the event of a patient being administered a vaccination or a record of a vaccination as reported by a patient, a clinician or another party and may include vaccine reaction information and what vaccination protocol was followed.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<Immunization>))]
  public class Immunization : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Immunization";
    /// <summary>
    /// When immunizations are given a specific date and time should always be known.   When immunizations are patient reported, a specific date might not be known.  Although partial dates are allowed, an adult patient might not be able to recall the year a childhood immunization was given.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// The quantity of vaccine product that was administered.
    /// </summary>
    public Quantity DoseQuantity { get; set; }
    /// <summary>
    /// The visit or admission or other contact between patient and health care provider the immunization was performed as part of.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// Date vaccine batch expires.
    /// </summary>
    public string ExpirationDate { get; set; }
    /// <summary>
    /// Extension container element for ExpirationDate
    /// </summary>
    public Element _ExpirationDate { get; set; }
    /// <summary>
    /// Reasons why a vaccine was or was not administered.
    /// </summary>
    public ImmunizationExplanation Explanation { get; set; }
    /// <summary>
    /// A unique identifier assigned to this immunization record.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The service delivery location where the vaccine administration occurred.
    /// </summary>
    public Reference Location { get; set; }
    /// <summary>
    /// Lot number of the  vaccine product.
    /// </summary>
    public string LotNumber { get; set; }
    /// <summary>
    /// Extension container element for LotNumber
    /// </summary>
    public Element _LotNumber { get; set; }
    /// <summary>
    /// Name of vaccine manufacturer.
    /// </summary>
    public Reference Manufacturer { get; set; }
    /// <summary>
    /// Extra information about the immunization that is not conveyed by the other attributes.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because it indicates that an immunization didn't happen.
    /// </summary>
    public bool NotGiven { get; set; }
    /// <summary>
    /// Extension container element for NotGiven
    /// </summary>
    public Element _NotGiven { get; set; }
    /// <summary>
    /// The patient who either received or did not receive the immunization.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// Indicates who or what performed the event.
    /// </summary>
    public List<ImmunizationPractitioner> Practitioner { get; set; }
    /// <summary>
    /// Reflects the “reliability” of the content.
    /// </summary>
    public bool PrimarySource { get; set; }
    /// <summary>
    /// Extension container element for PrimarySource
    /// </summary>
    public Element _PrimarySource { get; set; }
    /// <summary>
    /// A reaction may be an indication of an allergy or intolerance and, if this is determined to be the case,  it should be recorded as a new [AllergyIntolerance](allergyintolerance.html) resource instance as most systems will not query against  past Immunization.reaction elements.
    /// </summary>
    public List<ImmunizationReaction> Reaction { get; set; }
    /// <summary>
    /// Should not be populated if primarySource = True, will not be required even if primarySource = False.
    /// </summary>
    public CodeableConcept ReportOrigin { get; set; }
    /// <summary>
    /// The path by which the vaccine product is taken into the body.
    /// </summary>
    public CodeableConcept Route { get; set; }
    /// <summary>
    /// Body site where vaccine was administered.
    /// </summary>
    public CodeableConcept Site { get; set; }
    /// <summary>
    /// Will generally be set to show that the immunization has been completed.
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Contains information about the protocol(s) under which the vaccine was administered.
    /// </summary>
    public List<ImmunizationVaccinationProtocol> VaccinationProtocol { get; set; }
    /// <summary>
    /// Vaccine that was administered or was to be administered.
    /// </summary>
    public CodeableConcept VaccineCode { get; set; }
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


      ((fhirCsR3.Models.DomainResource)this).SerializeJson(writer, options, false);

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

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      writer.WriteBoolean("notGiven", NotGiven);

      if (_NotGiven != null)
      {
        writer.WritePropertyName("_notGiven");
        _NotGiven.SerializeJson(writer, options);
      }

      if (VaccineCode != null)
      {
        writer.WritePropertyName("vaccineCode");
        VaccineCode.SerializeJson(writer, options);
      }

      if (Patient != null)
      {
        writer.WritePropertyName("patient");
        Patient.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      writer.WriteBoolean("primarySource", PrimarySource);

      if (_PrimarySource != null)
      {
        writer.WritePropertyName("_primarySource");
        _PrimarySource.SerializeJson(writer, options);
      }

      if (ReportOrigin != null)
      {
        writer.WritePropertyName("reportOrigin");
        ReportOrigin.SerializeJson(writer, options);
      }

      if (Location != null)
      {
        writer.WritePropertyName("location");
        Location.SerializeJson(writer, options);
      }

      if (Manufacturer != null)
      {
        writer.WritePropertyName("manufacturer");
        Manufacturer.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(LotNumber))
      {
        writer.WriteString("lotNumber", (string)LotNumber!);
      }

      if (_LotNumber != null)
      {
        writer.WritePropertyName("_lotNumber");
        _LotNumber.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ExpirationDate))
      {
        writer.WriteString("expirationDate", (string)ExpirationDate!);
      }

      if (_ExpirationDate != null)
      {
        writer.WritePropertyName("_expirationDate");
        _ExpirationDate.SerializeJson(writer, options);
      }

      if (Site != null)
      {
        writer.WritePropertyName("site");
        Site.SerializeJson(writer, options);
      }

      if (Route != null)
      {
        writer.WritePropertyName("route");
        Route.SerializeJson(writer, options);
      }

      if (DoseQuantity != null)
      {
        writer.WritePropertyName("doseQuantity");
        DoseQuantity.SerializeJson(writer, options);
      }

      if ((Practitioner != null) && (Practitioner.Count != 0))
      {
        writer.WritePropertyName("practitioner");
        writer.WriteStartArray();

        foreach (ImmunizationPractitioner valPractitioner in Practitioner)
        {
          valPractitioner.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (Annotation valNote in Note)
        {
          valNote.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Explanation != null)
      {
        writer.WritePropertyName("explanation");
        Explanation.SerializeJson(writer, options);
      }

      if ((Reaction != null) && (Reaction.Count != 0))
      {
        writer.WritePropertyName("reaction");
        writer.WriteStartArray();

        foreach (ImmunizationReaction valReaction in Reaction)
        {
          valReaction.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((VaccinationProtocol != null) && (VaccinationProtocol.Count != 0))
      {
        writer.WritePropertyName("vaccinationProtocol");
        writer.WriteStartArray();

        foreach (ImmunizationVaccinationProtocol valVaccinationProtocol in VaccinationProtocol)
        {
          valVaccinationProtocol.SerializeJson(writer, options, true);
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
        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR3.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "doseQuantity":
          DoseQuantity = new fhirCsR3.Models.Quantity();
          DoseQuantity.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR3.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "expirationDate":
          ExpirationDate = reader.GetString();
          break;

        case "_expirationDate":
          _ExpirationDate = new fhirCsR3.Models.Element();
          _ExpirationDate.DeserializeJson(ref reader, options);
          break;

        case "explanation":
          Explanation = new fhirCsR3.Models.ImmunizationExplanation();
          Explanation.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Identifier objIdentifier = new fhirCsR3.Models.Identifier();
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

        case "location":
          Location = new fhirCsR3.Models.Reference();
          Location.DeserializeJson(ref reader, options);
          break;

        case "lotNumber":
          LotNumber = reader.GetString();
          break;

        case "_lotNumber":
          _LotNumber = new fhirCsR3.Models.Element();
          _LotNumber.DeserializeJson(ref reader, options);
          break;

        case "manufacturer":
          Manufacturer = new fhirCsR3.Models.Reference();
          Manufacturer.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Annotation objNote = new fhirCsR3.Models.Annotation();
            objNote.DeserializeJson(ref reader, options);
            Note.Add(objNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Note.Count == 0)
          {
            Note = null;
          }

          break;

        case "notGiven":
          NotGiven = reader.GetBoolean();
          break;

        case "_notGiven":
          _NotGiven = new fhirCsR3.Models.Element();
          _NotGiven.DeserializeJson(ref reader, options);
          break;

        case "patient":
          Patient = new fhirCsR3.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "practitioner":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Practitioner = new List<ImmunizationPractitioner>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ImmunizationPractitioner objPractitioner = new fhirCsR3.Models.ImmunizationPractitioner();
            objPractitioner.DeserializeJson(ref reader, options);
            Practitioner.Add(objPractitioner);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Practitioner.Count == 0)
          {
            Practitioner = null;
          }

          break;

        case "primarySource":
          PrimarySource = reader.GetBoolean();
          break;

        case "_primarySource":
          _PrimarySource = new fhirCsR3.Models.Element();
          _PrimarySource.DeserializeJson(ref reader, options);
          break;

        case "reaction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reaction = new List<ImmunizationReaction>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ImmunizationReaction objReaction = new fhirCsR3.Models.ImmunizationReaction();
            objReaction.DeserializeJson(ref reader, options);
            Reaction.Add(objReaction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reaction.Count == 0)
          {
            Reaction = null;
          }

          break;

        case "reportOrigin":
          ReportOrigin = new fhirCsR3.Models.CodeableConcept();
          ReportOrigin.DeserializeJson(ref reader, options);
          break;

        case "route":
          Route = new fhirCsR3.Models.CodeableConcept();
          Route.DeserializeJson(ref reader, options);
          break;

        case "site":
          Site = new fhirCsR3.Models.CodeableConcept();
          Site.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR3.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "vaccinationProtocol":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          VaccinationProtocol = new List<ImmunizationVaccinationProtocol>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ImmunizationVaccinationProtocol objVaccinationProtocol = new fhirCsR3.Models.ImmunizationVaccinationProtocol();
            objVaccinationProtocol.DeserializeJson(ref reader, options);
            VaccinationProtocol.Add(objVaccinationProtocol);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (VaccinationProtocol.Count == 0)
          {
            VaccinationProtocol = null;
          }

          break;

        case "vaccineCode":
          VaccineCode = new fhirCsR3.Models.CodeableConcept();
          VaccineCode.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the Immunization.status field
  /// </summary>
  public static class ImmunizationStatusCodes {
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public static HashSet<string> Values = new HashSet<string>() {
      "completed",
      "entered-in-error",
    };
  }
}