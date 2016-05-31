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
    /// Custom fields for image type
    /// </summary>
    [DataContract]
    public partial class ImageCustomField :  IEquatable<ImageCustomField>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCustomField" /> class.
        /// Initializes a new instance of the <see cref="ImageCustomField" />class.
        /// </summary>
        /// <param name="FieldId">Custom field id.</param>
        /// <param name="ImageBase64">Base64 image file format.</param>
        /// <param name="SealId">user seal ID.</param>
        /// <param name="SignatureId">user signature ID.</param>

        public ImageCustomField(string FieldId = null, string ImageBase64 = null, string SealId = null, string SignatureId = null)
        {
            this.FieldId = FieldId;
            this.ImageBase64 = ImageBase64;
            this.SealId = SealId;
            this.SignatureId = SignatureId;
            
        }
        
    
        /// <summary>
        /// Custom field id
        /// </summary>
        /// <value>Custom field id</value>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }
    
        /// <summary>
        /// Base64 image file format
        /// </summary>
        /// <value>Base64 image file format</value>
        [DataMember(Name="imageBase64", EmitDefaultValue=false)]
        public string ImageBase64 { get; set; }
    
        /// <summary>
        /// user seal ID
        /// </summary>
        /// <value>user seal ID</value>
        [DataMember(Name="sealId", EmitDefaultValue=false)]
        public string SealId { get; set; }
    
        /// <summary>
        /// user signature ID
        /// </summary>
        /// <value>user signature ID</value>
        [DataMember(Name="signatureId", EmitDefaultValue=false)]
        public string SignatureId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageCustomField {\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
            sb.Append("  ImageBase64: ").Append(ImageBase64).Append("\n");
            sb.Append("  SealId: ").Append(SealId).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            
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
            return this.Equals(obj as ImageCustomField);
        }

        /// <summary>
        /// Returns true if ImageCustomField instances are equal
        /// </summary>
        /// <param name="other">Instance of ImageCustomField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageCustomField other)
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
                    this.ImageBase64 == other.ImageBase64 ||
                    this.ImageBase64 != null &&
                    this.ImageBase64.Equals(other.ImageBase64)
                ) && 
                (
                    this.SealId == other.SealId ||
                    this.SealId != null &&
                    this.SealId.Equals(other.SealId)
                ) && 
                (
                    this.SignatureId == other.SignatureId ||
                    this.SignatureId != null &&
                    this.SignatureId.Equals(other.SignatureId)
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
                
                if (this.ImageBase64 != null)
                    hash = hash * 59 + this.ImageBase64.GetHashCode();
                
                if (this.SealId != null)
                    hash = hash * 59 + this.SealId.GetHashCode();
                
                if (this.SignatureId != null)
                    hash = hash * 59 + this.SignatureId.GetHashCode();
                
                return hash;
            }
        }

    }
}
