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
    /// \u6587\u6863\u7B7E\u7F72\u7ED3\u679C
    /// </summary>
    [DataContract]
    public partial class DocumentSummary :  IEquatable<DocumentSummary>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentSummary" /> class.
        /// Initializes a new instance of the <see cref="DocumentSummary" />class.
        /// </summary>
        /// <param name="DocumentId">\u7B7E\u7F72\u540E\u7684\u6587\u6863\u7F16\u53F7 (required).</param>
        /// <param name="DocumentStatus">DocumentStatus.</param>
        /// <param name="Uri">\u7B7E\u7F72\u540E\u7684\u6587\u6863\u4E0B\u8F7D\u94FE\u63A5 (required).</param>

        public DocumentSummary(string DocumentId = null, DocumentStatus DocumentStatus = null, string Uri = null)
        {
            // to ensure "DocumentId" is required (not null)
            if (DocumentId == null)
            {
                throw new InvalidDataException("DocumentId is a required property for DocumentSummary and cannot be null");
            }
            else
            {
                this.DocumentId = DocumentId;
            }
            // to ensure "Uri" is required (not null)
            if (Uri == null)
            {
                throw new InvalidDataException("Uri is a required property for DocumentSummary and cannot be null");
            }
            else
            {
                this.Uri = Uri;
            }
            this.DocumentStatus = DocumentStatus;
            
        }
        
    
        /// <summary>
        /// \u7B7E\u7F72\u540E\u7684\u6587\u6863\u7F16\u53F7
        /// </summary>
        /// <value>\u7B7E\u7F72\u540E\u7684\u6587\u6863\u7F16\u53F7</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
    
        /// <summary>
        /// Gets or Sets DocumentStatus
        /// </summary>
        [DataMember(Name="documentStatus", EmitDefaultValue=false)]
        public DocumentStatus DocumentStatus { get; set; }
    
        /// <summary>
        /// \u7B7E\u7F72\u540E\u7684\u6587\u6863\u4E0B\u8F7D\u94FE\u63A5
        /// </summary>
        /// <value>\u7B7E\u7F72\u540E\u7684\u6587\u6863\u4E0B\u8F7D\u94FE\u63A5</value>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentSummary {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentStatus: ").Append(DocumentStatus).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            
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
            return this.Equals(obj as DocumentSummary);
        }

        /// <summary>
        /// Returns true if DocumentSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.DocumentStatus == other.DocumentStatus ||
                    this.DocumentStatus != null &&
                    this.DocumentStatus.Equals(other.DocumentStatus)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                
                if (this.DocumentStatus != null)
                    hash = hash * 59 + this.DocumentStatus.GetHashCode();
                
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                
                return hash;
            }
        }

    }
}
