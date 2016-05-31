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
    /// \u5355\u4F4D\u4FE1\u606F
    /// </summary>
    [DataContract]
    public partial class Company :  IEquatable<Company>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Company" /> class.
        /// Initializes a new instance of the <see cref="Company" />class.
        /// </summary>
        /// <param name="EmailNotice">\u662F\u5426\u90AE\u4EF6\u901A\u77E5\u7B7E\u7F72\u4EBA(y/n).</param>
        /// <param name="LinksignUserId">\u9886\u7B7E\u7CFB\u7EDF\u7528\u6237\u7F16\u53F7.</param>
        /// <param name="OrgAuthorizerEmail">\u5355\u4F4D\u6388\u6743\u4EBA\u90AE\u7BB1.</param>
        /// <param name="OrgAuthorizerIdcardNumber">\u5355\u4F4D\u6388\u6743\u4EBA\u8BC1\u4EF6\u53F7\u7801.</param>
        /// <param name="OrgAuthorizerIdcardType">\u5355\u4F4D\u6388\u6743\u4EBA\u8BC1\u4EF6\u7C7B\u578B.</param>
        /// <param name="OrgAuthorizerName">\u5355\u4F4D\u6388\u6743\u4EBA\u59D3\u540D.</param>
        /// <param name="OrgAuthorizerPhone">OrgAuthorizerPhone (required).</param>
        /// <param name="OrgIdcardNumber">\u5355\u4F4D\u8BC1\u4EF6\u7F16\u53F7.</param>
        /// <param name="OrgIdcardType">\u5355\u4F4D\u8BC1\u4EF6\u7C7B\u578B.</param>
        /// <param name="OrgName">\u5355\u4F4D\u540D\u79F0 (required).</param>
        /// <param name="RecipientIndex">\u516C\u53F8\u7D22\u5F15.</param>
        /// <param name="SmsNotice">\u662F\u5426\u77ED\u4FE1\u901A\u77E5\u7B7E\u7F72\u4EBA(y/n).</param>

        public Company(string EmailNotice = null, string LinksignUserId = null, string OrgAuthorizerEmail = null, string OrgAuthorizerIdcardNumber = null, string OrgAuthorizerIdcardType = null, string OrgAuthorizerName = null, string OrgAuthorizerPhone = null, string OrgIdcardNumber = null, string OrgIdcardType = null, string OrgName = null, string RecipientIndex = null, string SmsNotice = null)
        {
            // to ensure "OrgAuthorizerPhone" is required (not null)
            if (OrgAuthorizerPhone == null)
            {
                throw new InvalidDataException("OrgAuthorizerPhone is a required property for Company and cannot be null");
            }
            else
            {
                this.OrgAuthorizerPhone = OrgAuthorizerPhone;
            }
            // to ensure "OrgName" is required (not null)
            if (OrgName == null)
            {
                throw new InvalidDataException("OrgName is a required property for Company and cannot be null");
            }
            else
            {
                this.OrgName = OrgName;
            }
            this.EmailNotice = EmailNotice;
            this.LinksignUserId = LinksignUserId;
            this.OrgAuthorizerEmail = OrgAuthorizerEmail;
            this.OrgAuthorizerIdcardNumber = OrgAuthorizerIdcardNumber;
            this.OrgAuthorizerIdcardType = OrgAuthorizerIdcardType;
            this.OrgAuthorizerName = OrgAuthorizerName;
            this.OrgIdcardNumber = OrgIdcardNumber;
            this.OrgIdcardType = OrgIdcardType;
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
        /// \u5355\u4F4D\u6388\u6743\u4EBA\u90AE\u7BB1
        /// </summary>
        /// <value>\u5355\u4F4D\u6388\u6743\u4EBA\u90AE\u7BB1</value>
        [DataMember(Name="orgAuthorizerEmail", EmitDefaultValue=false)]
        public string OrgAuthorizerEmail { get; set; }
    
        /// <summary>
        /// \u5355\u4F4D\u6388\u6743\u4EBA\u8BC1\u4EF6\u53F7\u7801
        /// </summary>
        /// <value>\u5355\u4F4D\u6388\u6743\u4EBA\u8BC1\u4EF6\u53F7\u7801</value>
        [DataMember(Name="orgAuthorizerIdcardNumber", EmitDefaultValue=false)]
        public string OrgAuthorizerIdcardNumber { get; set; }
    
        /// <summary>
        /// \u5355\u4F4D\u6388\u6743\u4EBA\u8BC1\u4EF6\u7C7B\u578B
        /// </summary>
        /// <value>\u5355\u4F4D\u6388\u6743\u4EBA\u8BC1\u4EF6\u7C7B\u578B</value>
        [DataMember(Name="orgAuthorizerIdcardType", EmitDefaultValue=false)]
        public string OrgAuthorizerIdcardType { get; set; }
    
        /// <summary>
        /// \u5355\u4F4D\u6388\u6743\u4EBA\u59D3\u540D
        /// </summary>
        /// <value>\u5355\u4F4D\u6388\u6743\u4EBA\u59D3\u540D</value>
        [DataMember(Name="orgAuthorizerName", EmitDefaultValue=false)]
        public string OrgAuthorizerName { get; set; }
    
        /// <summary>
        /// Gets or Sets OrgAuthorizerPhone
        /// </summary>
        [DataMember(Name="orgAuthorizerPhone", EmitDefaultValue=false)]
        public string OrgAuthorizerPhone { get; set; }
    
        /// <summary>
        /// \u5355\u4F4D\u8BC1\u4EF6\u7F16\u53F7
        /// </summary>
        /// <value>\u5355\u4F4D\u8BC1\u4EF6\u7F16\u53F7</value>
        [DataMember(Name="orgIdcardNumber", EmitDefaultValue=false)]
        public string OrgIdcardNumber { get; set; }
    
        /// <summary>
        /// \u5355\u4F4D\u8BC1\u4EF6\u7C7B\u578B
        /// </summary>
        /// <value>\u5355\u4F4D\u8BC1\u4EF6\u7C7B\u578B</value>
        [DataMember(Name="orgIdcardType", EmitDefaultValue=false)]
        public string OrgIdcardType { get; set; }
    
        /// <summary>
        /// \u5355\u4F4D\u540D\u79F0
        /// </summary>
        /// <value>\u5355\u4F4D\u540D\u79F0</value>
        [DataMember(Name="orgName", EmitDefaultValue=false)]
        public string OrgName { get; set; }
    
        /// <summary>
        /// \u516C\u53F8\u7D22\u5F15
        /// </summary>
        /// <value>\u516C\u53F8\u7D22\u5F15</value>
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
            sb.Append("class Company {\n");
            sb.Append("  EmailNotice: ").Append(EmailNotice).Append("\n");
            sb.Append("  LinksignUserId: ").Append(LinksignUserId).Append("\n");
            sb.Append("  OrgAuthorizerEmail: ").Append(OrgAuthorizerEmail).Append("\n");
            sb.Append("  OrgAuthorizerIdcardNumber: ").Append(OrgAuthorizerIdcardNumber).Append("\n");
            sb.Append("  OrgAuthorizerIdcardType: ").Append(OrgAuthorizerIdcardType).Append("\n");
            sb.Append("  OrgAuthorizerName: ").Append(OrgAuthorizerName).Append("\n");
            sb.Append("  OrgAuthorizerPhone: ").Append(OrgAuthorizerPhone).Append("\n");
            sb.Append("  OrgIdcardNumber: ").Append(OrgIdcardNumber).Append("\n");
            sb.Append("  OrgIdcardType: ").Append(OrgIdcardType).Append("\n");
            sb.Append("  OrgName: ").Append(OrgName).Append("\n");
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
            return this.Equals(obj as Company);
        }

        /// <summary>
        /// Returns true if Company instances are equal
        /// </summary>
        /// <param name="other">Instance of Company to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Company other)
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
                    this.OrgAuthorizerEmail == other.OrgAuthorizerEmail ||
                    this.OrgAuthorizerEmail != null &&
                    this.OrgAuthorizerEmail.Equals(other.OrgAuthorizerEmail)
                ) && 
                (
                    this.OrgAuthorizerIdcardNumber == other.OrgAuthorizerIdcardNumber ||
                    this.OrgAuthorizerIdcardNumber != null &&
                    this.OrgAuthorizerIdcardNumber.Equals(other.OrgAuthorizerIdcardNumber)
                ) && 
                (
                    this.OrgAuthorizerIdcardType == other.OrgAuthorizerIdcardType ||
                    this.OrgAuthorizerIdcardType != null &&
                    this.OrgAuthorizerIdcardType.Equals(other.OrgAuthorizerIdcardType)
                ) && 
                (
                    this.OrgAuthorizerName == other.OrgAuthorizerName ||
                    this.OrgAuthorizerName != null &&
                    this.OrgAuthorizerName.Equals(other.OrgAuthorizerName)
                ) && 
                (
                    this.OrgAuthorizerPhone == other.OrgAuthorizerPhone ||
                    this.OrgAuthorizerPhone != null &&
                    this.OrgAuthorizerPhone.Equals(other.OrgAuthorizerPhone)
                ) && 
                (
                    this.OrgIdcardNumber == other.OrgIdcardNumber ||
                    this.OrgIdcardNumber != null &&
                    this.OrgIdcardNumber.Equals(other.OrgIdcardNumber)
                ) && 
                (
                    this.OrgIdcardType == other.OrgIdcardType ||
                    this.OrgIdcardType != null &&
                    this.OrgIdcardType.Equals(other.OrgIdcardType)
                ) && 
                (
                    this.OrgName == other.OrgName ||
                    this.OrgName != null &&
                    this.OrgName.Equals(other.OrgName)
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
                
                if (this.OrgAuthorizerEmail != null)
                    hash = hash * 59 + this.OrgAuthorizerEmail.GetHashCode();
                
                if (this.OrgAuthorizerIdcardNumber != null)
                    hash = hash * 59 + this.OrgAuthorizerIdcardNumber.GetHashCode();
                
                if (this.OrgAuthorizerIdcardType != null)
                    hash = hash * 59 + this.OrgAuthorizerIdcardType.GetHashCode();
                
                if (this.OrgAuthorizerName != null)
                    hash = hash * 59 + this.OrgAuthorizerName.GetHashCode();
                
                if (this.OrgAuthorizerPhone != null)
                    hash = hash * 59 + this.OrgAuthorizerPhone.GetHashCode();
                
                if (this.OrgIdcardNumber != null)
                    hash = hash * 59 + this.OrgIdcardNumber.GetHashCode();
                
                if (this.OrgIdcardType != null)
                    hash = hash * 59 + this.OrgIdcardType.GetHashCode();
                
                if (this.OrgName != null)
                    hash = hash * 59 + this.OrgName.GetHashCode();
                
                if (this.RecipientIndex != null)
                    hash = hash * 59 + this.RecipientIndex.GetHashCode();
                
                if (this.SmsNotice != null)
                    hash = hash * 59 + this.SmsNotice.GetHashCode();
                
                return hash;
            }
        }

    }
}
