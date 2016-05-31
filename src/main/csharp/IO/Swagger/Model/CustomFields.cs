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
    /// Custom Fields PDF form
    /// </summary>
    [DataContract]
    public partial class CustomFields :  IEquatable<CustomFields>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomFields" /> class.
        /// Initializes a new instance of the <see cref="CustomFields" />class.
        /// </summary>
        /// <param name="ImageCustomFields">Custom picture field.</param>
        /// <param name="TextCustomFields">\u5B57\u6BB5\u4E32\u5B57\u6BB5.</param>

        public CustomFields(List<ImageCustomField> ImageCustomFields = null, List<TextCustomField> TextCustomFields = null)
        {
            this.ImageCustomFields = ImageCustomFields;
            this.TextCustomFields = TextCustomFields;
            
        }
        
    
        /// <summary>
        /// Custom picture field
        /// </summary>
        /// <value>Custom picture field</value>
        [DataMember(Name="imageCustomFields", EmitDefaultValue=false)]
        public List<ImageCustomField> ImageCustomFields { get; set; }
    
        /// <summary>
        /// \u5B57\u6BB5\u4E32\u5B57\u6BB5
        /// </summary>
        /// <value>\u5B57\u6BB5\u4E32\u5B57\u6BB5</value>
        [DataMember(Name="textCustomFields", EmitDefaultValue=false)]
        public List<TextCustomField> TextCustomFields { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomFields {\n");
            sb.Append("  ImageCustomFields: ").Append(ImageCustomFields).Append("\n");
            sb.Append("  TextCustomFields: ").Append(TextCustomFields).Append("\n");
            
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
            return this.Equals(obj as CustomFields);
        }

        /// <summary>
        /// Returns true if CustomFields instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomFields other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ImageCustomFields == other.ImageCustomFields ||
                    this.ImageCustomFields != null &&
                    this.ImageCustomFields.SequenceEqual(other.ImageCustomFields)
                ) && 
                (
                    this.TextCustomFields == other.TextCustomFields ||
                    this.TextCustomFields != null &&
                    this.TextCustomFields.SequenceEqual(other.TextCustomFields)
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
                
                if (this.ImageCustomFields != null)
                    hash = hash * 59 + this.ImageCustomFields.GetHashCode();
                
                if (this.TextCustomFields != null)
                    hash = hash * 59 + this.TextCustomFields.GetHashCode();
                
                return hash;
            }
        }

    }
}
