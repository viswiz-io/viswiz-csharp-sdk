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
    /// Notifications
    /// </summary>
    [DataContract]
    public partial class Notifications :  IEquatable<Notifications>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notifications" /> class.
        /// </summary>
        /// <param name="emailEnabled">Controls if email reports are sent on new builds.</param>
        /// <param name="slackEnabled">Controls if Slack notifications are sent on new builds.</param>
        /// <param name="slackURL">The Slack webhook URL to use for sending notifications.</param>
        public Notifications(bool? emailEnabled = default(bool?), bool? slackEnabled = default(bool?), string slackURL = default(string))
        {
            this.EmailEnabled = emailEnabled;
            this.SlackEnabled = slackEnabled;
            this.SlackURL = slackURL;
        }
        
        /// <summary>
        /// Controls if email reports are sent on new builds
        /// </summary>
        /// <value>Controls if email reports are sent on new builds</value>
        [DataMember(Name="emailEnabled", EmitDefaultValue=false)]
        public bool? EmailEnabled { get; set; }

        /// <summary>
        /// Controls if Slack notifications are sent on new builds
        /// </summary>
        /// <value>Controls if Slack notifications are sent on new builds</value>
        [DataMember(Name="slackEnabled", EmitDefaultValue=false)]
        public bool? SlackEnabled { get; set; }

        /// <summary>
        /// The Slack webhook URL to use for sending notifications
        /// </summary>
        /// <value>The Slack webhook URL to use for sending notifications</value>
        [DataMember(Name="slackURL", EmitDefaultValue=false)]
        public string SlackURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notifications {\n");
            sb.Append("  EmailEnabled: ").Append(EmailEnabled).Append("\n");
            sb.Append("  SlackEnabled: ").Append(SlackEnabled).Append("\n");
            sb.Append("  SlackURL: ").Append(SlackURL).Append("\n");
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
            return this.Equals(input as Notifications);
        }

        /// <summary>
        /// Returns true if Notifications instances are equal
        /// </summary>
        /// <param name="input">Instance of Notifications to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notifications input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailEnabled == input.EmailEnabled ||
                    (this.EmailEnabled != null &&
                    this.EmailEnabled.Equals(input.EmailEnabled))
                ) && 
                (
                    this.SlackEnabled == input.SlackEnabled ||
                    (this.SlackEnabled != null &&
                    this.SlackEnabled.Equals(input.SlackEnabled))
                ) && 
                (
                    this.SlackURL == input.SlackURL ||
                    (this.SlackURL != null &&
                    this.SlackURL.Equals(input.SlackURL))
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
                if (this.EmailEnabled != null)
                    hashCode = hashCode * 59 + this.EmailEnabled.GetHashCode();
                if (this.SlackEnabled != null)
                    hashCode = hashCode * 59 + this.SlackEnabled.GetHashCode();
                if (this.SlackURL != null)
                    hashCode = hashCode * 59 + this.SlackURL.GetHashCode();
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