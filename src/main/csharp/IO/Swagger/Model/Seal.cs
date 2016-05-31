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
    /// \u5370\u7AE0\u4FE1\u606F
    /// </summary>
    [DataContract]
    public partial class Seal :  IEquatable<Seal>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Seal" /> class.
        /// Initializes a new instance of the <see cref="Seal" />class.
        /// </summary>
        /// <param name="Company">Company (required).</param>
        /// <param name="RedirectUri">\u6536\u96C6\u5B8C\u6210\u540E\u8DF3\u8F6C\u7684\u5E94\u7528URI.</param>
        /// <param name="RelateSignatureId">\u4E0E\u5370\u7AE0\u5173\u8054\u7684\u7B7E\u540D\u7F16\u53F7.</param>

        public Seal(Company Company = null, string RedirectUri = null, string RelateSignatureId = null)
        {
            // to ensure "Company" is required (not null)
            if (Company == null)
            {
                throw new InvalidDataException("Company is a required property for Seal and cannot be null");
            }
            else
            {
                this.Company = Company;
            }
            this.RedirectUri = RedirectUri;
            this.RelateSignatureId = RelateSignatureId;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="Company", EmitDefaultValue=false)]
        public Company Company { get; set; }
    
        /// <summary>
        /// \u6536\u96C6\u5B8C\u6210\u540E\u8DF3\u8F6C\u7684\u5E94\u7528URI
        /// </summary>
        /// <value>\u6536\u96C6\u5B8C\u6210\u540E\u8DF3\u8F6C\u7684\u5E94\u7528URI</value>
        [DataMember(Name="redirectUri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }
    
        /// <summary>
        /// \u4E0E\u5370\u7AE0\u5173\u8054\u7684\u7B7E\u540D\u7F16\u53F7
        /// </summary>
        /// <value>\u4E0E\u5370\u7AE0\u5173\u8054\u7684\u7B7E\u540D\u7F16\u53F7</value>
        [DataMember(Name="relateSignatureId", EmitDefaultValue=false)]
        public string RelateSignatureId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Seal {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  RelateSignatureId: ").Append(RelateSignatureId).Append("\n");
            
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
            return this.Equals(obj as Seal);
        }

        /// <summary>
        /// Returns true if Seal instances are equal
        /// </summary>
        /// <param name="other">Instance of Seal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Seal other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.RedirectUri == other.RedirectUri ||
                    this.RedirectUri != null &&
                    this.RedirectUri.Equals(other.RedirectUri)
                ) && 
                (
                    this.RelateSignatureId == other.RelateSignatureId ||
                    this.RelateSignatureId != null &&
                    this.RelateSignatureId.Equals(other.RelateSignatureId)
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
                
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                
                if (this.RedirectUri != null)
                    hash = hash * 59 + this.RedirectUri.GetHashCode();
                
                if (this.RelateSignatureId != null)
                    hash = hash * 59 + this.RelateSignatureId.GetHashCode();
                
                return hash;
            }
        }

    }
}
