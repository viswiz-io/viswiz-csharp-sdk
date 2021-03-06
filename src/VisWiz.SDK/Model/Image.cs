/* 
 * VisWiz.io API Documentation
 *
 * This SDK allows you to query and create new projects, builds or images within the VisWiz service. 
 *
 * OpenAPI spec version: 1.1.0
 * Contact: support@viswiz.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = VisWiz.SDK.Client.SwaggerDateConverter;

namespace VisWiz.SDK.Model
{
    /// <summary>
    /// Image
    /// </summary>
    [DataContract]
    public partial class Image :  IEquatable<Image>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Image" /> class.
        /// </summary>
        /// <param name="name">The identifing name of the image.</param>
        /// <param name="createdAt">The date and time the image was created.</param>
        /// <param name="height">The height of the image.</param>
        /// <param name="originalURL">The URL for the original image.</param>
        /// <param name="originalURLWebP">The URL for the original image in WebP format.</param>
        /// <param name="thumbURL">The URL for the thumbnail image.</param>
        /// <param name="thumbURLWebP">The URL for the thumbnail image in WebP format.</param>
        /// <param name="width">The width of the image.</param>
        public Image(string name = default(string), DateTime? createdAt = default(DateTime?), int? height = default(int?), string originalURL = default(string), string originalURLWebP = default(string), string thumbURL = default(string), string thumbURLWebP = default(string), int? width = default(int?))
        {
            this.Name = name;
            this.CreatedAt = createdAt;
            this.Height = height;
            this.OriginalURL = originalURL;
            this.OriginalURLWebP = originalURLWebP;
            this.ThumbURL = thumbURL;
            this.ThumbURLWebP = thumbURLWebP;
            this.Width = width;
        }
        
        /// <summary>
        /// The identifing name of the image
        /// </summary>
        /// <value>The identifing name of the image</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The date and time the image was created
        /// </summary>
        /// <value>The date and time the image was created</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The height of the image
        /// </summary>
        /// <value>The height of the image</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// The URL for the original image
        /// </summary>
        /// <value>The URL for the original image</value>
        [DataMember(Name="originalURL", EmitDefaultValue=false)]
        public string OriginalURL { get; set; }

        /// <summary>
        /// The URL for the original image in WebP format
        /// </summary>
        /// <value>The URL for the original image in WebP format</value>
        [DataMember(Name="originalURLWebP", EmitDefaultValue=false)]
        public string OriginalURLWebP { get; set; }

        /// <summary>
        /// The URL for the thumbnail image
        /// </summary>
        /// <value>The URL for the thumbnail image</value>
        [DataMember(Name="thumbURL", EmitDefaultValue=false)]
        public string ThumbURL { get; set; }

        /// <summary>
        /// The URL for the thumbnail image in WebP format
        /// </summary>
        /// <value>The URL for the thumbnail image in WebP format</value>
        [DataMember(Name="thumbURLWebP", EmitDefaultValue=false)]
        public string ThumbURLWebP { get; set; }

        /// <summary>
        /// The width of the image
        /// </summary>
        /// <value>The width of the image</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Image {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  OriginalURL: ").Append(OriginalURL).Append("\n");
            sb.Append("  OriginalURLWebP: ").Append(OriginalURLWebP).Append("\n");
            sb.Append("  ThumbURL: ").Append(ThumbURL).Append("\n");
            sb.Append("  ThumbURLWebP: ").Append(ThumbURLWebP).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Image);
        }

        /// <summary>
        /// Returns true if Image instances are equal
        /// </summary>
        /// <param name="input">Instance of Image to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Image input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.OriginalURL == input.OriginalURL ||
                    (this.OriginalURL != null &&
                    this.OriginalURL.Equals(input.OriginalURL))
                ) && 
                (
                    this.OriginalURLWebP == input.OriginalURLWebP ||
                    (this.OriginalURLWebP != null &&
                    this.OriginalURLWebP.Equals(input.OriginalURLWebP))
                ) && 
                (
                    this.ThumbURL == input.ThumbURL ||
                    (this.ThumbURL != null &&
                    this.ThumbURL.Equals(input.ThumbURL))
                ) && 
                (
                    this.ThumbURLWebP == input.ThumbURLWebP ||
                    (this.ThumbURLWebP != null &&
                    this.ThumbURLWebP.Equals(input.ThumbURLWebP))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.OriginalURL != null)
                    hashCode = hashCode * 59 + this.OriginalURL.GetHashCode();
                if (this.OriginalURLWebP != null)
                    hashCode = hashCode * 59 + this.OriginalURLWebP.GetHashCode();
                if (this.ThumbURL != null)
                    hashCode = hashCode * 59 + this.ThumbURL.GetHashCode();
                if (this.ThumbURLWebP != null)
                    hashCode = hashCode * 59 + this.ThumbURLWebP.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                return hashCode;
            }
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

}
