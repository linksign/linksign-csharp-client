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
    /// \u5FAE\u4FE1\u63A5\u6536\u8005\u4FE1\u606F
    /// </summary>
    [DataContract]
    public partial class WechatRecipient :  IEquatable<WechatRecipient>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WechatRecipient" /> class.
        /// Initializes a new instance of the <see cref="WechatRecipient" />class.
        /// </summary>
        /// <param name="Name">\u59D3\u540D.</param>
        /// <param name="OpenId">\u516C\u4F17\u53F7\u552F\u4E00\u6807\u8BC6.</param>

        public WechatRecipient(string Name = null, string OpenId = null)
        {
            this.Name = Name;
            this.OpenId = OpenId;
            
        }
        
    
        /// <summary>
        /// \u59D3\u540D
        /// </summary>
        /// <value>\u59D3\u540D</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// \u516C\u4F17\u53F7\u552F\u4E00\u6807\u8BC6
        /// </summary>
        /// <value>\u516C\u4F17\u53F7\u552F\u4E00\u6807\u8BC6</value>
        [DataMember(Name="openId", EmitDefaultValue=false)]
        public string OpenId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WechatRecipient {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            
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
            return this.Equals(obj as WechatRecipient);
        }

        /// <summary>
        /// Returns true if WechatRecipient instances are equal
        /// </summary>
        /// <param name="other">Instance of WechatRecipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WechatRecipient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OpenId == other.OpenId ||
                    this.OpenId != null &&
                    this.OpenId.Equals(other.OpenId)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.OpenId != null)
                    hash = hash * 59 + this.OpenId.GetHashCode();
                
                return hash;
            }
        }

    }
}
