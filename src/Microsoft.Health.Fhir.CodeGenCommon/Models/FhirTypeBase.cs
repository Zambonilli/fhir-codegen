﻿// <copyright file="FhirTypeBase.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using Microsoft.Health.Fhir.CodeGenCommon.Extensions;

namespace Microsoft.Health.Fhir.CodeGenCommon.Models;

/// <summary>
/// A base class for FHIR types to inherit from (common properties).
/// </summary>
public abstract class FhirTypeBase
{
    internal readonly string _path;
    internal readonly string _name;
    internal readonly string _nameCapitalized;
    internal string _baseTypeName;
    internal string _baseTypeCanonical;

    /// <summary>Initializes a new instance of the <see cref="FhirTypeBase"/> class.</summary>
    /// <exception cref="ArgumentNullException">Thrown when one or more required arguments are null.</exception>
    /// <param name="rootArtifactClass">The root artifact class.</param>
    /// <param name="id">               The id of this element/resource/datatype/extension.</param>
    /// <param name="name">             The name.</param>
    /// <param name="path">             The dot-notation path to this
    ///  element/resource/datatype/extension.</param>
    /// <param name="baseTypeName">     The name of the base type.</param>
    /// <param name="baseTypeCanonical">The canonical url of the base type.</param>
    /// <param name="url">              The URL.</param>
    /// <param name="shortDescription"> The description.</param>
    /// <param name="purpose">          The purpose of this definition.</param>
    /// <param name="comment">          The comment.</param>
    /// <param name="validationRegEx">  The validation RegEx.</param>
    public FhirTypeBase(
        string id,
        string name,
        string path,
        string baseTypeName,
        string baseTypeCanonical,
        Uri url,
        string shortDescription,
        string purpose,
        string comment,
        string validationRegEx)
    {
        // sanity checks
        if (string.IsNullOrEmpty(id))
        {
            throw new ArgumentNullException(nameof(id));
        }

        // set internal values
        Id = id;
        _path = string.IsNullOrEmpty(path) ? id : path;
        _name = string.IsNullOrEmpty(name) ? _path.Split('.').First() ?? string.Empty : name;
        _nameCapitalized = _name.ToPascalCase();

        _baseTypeName = baseTypeName;
        _baseTypeCanonical = baseTypeCanonical;

        URL = url;

        ShortDescription = shortDescription;
        Purpose = string.IsNullOrEmpty(purpose) ? string.Empty : purpose;
        Comment = string.IsNullOrEmpty(comment) ? Purpose : comment;

        ValidationRegEx = validationRegEx;
    }

    /// <summary>Values that represent naming conventions for item types.</summary>
    public enum NamingConvention
    {
        /// <summary>This feature is not supported / used.</summary>
        None,

        /// <summary>An enum constant representing the language controlled option.</summary>
        LanguageControlled,

        /// <summary>Names are standard FHIR dot notation (e.g., path).</summary>
        FhirDotNotation,

        /// <summary>Names are dot notation, with each first letter capitalized.</summary>
        PascalDotNotation,

        /// <summary>Names are Pascal Case (first letter capitalized).</summary>
        PascalCase,

        /// <summary>Names are Camel Case (first letter lower case).</summary>
        CamelCase,

        /// <summary>Names are all upper case.</summary>
        UpperCase,

        /// <summary>Names are all lower case.</summary>
        LowerCase,

        /// <summary>Lower case, separated by hyphens.</summary>
        LowerKebab,
    }

    /// <summary>Gets the Id for this element/resource/datatype.</summary>
    /// <value>The Id for this element/resource/datatype.</value>
    public string Id { get; }

    /// <summary>
    /// Gets a natural language name identifying the structure definition. This name should be usable as an
    /// identifier for the module by machine processing applications such as code generation.
    /// </summary>
    /// <value>The name.</value>
    public string Name => _name;

    /// <summary>
    /// Gets name field with the first letter capitalized, useful in various languages and PascalCase joining.
    /// </summary>
    /// <value>The name capitalized.</value>
    public string NameCapitalized => _nameCapitalized;

    /// <summary>Gets the dot-notation path to this element/resource/datatype.</summary>
    /// <value>The dot-notation path to this element/resource/datatype.</value>
    public string Path => _path;

    /// <summary>Gets URL of the document.</summary>
    /// <value>The URL.</value>
    public Uri URL { get; }

    /// <summary>Gets or sets the Name of the type this type inherits from (null if none).</summary>
    public string BaseTypeName { get => _baseTypeName; set => _baseTypeName = value; }

    /// <summary>Gets or sets the Canonical of the type this type inherits from (null if none).</summary>
    /// <value>The name of the base type.</value>
    public string BaseTypeCanonical { get => _baseTypeCanonical; set => _baseTypeCanonical = value; }

    /// <summary>
    /// Gets a concise description of what this element means (e.g. for use in autogenerated summaries).
    /// </summary>
    /// <value>The description.</value>
    public string ShortDescription { get; }

    /// <summary>
    /// Gets a complete explanation of the meaning of the data element for human readability.  For
    /// the case of elements derived from existing elements (e.g. constraints), the definition SHALL be
    /// consistent with the base definition, but convey the meaning of the element in the particular
    /// context of use of the resource. (Note: The text you are reading is specified in
    /// ElementDefinition.definition).
    /// </summary>
    /// <value>The definition.</value>
    public string Purpose { get; }

    /// <summary>
    /// Gets explanatory notes and implementation guidance about the data element, including notes about how
    /// to use the data properly, exceptions to proper use, etc. (Note: The text you are reading is
    /// specified in ElementDefinition.comment).
    /// </summary>
    /// <value>The comment.</value>
    public string Comment { get; }

