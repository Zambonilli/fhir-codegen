// <auto-generated/>
// Contents of: hl7.fhir.r5.core version: 5.0.0-ballot

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

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

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// Virtual Service Contact Details
  /// </summary>
  [FhirType("VirtualServiceDetail")]
  [DataContract]
  public partial class VirtualServiceDetail : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    [NotMapped]
    public override string TypeName { get { return "VirtualServiceDetail"; } }

    /// <summary>
    /// Channel Type
    /// </summary>
    [FhirElement("channelType", InSummary=true, Order=30)]
    [DataMember]
    public Hl7.Fhir.Model.Coding ChannelType
    {
      get { return _ChannelType; }
      set { _ChannelType = value; OnPropertyChanged("ChannelType"); }
    }

    private Hl7.Fhir.Model.Coding _ChannelType;

    /// <summary>
    /// Contact address/number
    /// </summary>
    [FhirElement("address", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.FhirUrl),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.ContactPoint),typeof(Hl7.Fhir.Model.ExtendedContactDetail))]
    [DataMember]
    public Hl7.Fhir.Model.Element Address
    {
      get { return _Address; }
      set { _Address = value; OnPropertyChanged("Address"); }
    }

    private Hl7.Fhir.Model.Element _Address;

    /// <summary>
    /// Address to see alternative connection details
    /// </summary>
    [FhirElement("additionalInfo", InSummary=true, Order=50)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.FhirUrl> AdditionalInfoElement
    {
      get { if(_AdditionalInfoElement==null) _AdditionalInfoElement = new List<Hl7.Fhir.Model.FhirUrl>(); return _AdditionalInfoElement; }
      set { _AdditionalInfoElement = value; OnPropertyChanged("AdditionalInfoElement"); }
    }

    private List<Hl7.Fhir.Model.FhirUrl> _AdditionalInfoElement;

    /// <summary>
    /// Address to see alternative connection details
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [NotMapped]
    [IgnoreDataMemberAttribute]
    public IEnumerable<string> AdditionalInfo
    {
      get { return AdditionalInfoElement != null ? AdditionalInfoElement.Select(elem => elem.Value) : null; }
      set
      {
        if (value == null)
          AdditionalInfoElement = null;
        else
          AdditionalInfoElement = new List<Hl7.Fhir.Model.FhirUrl>(value.Select(elem=>new Hl7.Fhir.Model.FhirUrl(elem)));
        OnPropertyChanged("AdditionalInfo");
      }

    }

    /// <summary>
    /// Maximum number of participants supported by the virtual service
    /// </summary>
    [FhirElement("maxParticipants", InSummary=true, Order=60)]
    [DataMember]
    public Hl7.Fhir.Model.PositiveInt MaxParticipantsElement
    {
      get { return _MaxParticipantsElement; }
      set { _MaxParticipantsElement = value; OnPropertyChanged("MaxParticipantsElement"); }
    }

    private Hl7.Fhir.Model.PositiveInt _MaxParticipantsElement;

    /// <summary>
    /// Maximum number of participants supported by the virtual service
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [NotMapped]
    [IgnoreDataMemberAttribute]
    public int? MaxParticipants
    {
      get { return MaxParticipantsElement != null ? MaxParticipantsElement.Value : null; }
      set
      {
        if (value == null)
          MaxParticipantsElement = null;
        else
          MaxParticipantsElement = new Hl7.Fhir.Model.PositiveInt(value);
        OnPropertyChanged("MaxParticipants");
      }

    }

    /// <summary>
    /// Session Key required by the virtual service
    /// </summary>
    [FhirElement("sessionKey", InSummary=true, Order=70)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString SessionKeyElement
    {
      get { return _SessionKeyElement; }
      set { _SessionKeyElement = value; OnPropertyChanged("SessionKeyElement"); }
    }

    private Hl7.Fhir.Model.FhirString _SessionKeyElement;

    /// <summary>
    /// Session Key required by the virtual service
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [NotMapped]
    [IgnoreDataMemberAttribute]
    public string SessionKey
    {
      get { return SessionKeyElement != null ? SessionKeyElement.Value : null; }
      set
      {
        if (value == null)
          SessionKeyElement = null;
        else
          SessionKeyElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("SessionKey");
      }

    }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as VirtualServiceDetail;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(ChannelType != null) dest.ChannelType = (Hl7.Fhir.Model.Coding)ChannelType.DeepCopy();
      if(Address != null) dest.Address = (Hl7.Fhir.Model.Element)Address.DeepCopy();
      if(AdditionalInfoElement != null) dest.AdditionalInfoElement = new List<Hl7.Fhir.Model.FhirUrl>(AdditionalInfoElement.DeepCopy());
      if(MaxParticipantsElement != null) dest.MaxParticipantsElement = (Hl7.Fhir.Model.PositiveInt)MaxParticipantsElement.DeepCopy();
      if(SessionKeyElement != null) dest.SessionKeyElement = (Hl7.Fhir.Model.FhirString)SessionKeyElement.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new VirtualServiceDetail());
    }

    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as VirtualServiceDetail;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(ChannelType, otherT.ChannelType)) return false;
      if( !DeepComparable.Matches(Address, otherT.Address)) return false;
      if( !DeepComparable.Matches(AdditionalInfoElement, otherT.AdditionalInfoElement)) return false;
      if( !DeepComparable.Matches(MaxParticipantsElement, otherT.MaxParticipantsElement)) return false;
      if( !DeepComparable.Matches(SessionKeyElement, otherT.SessionKeyElement)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as VirtualServiceDetail;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(ChannelType, otherT.ChannelType)) return false;
      if( !DeepComparable.IsExactly(Address, otherT.Address)) return false;
      if( !DeepComparable.IsExactly(AdditionalInfoElement, otherT.AdditionalInfoElement)) return false;
      if( !DeepComparable.IsExactly(MaxParticipantsElement, otherT.MaxParticipantsElement)) return false;
      if( !DeepComparable.IsExactly(SessionKeyElement, otherT.SessionKeyElement)) return false;

      return true;
    }

    [NotMapped]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (ChannelType != null) yield return ChannelType;
        if (Address != null) yield return Address;
        foreach (var elem in AdditionalInfoElement) { if (elem != null) yield return elem; }
        if (MaxParticipantsElement != null) yield return MaxParticipantsElement;
        if (SessionKeyElement != null) yield return SessionKeyElement;
      }

    }

    [NotMapped]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (ChannelType != null) yield return new ElementValue("channelType", ChannelType);
        if (Address != null) yield return new ElementValue("address", Address);
        foreach (var elem in AdditionalInfoElement) { if (elem != null) yield return new ElementValue("additionalInfo", elem); }
        if (MaxParticipantsElement != null) yield return new ElementValue("maxParticipants", MaxParticipantsElement);
        if (SessionKeyElement != null) yield return new ElementValue("sessionKey", SessionKeyElement);
      }

    }

  }

}

// end of file