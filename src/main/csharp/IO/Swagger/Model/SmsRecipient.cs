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
    /// \u77ED\u4FE1\u63A5\u6536\u8005\u4FE1\u606F
    /// </summary>
    [DataContract]
    public partial class SmsRecipient :  IEquatable<SmsRecipient>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsRecipient" /> class.
        /// Initializes a new instance of the <see cref="SmsRecipient" />class.
        /// </summary>
        /// <param name="Mobile">\u624B\u673A\u53F7\u7801.</param>
        /// <param name="Name">\u59D3\u540D.</param>

        public SmsRecipient(string Mobile = null, string Name = null)
        {
            this.Mobile = Mobile;
            this.Name = Name;
            
        }
        
    
        /// <summary>
        /// \u624B\u673A\u53F7\u7801
        /// </summary>
        /// <value>\u624B\u673A\u53F7\u7801</value>
        [DataMember(Name="mobile", EmitDefaultValue=false)]
        public string Mobile { get; set; }
    
        /// <summary>
        /// \u59D3\u540D
        /// </summary>
        /// <value>\u59D3\u540D</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsRecipient {\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            
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
            return this.Equals(obj as SmsRecipient);
        }

        /// <summary>
        /// Returns true if SmsRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of SmsRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsRecipient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Mobile == other.Mobile ||
                    this.Mobile != null &&
                    this.Mobile.Equals(other.Mobile)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                
                if (this.Mobile != null)
                    hash = hash * 59 + this.Mobile.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