    /// <summary>
    /// Gets a RegEx string used to validate values in this property.
    /// </summary>
    /// <value>The validation RegEx.</value>
    public string ValidationRegEx { get; }

    /// <summary>Type for export.</summary>
    /// <param name="convention">            The convention.</param>
    /// <param name="primitiveTypeMap">      The base type map.</param>
    /// <param name="concatenatePath">       (Optional) True to concatenate path.</param>
    /// <param name="concatenationDelimiter">(Optional) The concatenation delimiter.</param>
    /// <param name="reservedWords">         (Optional) The reserved words.</param>
    /// <returns>A string.</returns>
    public string TypeForExport(
        NamingConvention convention,
        Dictionary<string, string> primitiveTypeMap,
        bool concatenatePath = false,
        string concatenationDelimiter = "",
        HashSet<string> reservedWords = null)
    {
        if ((primitiveTypeMap != null) &&
            primitiveTypeMap.ContainsKey(_baseTypeName))
        {
            return primitiveTypeMap[_baseTypeName];
        }

        // Resources cannot inherit patterns, but they are listed that way today
        // see https://chat.fhir.org/#narrow/stream/179177-conformance/topic/Inheritance.20and.20Cardinality.20Changes
        string baseType = _baseTypeName switch
        {
            "CanonicalResource" or "MetadataResource" => "DomainResource",
            _ => _baseTypeName,
        };

        string type = FhirUtils.ToConvention(
            baseType,
            _path,
            convention,
            concatenatePath,
            concatenationDelimiter,
            reservedWords);

        return type;
    }

    /// <summary>Converts this object to a requested naming convention.</summary>
    /// <exception cref="ArgumentException">Thrown when one or more arguments have unsupported or
    ///  illegal values.</exception>
    /// <param name="convention">            The convention.</param>
    /// <param name="concatenatePath">       (Optional) True to concatenate path.</param>
    /// <param name="concatenationDelimiter">(Optional) The concatenation delimiter.</param>
    /// <param name="reservedWords">         (Optional) The reserved words.</param>
    /// <returns>A string.</returns>
    public string NameForExport(
        NamingConvention convention,
        bool concatenatePath = false,
        string concatenationDelimiter = "",
        HashSet<string> reservedWords = null)
    {
        if (string.IsNullOrEmpty(_name))
        {
            throw new ArgumentException($"Invalid Name: {_name}");
        }

        if (string.IsNullOrEmpty(_nameCapitalized))
        {
            throw new ArgumentException($"Invalid Name: {_nameCapitalized}");
        }

        if (string.IsNullOrEmpty(_path))
        {
            throw new ArgumentException($"Invalid Path: {_path}");
        }

        switch (convention)
        {
            case NamingConvention.FhirDotNotation:
                {
                    if ((reservedWords != null) &&
                        reservedWords.Contains(_path))
                    {
                        return "Fhir" + _path;
                    }

                    return _path;
                }

            case NamingConvention.PascalDotNotation:
                {
                    string value = _path.ToPascalDotCase();

                    if ((reservedWords != null) &&
                        reservedWords.Contains(value))
                    {
                        return "Fhir" + value;
                    }

                    return value;
                }

            case NamingConvention.PascalCase:
                {
                    if (concatenatePath)
                    {
                        string value = _path.ToPascalCase(true, concatenationDelimiter);

                        if ((reservedWords != null) &&
                            reservedWords.Contains(value))
                        {
                            return "Fhir" + value;
                        }

                        return value;
                    }

                    if ((reservedWords != null) &&
                        reservedWords.Contains(_nameCapitalized))
                    {
                        return "Fhir" + _nameCapitalized;
                    }

                    return _nameCapitalized;
                }

            case NamingConvention.CamelCase:
                {
                    string value;

                    if (concatenatePath)
                    {
                        value = _path.ToCamelCase(true, concatenationDelimiter);

                        if ((reservedWords != null) &&
                            reservedWords.Contains(value))
                        {
                            // change the main value to Pascal case since we are prefixing with lower case
                            return "fhir" + value.ToPascalCase(false);
                        }

                        return value;
                    }

                    value = _name.ToCamelCase(false);

                    if ((reservedWords != null) &&
                        reservedWords.Contains(value))
                    {
                        // note we use capitialized for appending here since the prefix is lower-cased
                        return "fhir" + _nameCapitalized;
                    }

                    return value;
                }

            case NamingConvention.UpperCase:
                {
                    string value;

                    if (concatenatePath)
                    {
                        value = _path.ToUpperCase(true, concatenationDelimiter);

                        if ((reservedWords != null) &&
                            reservedWords.Contains(value))
                        {
                            return "FHIR_" + value;
                        }

                        return value;
                    }

                    value = _name.ToUpperInvariant();

                    if ((reservedWords != null) &&
                        reservedWords.Contains(value))
                    {
                        // note we use capitialized for appending here since the prefix is lower-cased
                        return "FHIR" + _nameCapitalized;
                    }

                    return value;
                }

            case NamingConvention.LowerCase:
                {
                    string value;

                    if (concatenatePath)
                    {
                        value = _path.ToLowerCase(true, concatenationDelimiter);

                        if ((reservedWords != null) &&
                            reservedWords.Contains(value))
                        {
                            return "fhir_" + value;
                        }
                    }

                    value = _name.ToLowerInvariant();

                    if ((reservedWords != null) &&
                        reservedWords.Contains(value))
                    {
                        return "fhir" + value;
                    }

                    return value;
                }

            case NamingConvention.None:
            default:
                throw new ArgumentException($"Invalid Naming Convention: {convention}");
        }
    }
}
