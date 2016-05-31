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
    public partial class DocumentStatus :  IEquatable<DocumentStatus>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStatus" /> class.
        /// Initializes a new instance of the <see cref="DocumentStatus" />class.
        /// </summary>
        /// <param name="CompanySignerStatus">CompanySignerStatus.</param>
        /// <param name="PersonalSignerStatus">PersonalSignerStatus.</param>
        /// <param name="Status">Document status (  signing, signed).</param>

        public DocumentStatus(List<SignerStatus> CompanySignerStatus = null, List<SignerStatus> PersonalSignerStatus = null, string Status = null)
        {
            this.CompanySignerStatus = CompanySignerStatus;
            this.PersonalSignerStatus = PersonalSignerStatus;
            this.Status = Status;
            
        }
        
    
        /// <summary>
        /// Gets or Sets CompanySignerStatus
        /// </summary>
        [DataMember(Name="companySignerStatus", EmitDefaultValue=false)]
        public List<SignerStatus> CompanySignerStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets PersonalSignerStatus
        /// </summary>
        [DataMember(Name="personalSignerStatus", EmitDefaultValue=false)]
        public List<SignerStatus> PersonalSignerStatus { get; set; }
    
        /// <summary>
        /// Document status (  signing, signed)
        /// </summary>
        /// <value>Document status (  signing, signed)</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentStatus {\n");
            sb.Append("  CompanySignerStatus: ").Append(CompanySignerStatus).Append("\n");
            sb.Append("  PersonalSignerStatus: ").Append(PersonalSignerStatus).Append("\n");
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
            return this.Equals(obj as DocumentStatus);
        }

        /// <summary>
        /// Returns true if DocumentStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompanySignerStatus == other.CompanySignerStatus ||
                    this.CompanySignerStatus != null &&
                    this.CompanySignerStatus.SequenceEqual(other.CompanySignerStatus)
                ) && 
                (
                    this.PersonalSignerStatus == other.PersonalSignerStatus ||
                    this.PersonalSignerStatus != null &&
                    this.PersonalSignerStatus.SequenceEqual(other.PersonalSignerStatus)
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
                
                if (this.CompanySignerStatus != null)
                    hash = hash * 59 + this.CompanySignerStatus.GetHashCode();
                
                if (this.PersonalSignerStatus != null)
                    hash = hash * 59 + this.PersonalSignerStatus.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                return hash;
            }
        }

    }
}
