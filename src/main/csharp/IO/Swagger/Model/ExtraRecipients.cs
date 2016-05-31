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
    /// \u5176\u5B83\u63A5\u6536\u4EBA
    /// </summary>
    [DataContract]
    public partial class ExtraRecipients :  IEquatable<ExtraRecipients>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtraRecipients" /> class.
        /// Initializes a new instance of the <see cref="ExtraRecipients" />class.
        /// </summary>
        /// <param name="EmaiRecipients">\u6240\u6709\u90AE\u4EF6\u63A5\u6536\u8005.</param>
        /// <param name="SmsRecipients">\u6240\u6709\u77ED\u4FE1\u63A5\u6536\u8005.</param>
        /// <param name="WechatRecipients">\u6240\u6709\u5FAE\u4FE1\u63A5\u6536\u8005.</param>

        public ExtraRecipients(List<EmailRecipient> EmaiRecipients = null, List<SmsRecipient> SmsRecipients = null, List<WechatRecipient> WechatRecipients = null)
        {
            this.EmaiRecipients = EmaiRecipients;
            this.SmsRecipients = SmsRecipients;
            this.WechatRecipients = WechatRecipients;
            
        }
        
    
        /// <summary>
        /// \u6240\u6709\u90AE\u4EF6\u63A5\u6536\u8005
        /// </summary>
        /// <value>\u6240\u6709\u90AE\u4EF6\u63A5\u6536\u8005</value>
        [DataMember(Name="emaiRecipients", EmitDefaultValue=false)]
        public List<EmailRecipient> EmaiRecipients { get; set; }
    
        /// <summary>
        /// \u6240\u6709\u77ED\u4FE1\u63A5\u6536\u8005
        /// </summary>
        /// <value>\u6240\u6709\u77ED\u4FE1\u63A5\u6536\u8005</value>
        [DataMember(Name="smsRecipients", EmitDefaultValue=false)]
        public List<SmsRecipient> SmsRecipients { get; set; }
    
        /// <summary>
        /// \u6240\u6709\u5FAE\u4FE1\u63A5\u6536\u8005
        /// </summary>
        /// <value>\u6240\u6709\u5FAE\u4FE1\u63A5\u6536\u8005</value>
        [DataMember(Name="wechatRecipients", EmitDefaultValue=false)]
        public List<WechatRecipient> WechatRecipients { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtraRecipients {\n");
            sb.Append("  EmaiRecipients: ").Append(EmaiRecipients).Append("\n");
            sb.Append("  SmsRecipients: ").Append(SmsRecipients).Append("\n");
            sb.Append("  WechatRecipients: ").Append(WechatRecipients).Append("\n");
            
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
            return this.Equals(obj as ExtraRecipients);
        }

        /// <summary>
        /// Returns true if ExtraRecipients instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtraRecipients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtraRecipients other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmaiRecipients == other.EmaiRecipients ||
                    this.EmaiRecipients != null &&
                    this.EmaiRecipients.SequenceEqual(other.EmaiRecipients)
                ) && 
                (
                    this.SmsRecipients == other.SmsRecipients ||
                    this.SmsRecipients != null &&
                    this.SmsRecipients.SequenceEqual(other.SmsRecipients)
                ) && 
                (
                    this.WechatRecipients == other.WechatRecipients ||
                    this.WechatRecipients != null &&
                    this.WechatRecipients.SequenceEqual(other.WechatRecipients)
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
                
                if (this.EmaiRecipients != null)
                    hash = hash * 59 + this.EmaiRecipients.GetHashCode();
                
                if (this.SmsRecipients != null)
                    hash = hash * 59 + this.SmsRecipients.GetHashCode();
                
                if (this.WechatRecipients != null)
                    hash = hash * 59 + this.WechatRecipients.GetHashCode();
                
                return hash;
            }
        }

    }
}
