using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// \u7B7E\u540D
    /// </summary>
    [DataContract]
    public partial class Signature :  IEquatable<Signature>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Signature" /> class.
        /// Initializes a new instance of the <see cref="Signature" />class.
        /// </summary>
        /// <param name="Personal">\u4E2A\u4EBA\u4FE1\u606F (required).</param>
        /// <param name="RedirectUri">\u6536\u96C6\u5B8C\u6210\u540E\u8DF3\u8F6C\u7684\u5E94\u7528URI (required).</param>
        /// <param name="RelateSealId">\u4E0E\u7B7E\u540D\u5173\u8054\u7684\u5370\u7AE0\u7F16\u53F7.</param>

        public Signature(Personal Personal = null, string RedirectUri = null, string RelateSealId = null)
        {
            // to ensure "Personal" is required (not null)
            if (Personal == null)
            {
                throw new InvalidDataException("Personal is a required property for Signature and cannot be null");
            }
            else
            {
                this.Personal = Personal;
            }
            // to ensure "RedirectUri" is required (not null)
            if (RedirectUri == null)
            {
                throw new InvalidDataException("RedirectUri is a required property for Signature and cannot be null");
            }
            else
            {
                this.RedirectUri = RedirectUri;
            }
            this.RelateSealId = RelateSealId;
            
        }
        
    
        /// <summary>
        /// \u4E2A\u4EBA\u4FE1\u606F
        /// </summary>
        /// <value>\u4E2A\u4EBA\u4FE1\u606F</value>
        [DataMember(Name="Personal", EmitDefaultValue=false)]
        public Personal Personal { get; set; }
    
        /// <summary>
        /// \u6536\u96C6\u5B8C\u6210\u540E\u8DF3\u8F6C\u7684\u5E94\u7528URI
        /// </summary>
        /// <value>\u6536\u96C6\u5B8C\u6210\u540E\u8DF3\u8F6C\u7684\u5E94\u7528URI</value>
        [DataMember(Name="redirectUri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }
    
        /// <summary>
        /// \u4E0E\u7B7E\u540D\u5173\u8054\u7684\u5370\u7AE0\u7F16\u53F7
        /// </summary>
        /// <value>\u4E0E\u7B7E\u540D\u5173\u8054\u7684\u5370\u7AE0\u7F16\u53F7</value>
        [DataMember(Name="relateSealId", EmitDefaultValue=false)]
        public string RelateSealId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signature {\n");
            sb.Append("  Personal: ").Append(Personal).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  RelateSealId: ").Append(RelateSealId).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Signature);
        }

        /// <summary>
        /// Returns true if Signature instances are equal
        /// </summary>
        /// <param name="other">Instance of Signature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signature other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Personal == other.Personal ||
                    this.Personal != null &&
                    this.Personal.Equals(other.Personal)
                ) && 
                (
                    this.RedirectUri == other.RedirectUri ||
                    this.RedirectUri != null &&
                    this.RedirectUri.Equals(other.RedirectUri)
                ) && 
                (
                    this.RelateSealId == other.RelateSealId ||
                    this.RelateSealId != null &&
                    this.RelateSealId.Equals(other.RelateSealId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Personal != null)
                    hash = hash * 59 + this.Personal.GetHashCode();
                
                if (this.RedirectUri != null)
                    hash = hash * 59 + this.RedirectUri.GetHashCode();
                
                if (this.RelateSealId != null)
                    hash = hash * 59 + this.RelateSealId.GetHashCode();
                
                return hash;
            }
        }

    }
}
