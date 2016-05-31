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
    public partial class SignerStatus :  IEquatable<SignerStatus>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SignerStatus" /> class.
        /// Initializes a new instance of the <see cref="SignerStatus" />class.
        /// </summary>
        /// <param name="RecipientIndex">RecipientIndex.</param>
        /// <param name="SignerUri">SignerUri.</param>
        /// <param name="Status">signature status(signing,signed).</param>

        public SignerStatus(string RecipientIndex = null, string SignerUri = null, string Status = null)
        {
            this.RecipientIndex = RecipientIndex;
            this.SignerUri = SignerUri;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// Gets or Sets RecipientIndex
        /// </summary>
        [DataMember(Name="recipientIndex", EmitDefaultValue=false)]
        public string RecipientIndex { get; set; }
    
        /// <summary>
        /// Gets or Sets SignerUri
        /// </summary>
        [DataMember(Name="signerUri", EmitDefaultValue=false)]
        public string SignerUri { get; set; }
    
        /// <summary>
        /// signature status(signing,signed)
        /// </summary>
        /// <value>signature status(signing,signed)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignerStatus {\n");
            sb.Append("  RecipientIndex: ").Append(RecipientIndex).Append("\n");
            sb.Append("  SignerUri: ").Append(SignerUri).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            
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
            return this.Equals(obj as SignerStatus);
        }

        /// <summary>
        /// Returns true if SignerStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of SignerStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignerStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RecipientIndex == other.RecipientIndex ||
                    this.RecipientIndex != null &&
                    this.RecipientIndex.Equals(other.RecipientIndex)
                ) && 
                (
                    this.SignerUri == other.SignerUri ||
                    this.SignerUri != null &&
                    this.SignerUri.Equals(other.SignerUri)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                
                if (this.RecipientIndex != null)
                    hash = hash * 59 + this.RecipientIndex.GetHashCode();
                
                if (this.SignerUri != null)
                    hash = hash * 59 + this.SignerUri.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
