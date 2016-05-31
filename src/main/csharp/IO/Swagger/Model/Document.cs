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
    /// \u7B7E\u7F72\u6587\u6863\u4FE1\u606F
    /// </summary>
    [DataContract]
    public partial class Document :  IEquatable<Document>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// Initializes a new instance of the <see cref="Document" />class.
        /// </summary>
        /// <param name="DocumentBase64">\u6587\u6863\u5185\u5BB9\uFF08Base64\u683C\u5F0F\uFF09 (required).</param>
        /// <param name="DocumentIndex">\u6587\u6863\u7D22\u5F15\uFF0C\u4E0ESignHere\u5BF9\u5E94.</param>
        /// <param name="FileExtension">\u6587\u6863\u540E\u7F00\uFF08\u683C\u5F0F\uFF09 (required).</param>
        /// <param name="Name">\u6587\u6863\u540D\u79F0 (required).</param>

        public Document(string DocumentBase64 = null, string DocumentIndex = null, string FileExtension = null, string Name = null)
        {
            // to ensure "DocumentBase64" is required (not null)
            if (DocumentBase64 == null)
            {
                throw new InvalidDataException("DocumentBase64 is a required property for Document and cannot be null");
            }
            else
            {
                this.DocumentBase64 = DocumentBase64;
            }
            // to ensure "FileExtension" is required (not null)
            if (FileExtension == null)
            {
                throw new InvalidDataException("FileExtension is a required property for Document and cannot be null");
            }
            else
            {
                this.FileExtension = FileExtension;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Document and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.DocumentIndex = DocumentIndex;
            
        }
        
    
        /// <summary>
        /// \u6587\u6863\u5185\u5BB9\uFF08Base64\u683C\u5F0F\uFF09
        /// </summary>
        /// <value>\u6587\u6863\u5185\u5BB9\uFF08Base64\u683C\u5F0F\uFF09</value>
        [DataMember(Name="documentBase64", EmitDefaultValue=false)]
        public string DocumentBase64 { get; set; }
    
        /// <summary>
        /// \u6587\u6863\u7D22\u5F15\uFF0C\u4E0ESignHere\u5BF9\u5E94
        /// </summary>
        /// <value>\u6587\u6863\u7D22\u5F15\uFF0C\u4E0ESignHere\u5BF9\u5E94</value>
        [DataMember(Name="documentIndex", EmitDefaultValue=false)]
        public string DocumentIndex { get; set; }
    
        /// <summary>
        /// \u6587\u6863\u540E\u7F00\uFF08\u683C\u5F0F\uFF09
        /// </summary>
        /// <value>\u6587\u6863\u540E\u7F00\uFF08\u683C\u5F0F\uFF09</value>
        [DataMember(Name="fileExtension", EmitDefaultValue=false)]
        public string FileExtension { get; set; }
    
        /// <summary>
        /// \u6587\u6863\u540D\u79F0
        /// </summary>
        /// <value>\u6587\u6863\u540D\u79F0</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  DocumentBase64: ").Append(DocumentBase64).Append("\n");
            sb.Append("  DocumentIndex: ").Append(DocumentIndex).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
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
            return this.Equals(obj as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="other">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentBase64 == other.DocumentBase64 ||
                    this.DocumentBase64 != null &&
                    this.DocumentBase64.Equals(other.DocumentBase64)
                ) && 
                (
                    this.DocumentIndex == other.DocumentIndex ||
                    this.DocumentIndex != null &&
                    this.DocumentIndex.Equals(other.DocumentIndex)
                ) && 
                (
                    this.FileExtension == other.FileExtension ||
                    this.FileExtension != null &&
                    this.FileExtension.Equals(other.FileExtension)
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
                
                if (this.DocumentBase64 != null)
                    hash = hash * 59 + this.DocumentBase64.GetHashCode();
                
                if (this.DocumentIndex != null)
                    hash = hash * 59 + this.DocumentIndex.GetHashCode();
                
                if (this.FileExtension != null)
                    hash = hash * 59 + this.FileExtension.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                return hash;
            }
        }

    }
}
