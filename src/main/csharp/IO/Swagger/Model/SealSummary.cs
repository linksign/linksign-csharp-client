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
    /// \u5370\u7AE0\u7ED3\u679C
    /// </summary>
    [DataContract]
    public partial class SealSummary :  IEquatable<SealSummary>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SealSummary" /> class.
        /// Initializes a new instance of the <see cref="SealSummary" />class.
        /// </summary>
        /// <param name="SealFileUri">\u5370\u7AE0\u56FE\u7247\u4E0B\u8F7D\u5730\u5740 (required).</param>
        /// <param name="SealId">\u5370\u7AE0\u7F16\u53F7 (required).</param>
        /// <param name="SealerRedirectUri">\u5370\u7AE0\u6536\u96C6\u91CD\u5B9A\u5411\u94FE\u63A5 (required).</param>

        public SealSummary(string SealFileUri = null, string SealId = null, string SealerRedirectUri = null)
        {
            // to ensure "SealFileUri" is required (not null)
            if (SealFileUri == null)
            {
                throw new InvalidDataException("SealFileUri is a required property for SealSummary and cannot be null");
            }
            else
            {
                this.SealFileUri = SealFileUri;
            }
            // to ensure "SealId" is required (not null)
            if (SealId == null)
            {
                throw new InvalidDataException("SealId is a required property for SealSummary and cannot be null");
            }
            else
            {
                this.SealId = SealId;
            }
            // to ensure "SealerRedirectUri" is required (not null)
            if (SealerRedirectUri == null)
            {
                throw new InvalidDataException("SealerRedirectUri is a required property for SealSummary and cannot be null");
            }
            else
            {
                this.SealerRedirectUri = SealerRedirectUri;
            }
            
        }
        
    
        /// <summary>
        /// \u5370\u7AE0\u56FE\u7247\u4E0B\u8F7D\u5730\u5740
        /// </summary>
        /// <value>\u5370\u7AE0\u56FE\u7247\u4E0B\u8F7D\u5730\u5740</value>
        [DataMember(Name="sealFileUri", EmitDefaultValue=false)]
        public string SealFileUri { get; set; }
    
        /// <summary>
        /// \u5370\u7AE0\u7F16\u53F7
        /// </summary>
        /// <value>\u5370\u7AE0\u7F16\u53F7</value>
        [DataMember(Name="sealId", EmitDefaultValue=false)]
        public string SealId { get; set; }
    
        /// <summary>
        /// \u5370\u7AE0\u6536\u96C6\u91CD\u5B9A\u5411\u94FE\u63A5
        /// </summary>
        /// <value>\u5370\u7AE0\u6536\u96C6\u91CD\u5B9A\u5411\u94FE\u63A5</value>
        [DataMember(Name="sealerRedirectUri", EmitDefaultValue=false)]
        public string SealerRedirectUri { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SealSummary {\n");
            sb.Append("  SealFileUri: ").Append(SealFileUri).Append("\n");
            sb.Append("  SealId: ").Append(SealId).Append("\n");
            sb.Append("  SealerRedirectUri: ").Append(SealerRedirectUri).Append("\n");
            
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
            return this.Equals(obj as SealSummary);
        }

        /// <summary>
        /// Returns true if SealSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of SealSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SealSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SealFileUri == other.SealFileUri ||
                    this.SealFileUri != null &&
                    this.SealFileUri.Equals(other.SealFileUri)
                ) && 
                (
                    this.SealId == other.SealId ||
                    this.SealId != null &&
                    this.SealId.Equals(other.SealId)
                ) && 
                (
                    this.SealerRedirectUri == other.SealerRedirectUri ||
                    this.SealerRedirectUri != null &&
                    this.SealerRedirectUri.Equals(other.SealerRedirectUri)
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
                
                if (this.SealFileUri != null)
                    hash = hash * 59 + this.SealFileUri.GetHashCode();
                
                if (this.SealId != null)
                    hash = hash * 59 + this.SealId.GetHashCode();
                
                if (this.SealerRedirectUri != null)
                    hash = hash * 59 + this.SealerRedirectUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
