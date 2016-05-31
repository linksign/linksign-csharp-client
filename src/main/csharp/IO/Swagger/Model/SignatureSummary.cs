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
    /// 
    /// </summary>
    [DataContract]
    public partial class SignatureSummary :  IEquatable<SignatureSummary>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureSummary" /> class.
        /// Initializes a new instance of the <see cref="SignatureSummary" />class.
        /// </summary>
        /// <param name="SignatureFileUri">SignatureFileUri.</param>
        /// <param name="SignatureId">SignatureId.</param>
        /// <param name="SignerRedirectUri">SignerRedirectUri.</param>

        public SignatureSummary(string SignatureFileUri = null, string SignatureId = null, string SignerRedirectUri = null)
        {
            this.SignatureFileUri = SignatureFileUri;
            this.SignatureId = SignatureId;
            this.SignerRedirectUri = SignerRedirectUri;
            
        }
        
    
        /// <summary>
        /// Gets or Sets SignatureFileUri
        /// </summary>
        [DataMember(Name="signatureFileUri", EmitDefaultValue=false)]
        public string SignatureFileUri { get; set; }
    
        /// <summary>
        /// Gets or Sets SignatureId
        /// </summary>
        [DataMember(Name="signatureId", EmitDefaultValue=false)]
        public string SignatureId { get; set; }
    
        /// <summary>
        /// Gets or Sets SignerRedirectUri
        /// </summary>
        [DataMember(Name="signerRedirectUri", EmitDefaultValue=false)]
        public string SignerRedirectUri { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignatureSummary {\n");
            sb.Append("  SignatureFileUri: ").Append(SignatureFileUri).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  SignerRedirectUri: ").Append(SignerRedirectUri).Append("\n");
            
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
            return this.Equals(obj as SignatureSummary);
        }

        /// <summary>
        /// Returns true if SignatureSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of SignatureSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SignatureFileUri == other.SignatureFileUri ||
                    this.SignatureFileUri != null &&
                    this.SignatureFileUri.Equals(other.SignatureFileUri)
                ) && 
                (
                    this.SignatureId == other.SignatureId ||
                    this.SignatureId != null &&
                    this.SignatureId.Equals(other.SignatureId)
                ) && 
                (
                    this.SignerRedirectUri == other.SignerRedirectUri ||
                    this.SignerRedirectUri != null &&
                    this.SignerRedirectUri.Equals(other.SignerRedirectUri)
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
                
                if (this.SignatureFileUri != null)
                    hash = hash * 59 + this.SignatureFileUri.GetHashCode();
                
                if (this.SignatureId != null)
                    hash = hash * 59 + this.SignatureId.GetHashCode();
                
                if (this.SignerRedirectUri != null)
                    hash = hash * 59 + this.SignerRedirectUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
