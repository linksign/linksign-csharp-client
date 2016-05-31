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
    /// \u81EA\u5B9A\u4E49\u5B57\u6BB5
    /// </summary>
    [DataContract]
    public partial class TextCustomField :  IEquatable<TextCustomField>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TextCustomField" /> class.
        /// Initializes a new instance of the <see cref="TextCustomField" />class.
        /// </summary>
        /// <param name="FieldId">\u7528\u6237\u81EA\u5B9A\u4E49\u7684\u5B57\u6BB5\u7F16\u53F7 (required).</param>
        /// <param name="Value">\u5185\u5BB9 (required).</param>

        public TextCustomField(string FieldId = null, string Value = null)
        {
            // to ensure "FieldId" is required (not null)
            if (FieldId == null)
            {
                throw new InvalidDataException("FieldId is a required property for TextCustomField and cannot be null");
            }
            else
            {
                this.FieldId = FieldId;
            }
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for TextCustomField and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            
        }
        
    
        /// <summary>
        /// \u7528\u6237\u81EA\u5B9A\u4E49\u7684\u5B57\u6BB5\u7F16\u53F7
        /// </summary>
        /// <value>\u7528\u6237\u81EA\u5B9A\u4E49\u7684\u5B57\u6BB5\u7F16\u53F7</value>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }
    
        /// <summary>
        /// \u5185\u5BB9
        /// </summary>
        /// <value>\u5185\u5BB9</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextCustomField {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            
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
            return this.Equals(obj as TextCustomField);
        }

        /// <summary>
        /// Returns true if TextCustomField instances are equal
        /// </summary>
        /// <param name="other">Instance of TextCustomField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextCustomField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FieldId == other.FieldId ||
                    this.FieldId != null &&
                    this.FieldId.Equals(other.FieldId)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                
                if (this.FieldId != null)
                    hash = hash * 59 + this.FieldId.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                return hash;
            }
        }

    }
}
