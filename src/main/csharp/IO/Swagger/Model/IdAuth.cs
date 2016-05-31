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
    /// Signature identity authentication
    /// </summary>
    [DataContract]
    public partial class IdAuth :  IEquatable<IdAuth>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IdAuth" /> class.
        /// Initializes a new instance of the <see cref="IdAuth" />class.
        /// </summary>
        /// <param name="BankAccountRequred">***true***,***false***.</param>
        /// <param name="EmailRequred">***true***,***false***.</param>
        /// <param name="FaceCompareRequred">***true***,***false***.</param>
        /// <param name="IdNumberRequred">***true***,***false***.</param>
        /// <param name="SmsRequred">***true***,***false***.</param>
        /// <param name="WechatRequred">*** true ***,***false***.</param>

        public IdAuth(string BankAccountRequred = null, string EmailRequred = null, string FaceCompareRequred = null, string IdNumberRequred = null, string SmsRequred = null, string WechatRequred = null)
        {
            this.BankAccountRequred = BankAccountRequred;
            this.EmailRequred = EmailRequred;
            this.FaceCompareRequred = FaceCompareRequred;
            this.IdNumberRequred = IdNumberRequred;
            this.SmsRequred = SmsRequred;
            this.WechatRequred = WechatRequred;
            
        }
        
    
        /// <summary>
        /// ***true***,***false***
        /// </summary>
        /// <value>***true***,***false***</value>
        [DataMember(Name="bankAccountRequred", EmitDefaultValue=false)]
        public string BankAccountRequred { get; set; }
    
        /// <summary>
        /// ***true***,***false***
        /// </summary>
        /// <value>***true***,***false***</value>
        [DataMember(Name="emailRequred", EmitDefaultValue=false)]
        public string EmailRequred { get; set; }
    
        /// <summary>
        /// ***true***,***false***
        /// </summary>
        /// <value>***true***,***false***</value>
        [DataMember(Name="faceCompareRequred", EmitDefaultValue=false)]
        public string FaceCompareRequred { get; set; }
    
        /// <summary>
        /// ***true***,***false***
        /// </summary>
        /// <value>***true***,***false***</value>
        [DataMember(Name="idNumberRequred", EmitDefaultValue=false)]
        public string IdNumberRequred { get; set; }
    
        /// <summary>
        /// ***true***,***false***
        /// </summary>
        /// <value>***true***,***false***</value>
        [DataMember(Name="smsRequred", EmitDefaultValue=false)]
        public string SmsRequred { get; set; }
    
        /// <summary>
        /// *** true ***,***false***
        /// </summary>
        /// <value>*** true ***,***false***</value>
        [DataMember(Name="wechatRequred", EmitDefaultValue=false)]
        public string WechatRequred { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdAuth {\n");
            sb.Append("  BankAccountRequred: ").Append(BankAccountRequred).Append("\n");
            sb.Append("  EmailRequred: ").Append(EmailRequred).Append("\n");
            sb.Append("  FaceCompareRequred: ").Append(FaceCompareRequred).Append("\n");
            sb.Append("  IdNumberRequred: ").Append(IdNumberRequred).Append("\n");
            sb.Append("  SmsRequred: ").Append(SmsRequred).Append("\n");
            sb.Append("  WechatRequred: ").Append(WechatRequred).Append("\n");
            
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
            return this.Equals(obj as IdAuth);
        }

        /// <summary>
        /// Returns true if IdAuth instances are equal
        /// </summary>
        /// <param name="other">Instance of IdAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdAuth other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BankAccountRequred == other.BankAccountRequred ||
                    this.BankAccountRequred != null &&
                    this.BankAccountRequred.Equals(other.BankAccountRequred)
                ) && 
                (
                    this.EmailRequred == other.EmailRequred ||
                    this.EmailRequred != null &&
                    this.EmailRequred.Equals(other.EmailRequred)
                ) && 
                (
                    this.FaceCompareRequred == other.FaceCompareRequred ||
                    this.FaceCompareRequred != null &&
                    this.FaceCompareRequred.Equals(other.FaceCompareRequred)
                ) && 
                (
                    this.IdNumberRequred == other.IdNumberRequred ||
                    this.IdNumberRequred != null &&
                    this.IdNumberRequred.Equals(other.IdNumberRequred)
                ) && 
                (
                    this.SmsRequred == other.SmsRequred ||
                    this.SmsRequred != null &&
                    this.SmsRequred.Equals(other.SmsRequred)
                ) && 
                (
                    this.WechatRequred == other.WechatRequred ||
                    this.WechatRequred != null &&
                    this.WechatRequred.Equals(other.WechatRequred)
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
                
                if (this.BankAccountRequred != null)
                    hash = hash * 59 + this.BankAccountRequred.GetHashCode();
                
                if (this.EmailRequred != null)
                    hash = hash * 59 + this.EmailRequred.GetHashCode();
                
                if (this.FaceCompareRequred != null)
                    hash = hash * 59 + this.FaceCompareRequred.GetHashCode();
                
                if (this.IdNumberRequred != null)
                    hash = hash * 59 + this.IdNumberRequred.GetHashCode();
                
                if (this.SmsRequred != null)
                    hash = hash * 59 + this.SmsRequred.GetHashCode();
                
                if (this.WechatRequred != null)
                    hash = hash * 59 + this.WechatRequred.GetHashCode();
                
                return hash;
            }
        }

    }
}
