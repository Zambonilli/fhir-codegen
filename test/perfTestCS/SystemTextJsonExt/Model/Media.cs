// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for Media
  /// </summary>
  public static class MediaJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR Media into JSON
    /// </summary>
    public static void SerializeJson(this Media current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","Media");
      // Complex: Media, Export: Media, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.BasedOn != null) && (current.BasedOn.Count != 0))
      {
        writer.WritePropertyName("basedOn");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.BasedOn)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.PartOf != null) && (current.PartOf.Count != 0))
      {
        writer.WritePropertyName("partOf");
        writer.WriteStartArray();
        foreach (ResourceReference val in current.PartOf)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      writer.WriteString("status",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.StatusElement.Value));

      if (current.Type != null)
      {
        writer.WritePropertyName("type");
        current.Type.SerializeJson(writer, options);
      }

      if (current.Modality != null)
      {
        writer.WritePropertyName("modality");
        current.Modality.SerializeJson(writer, options);
      }

      if (current.View != null)
      {
        writer.WritePropertyName("view");
        current.View.SerializeJson(writer, options);
      }

      if (current.Subject != null)
      {
        writer.WritePropertyName("subject");
        current.Subject.SerializeJson(writer, options);
      }

      if (current.Encounter != null)
      {
        writer.WritePropertyName("encounter");
        current.Encounter.SerializeJson(writer, options);
      }

      if (current.Created != null)
      {
        switch (current.Created)
        {
          case FhirDateTime v_FhirDateTime:
            writer.WriteString("createdDateTime",v_FhirDateTime.Value);
            break;
          case Period v_Period:
            writer.WritePropertyName("createdPeriod");
            v_Period.SerializeJson(writer, options);
            break;
        }
      }
      if ((current.IssuedElement != null) && (current.IssuedElement.Value != null))
      {
        writer.WriteString("issued",((DateTimeOffset)current.IssuedElement.Value).ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFFFK", System.Globalization.CultureInfo.InvariantCulture));
      }

      if (current.Operator != null)
      {
        writer.WritePropertyName("operator");
        current.Operator.SerializeJson(writer, options);
      }

      if ((current.ReasonCode != null) && (current.ReasonCode.Count != 0))
      {
        writer.WritePropertyName("reasonCode");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.ReasonCode)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.BodySite != null)
      {
        writer.WritePropertyName("bodySite");
        current.BodySite.SerializeJson(writer, options);
      }

      if ((current.DeviceNameElement != null) && (current.DeviceNameElement.Value != null))
      {
        writer.WriteString("deviceName",current.DeviceNameElement.Value);
      }

      if (current.Device != null)
      {
        writer.WritePropertyName("device");
        current.Device.SerializeJson(writer, options);
      }

      if ((current.HeightElement != null) && (current.HeightElement.Value != null))
      {
        writer.WriteNumber("height",(int)current.HeightElement.Value);
      }

      if ((current.WidthElement != null) && (current.WidthElement.Value != null))
      {
        writer.WriteNumber("width",(int)current.WidthElement.Value);
      }

      if ((current.FramesElement != null) && (current.FramesElement.Value != null))
      {
        writer.WriteNumber("frames",(int)current.FramesElement.Value);
      }

      if ((current.DurationElement != null) && (current.DurationElement.Value != null))
      {
        writer.WriteNumber("duration",(decimal)current.DurationElement.Value);
      }

      writer.WritePropertyName("content");
      current.Content.SerializeJson(writer, options);

      if ((current.Note != null) && (current.Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();
        foreach (Annotation val in current.Note)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Media
    /// </summary>
    public static void DeserializeJson(this Media current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }

    /// <summary>
    /// Deserialize JSON into a FHIR Media
    /// </summary>
    public static void DeserializeJsonProperty(this Media current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "basedOn":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.BasedOn = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_BasedOn = new Hl7.Fhir.Model.ResourceReference();
            v_BasedOn.DeserializeJson(ref reader, options);
            current.BasedOn.Add(v_BasedOn);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.BasedOn.Count == 0)
          {
            current.BasedOn = null;
          }
          break;

        case "partOf":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.PartOf = new List<ResourceReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ResourceReference v_PartOf = new Hl7.Fhir.Model.ResourceReference();
            v_PartOf.DeserializeJson(ref reader, options);
            current.PartOf.Add(v_PartOf);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.PartOf.Count == 0)
          {
            current.PartOf = null;
          }
          break;

        case "status":
          current.StatusElement =new Code<Hl7.Fhir.Model.EventStatus>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.EventStatus>(reader.GetString()));
          break;

        case "type":
          current.Type = new Hl7.Fhir.Model.CodeableConcept();
          current.Type.DeserializeJson(ref reader, options);
          break;

        case "modality":
          current.Modality = new Hl7.Fhir.Model.CodeableConcept();
          current.Modality.DeserializeJson(ref reader, options);
          break;

        case "view":
          current.View = new Hl7.Fhir.Model.CodeableConcept();
          current.View.DeserializeJson(ref reader, options);
          break;

        case "subject":
          current.Subject = new Hl7.Fhir.Model.ResourceReference();
          current.Subject.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          current.Encounter = new Hl7.Fhir.Model.ResourceReference();
          current.Encounter.DeserializeJson(ref reader, options);
          break;

        case "createdDateTime":
          current.Created = new FhirDateTime(reader.GetString());
          break;

        case "createdPeriod":
          current.Created = new Hl7.Fhir.Model.Period();
          current.Created.DeserializeJson(ref reader, options);
          break;

        case "issued":
          current.IssuedElement = new Instant(DateTimeOffset.Parse(reader.GetString()));
          break;

        case "_issued":
          ((Hl7.Fhir.Model.Element)current.IssuedElement).DeserializeJson(ref reader, options);
          break;

        case "operator":
          current.Operator = new Hl7.Fhir.Model.ResourceReference();
          current.Operator.DeserializeJson(ref reader, options);
          break;

        case "reasonCode":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.ReasonCode = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_ReasonCode = new Hl7.Fhir.Model.CodeableConcept();
            v_ReasonCode.DeserializeJson(ref reader, options);
            current.ReasonCode.Add(v_ReasonCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.ReasonCode.Count == 0)
          {
            current.ReasonCode = null;
          }
          break;

        case "bodySite":
          current.BodySite = new Hl7.Fhir.Model.CodeableConcept();
          current.BodySite.DeserializeJson(ref reader, options);
          break;

        case "deviceName":
          current.DeviceNameElement = new FhirString(reader.GetString());
          break;

        case "device":
          current.Device = new Hl7.Fhir.Model.ResourceReference();
          current.Device.DeserializeJson(ref reader, options);
          break;

        case "height":
          current.HeightElement = new PositiveInt(reader.GetInt32());
          break;

        case "width":
          current.WidthElement = new PositiveInt(reader.GetInt32());
          break;

        case "frames":
          current.FramesElement = new PositiveInt(reader.GetInt32());
          break;

        case "duration":
          current.DurationElement = new FhirDecimal(reader.GetDecimal());
          break;

        case "content":
          current.Content = new Hl7.Fhir.Model.Attachment();
          current.Content.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          current.Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Annotation v_Note = new Hl7.Fhir.Model.Annotation();
            v_Note.DeserializeJson(ref reader, options);
            current.Note.Add(v_Note);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Note.Count == 0)
          {
            current.Note = null;
          }
          break;

        // Complex: Media, Export: Media, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class MediaJsonConverter : JsonConverter<Media>
    {
      /// <summary>
      /// Determines whether the specified type can be converted.
      /// </summary>
      public override bool CanConvert(Type objectType) =>
        typeof(Media).IsAssignableFrom(objectType);

      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, Media value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override Media Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        Media target = new Media();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file