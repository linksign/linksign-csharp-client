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
    public partial class SignatureFile :  IEquatable<SignatureFile>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureFile" /> class.
        /// Initializes a new instance of the <see cref="SignatureFile" />class.
        /// </summary>
        /// <param name="ImagePngBase64">ImagePngBase64.</param>

        public SignatureFile(string ImagePngBase64 = null)
        {
            this.ImagePngBase64 = ImagePngBase64;
            
        }
        
    
        /// <summary>
        /// Gets or Sets ImagePngBase64
        /// </summary>
        [DataMember(Name="imagePngBase64", EmitDefaultValue=false)]
        public string ImagePngBase64 { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignatureFile {\n");
            sb.Append("  ImagePngBase64: ").Append(ImagePngBase64).Append("\n");
            
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
            return this.Equals(obj as SignatureFile);
        }

        /// <summary>
        /// Returns true if SignatureFile instances are equal
        /// </summary>
        /// <param name="other">Instance of SignatureFile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignatureFile other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ImagePngBase64 == other.ImagePngBase64 ||
                    this.ImagePngBase64 != null &&
                    this.ImagePngBase64.Equals(other.ImagePngBase64)
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
                
                if (this.ImagePngBase64 != null)
                    hash = hash * 59 + this.ImagePngBase64.GetHashCode();
                
                return hash;
            }
        }

    }
}
