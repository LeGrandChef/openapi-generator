// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Fruit
    /// </summary>
    public partial class Fruit : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit" /> class.
        /// </summary>
        /// <param name="apple?"></param>
        /// <param name="color">color</param>
        [JsonConstructor]
        public Fruit(Apple? apple, string color)
        {
            Apple = apple;
            Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit" /> class.
        /// </summary>
        /// <param name="banana"></param>
        /// <param name="color">color</param>
        [JsonConstructor]
        public Fruit(Banana banana, string color)
        {
            Banana = banana;
            Color = color;
        }

        /// <summary>
        /// Gets or Sets Apple
        /// </summary>
        public Apple? Apple { get; set; }

        /// <summary>
        /// Gets or Sets Banana
        /// </summary>
        public Banana? Banana { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [JsonPropertyName("color")]
        public string Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Fruit {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }


    /// <summary>
    /// A Json converter for type Fruit
    /// </summary>
    public class FruitJsonConverter : JsonConverter<Fruit>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Fruit Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Utf8JsonReader appleReader = utf8JsonReader;
            bool appleDeserialized = Client.ClientUtils.TryDeserialize<Apple>(ref appleReader, jsonSerializerOptions, out Apple? apple);

            Utf8JsonReader bananaReader = utf8JsonReader;
            bool bananaDeserialized = Client.ClientUtils.TryDeserialize<Banana>(ref bananaReader, jsonSerializerOptions, out Banana? banana);

            string color = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "color":
                            color = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (color == null)
                throw new ArgumentNullException(nameof(color), "Property is required for class Fruit.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (appleDeserialized)
                return new Fruit(apple, color);

            if (bananaDeserialized)
                return new Fruit(banana, color);

            throw new JsonException();
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fruit"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Fruit fruit, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WriteString("color", fruit.Color);

            writer.WriteEndObject();
        }
    }
}
