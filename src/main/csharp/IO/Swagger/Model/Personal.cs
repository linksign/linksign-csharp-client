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
    /// \u4E2A\u4EBA\u4FE1\u606F
    /// </summary>
    [DataContract]
    public partial class Personal :  IEquatable<Personal>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Personal" /> class.
        /// Initializes a new instance of the <see cref="Personal" />class.
        /// </summary>
        /// <param name="EmailNotice">\u662F\u5426\u90AE\u4EF6\u901A\u77E5\u7B7E\u7F72\u4EBA(y/n).</param>
        /// <param name="LinksignUserId">\u9886\u7B7E\u7CFB\u7EDF\u7528\u6237\u7F16\u53F7.</param>
        /// <param name="PersonEmail">PersonEmail.</param>
        /// <param name="PersonIdcardNumber">PersonIdcardNumber.</param>
        /// <param name="PersonIdcardType">PersonIdcardType.</param>
        /// <param name="PersonName">PersonName (required).</param>
        /// <param name="PersonOrgName">PersonOrgName.</param>
        /// <param name="PersonPhone">PersonPhone.</param>
        /// <param name="RecipientIndex">\u4E2A\u4EBA\u7D22\u5F15.</param>
        /// <param name="SmsNotice">\u662F\u5426\u77ED\u4FE1\u901A\u77E5\u7B7E\u7F72\u4EBA(y/n).</param>

        public Personal(string EmailNotice = null, string LinksignUserId = null, string PersonEmail = null, string PersonIdcardNumber = null, string PersonIdcardType = null, string PersonName = null, string PersonOrgName = null, string PersonPhone = null, string RecipientIndex = null, string SmsNotice = null)
        {
            // to ensure "PersonName" is required (not null)
            if (PersonName == null)
            {
                throw new InvalidDataException("PersonName is a required property for Personal and cannot be null");
            }
            else
            {
                this.PersonName = PersonName;
            }
            this.EmailNotice = EmailNotice;
            this.LinksignUserId = LinksignUserId;
            this.PersonEmail = PersonEmail;
            this.PersonIdcardNumber = PersonIdcardNumber;
            this.PersonIdcardType = PersonIdcardType;
            this.PersonOrgName = PersonOrgName;
            this.PersonPhone = PersonPhone;
            this.RecipientIndex = RecipientIndex;
            this.SmsNotice = SmsNotice;
            
        }
        
    
        /// <summary>
        /// \u662F\u5426\u90AE\u4EF6\u901A\u77E5\u7B7E\u7F72\u4EBA(y/n)
        /// </summary>
        /// <value>\u662F\u5426\u90AE\u4EF6\u901A\u77E5\u7B7E\u7F72\u4EBA(y/n)</value>
        [DataMember(Name="emailNotice", EmitDefaultValue=false)]
        public string EmailNotice { get; set; }
    
        /// <summary>
        /// \u9886\u7B7E\u7CFB\u7EDF\u7528\u6237\u7F16\u53F7
        /// </summary>
        /// <value>\u9886\u7B7E\u7CFB\u7EDF\u7528\u6237\u7F16\u53F7</value>
        [DataMember(Name="linksignUserId", EmitDefaultValue=false)]
        public string LinksignUserId { get; set; }
    
        /// <summary>
        /// Gets or Sets PersonEmail
        /// </summary>
        [DataMember(Name="personEmail", EmitDefaultValue=false)]
        public string PersonEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets PersonIdcardNumber
        /// </summary>
        [DataMember(Name="personIdcardNumber", EmitDefaultValue=false)]
        public string PersonIdcardNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets PersonIdcardType
        /// </summary>
        [DataMember(Name="personIdcardType", EmitDefaultValue=false)]
        public string PersonIdcardType { get; set; }
    
        /// <summary>
        /// Gets or Sets PersonName
        /// </summary>
        [DataMember(Name="personName", EmitDefaultValue=false)]
        public string PersonName { get; set; }
    
        /// <summary>
        /// Gets or Sets PersonOrgName
        /// </summary>
        [DataMember(Name="personOrgName", EmitDefaultValue=false)]
        public string PersonOrgName { get; set; }
    
        /// <summary>
        /// Gets or Sets PersonPhone
        /// </summary>
        [DataMember(Name="personPhone", EmitDefaultValue=false)]
        public string PersonPhone { get; set; }
    
        /// <summary>
        /// \u4E2A\u4EBA\u7D22\u5F15
        /// </summary>
        /// <value>\u4E2A\u4EBA\u7D22\u5F15</value>
        [DataMember(Name="recipientIndex", EmitDefaultValue=false)]
        public string RecipientIndex { get; set; }
    
        /// <summary>
        /// \u662F\u5426\u77ED\u4FE1\u901A\u77E5\u7B7E\u7F72\u4EBA(y/n)
        /// </summary>
        /// <value>\u662F\u5426\u77ED\u4FE1\u901A\u77E5\u7B7E\u7F72\u4EBA(y/n)</value>
        [DataMember(Name="smsNotice", EmitDefaultValue=false)]
        public string SmsNotice { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Personal {\n");
            sb.Append("  EmailNotice: ").Append(EmailNotice).Append("\n");
            sb.Append("  LinksignUserId: ").Append(LinksignUserId).Append("\n");
            sb.Append("  PersonEmail: ").Append(PersonEmail).Append("\n");
            sb.Append("  PersonIdcardNumber: ").Append(PersonIdcardNumber).Append("\n");
            sb.Append("  PersonIdcardType: ").Append(PersonIdcardType).Append("\n");
            sb.Append("  PersonName: ").Append(PersonName).Append("\n");
            sb.Append("  PersonOrgName: ").Append(PersonOrgName).Append("\n");
            sb.Append("  PersonPhone: ").Append(PersonPhone).Append("\n");
            sb.Append("  RecipientIndex: ").Append(RecipientIndex).Append("\n");
            sb.Append("  SmsNotice: ").Append(SmsNotice).Append("\n");
            
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
            return this.Equals(obj as Personal);
        }

        /// <summary>
        /// Returns true if Personal instances are equal
        /// </summary>
        /// <param name="other">Instance of Personal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Personal other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmailNotice == other.EmailNotice ||
                    this.EmailNotice != null &&
                    this.EmailNotice.Equals(other.EmailNotice)
                ) && 
                (
                    this.LinksignUserId == other.LinksignUserId ||
                    this.LinksignUserId != null &&
                    this.LinksignUserId.Equals(other.LinksignUserId)
                ) && 
                (
                    this.PersonEmail == other.PersonEmail ||
                    this.PersonEmail != null &&
                    this.PersonEmail.Equals(other.PersonEmail)
                ) && 
                (
                    this.PersonIdcardNumber == other.PersonIdcardNumber ||
                    this.PersonIdcardNumber != null &&
                    this.PersonIdcardNumber.Equals(other.PersonIdcardNumber)
                ) && 
                (
                    this.PersonIdcardType == other.PersonIdcardType ||
                    this.PersonIdcardType != null &&
                    this.PersonIdcardType.Equals(other.PersonIdcardType)
                ) && 
                (
                    this.PersonName == other.PersonName ||
                    this.PersonName != null &&
                    this.PersonName.Equals(other.PersonName)
                ) && 
                (
                    this.PersonOrgName == other.PersonOrgName ||
                    this.PersonOrgName != null &&
                    this.PersonOrgName.Equals(other.PersonOrgName)
                ) && 
                (
                    this.PersonPhone == other.PersonPhone ||
                    this.PersonPhone != null &&
                    this.PersonPhone.Equals(other.PersonPhone)
                ) && 
                (
                    this.RecipientIndex == other.RecipientIndex ||
                    this.RecipientIndex != null &&
                    this.RecipientIndex.Equals(other.RecipientIndex)
                ) && 
                (
                    this.SmsNotice == other.SmsNotice ||
                    this.SmsNotice != null &&
                    this.SmsNotice.Equals(other.SmsNotice)
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
                
                if (this.EmailNotice != null)
                    hash = hash * 59 + this.EmailNotice.GetHashCode();
                
                if (this.LinksignUserId != null)
                    hash = hash * 59 + this.LinksignUserId.GetHashCode();
                
                if (this.PersonEmail != null)
                    hash = hash * 59 + this.PersonEmail.GetHashCode();
                
                if (this.PersonIdcardNumber != null)
                    hash = hash * 59 + this.PersonIdcardNumber.GetHashCode();
                
                if (this.PersonIdcardType != null)
                    hash = hash * 59 + this.PersonIdcardType.GetHashCode();
                
                if (this.PersonName != null)
                    hash = hash * 59 + this.PersonName.GetHashCode();
                
                if (this.PersonOrgName != null)
                    hash = hash * 59 + this.PersonOrgName.GetHashCode();
                
                if (this.PersonPhone != null)
                    hash = hash * 59 + this.PersonPhone.GetHashCode();
                
                if (this.RecipientIndex != null)
                    hash = hash * 59 + this.RecipientIndex.GetHashCode();
                
                if (this.SmsNotice != null)
                    hash = hash * 59 + this.SmsNotice.GetHashCode();
                
                return hash;
            }
        }

    }
}
