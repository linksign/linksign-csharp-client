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
    /// \u7B7E\u7F72\u6587\u6863\u5B9A\u4E49
    /// </summary>
    [DataContract]
    public partial class DocumentDefinition :  IEquatable<DocumentDefinition>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentDefinition" /> class.
        /// Initializes a new instance of the <see cref="DocumentDefinition" />class.
        /// </summary>
        /// <param name="App">Application configuration.</param>
        /// <param name="CustomFields">\u81EA\u5B9A\u4E49\u5B57\u6BB5.</param>
        /// <param name="Documents">\u5F85\u7B7E\u7F72\u7684\u6587\u6863\u5217\u8868.</param>
        /// <param name="ExtraRecipients">\u5176\u5B83\u63A5\u6536\u4EBA.</param>
        /// <param name="IdAuth">Signature authentication.</param>
        /// <param name="Signers">\u7B7E\u7F72\u4EBA.</param>
        /// <param name="TemplateId">Custom template number.</param>

        public DocumentDefinition(App App = null, CustomFields CustomFields = null, List<Document> Documents = null, ExtraRecipients ExtraRecipients = null, IdAuth IdAuth = null, Signers Signers = null, string TemplateId = null)
        {
            this.App = App;
            this.CustomFields = CustomFields;
            this.Documents = Documents;
            this.ExtraRecipients = ExtraRecipients;
            this.IdAuth = IdAuth;
            this.Signers = Signers;
            this.TemplateId = TemplateId;
            
        }
        
    
        /// <summary>
        /// Application configuration
        /// </summary>
        /// <value>Application configuration</value>
        [DataMember(Name="app", EmitDefaultValue=false)]
        public App App { get; set; }
    
        /// <summary>
        /// \u81EA\u5B9A\u4E49\u5B57\u6BB5
        /// </summary>
        /// <value>\u81EA\u5B9A\u4E49\u5B57\u6BB5</value>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public CustomFields CustomFields { get; set; }
    
        /// <summary>
        /// \u5F85\u7B7E\u7F72\u7684\u6587\u6863\u5217\u8868
        /// </summary>
        /// <value>\u5F85\u7B7E\u7F72\u7684\u6587\u6863\u5217\u8868</value>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<Document> Documents { get; set; }
    
        /// <summary>
        /// \u5176\u5B83\u63A5\u6536\u4EBA
        /// </summary>
        /// <value>\u5176\u5B83\u63A5\u6536\u4EBA</value>
        [DataMember(Name="extraRecipients", EmitDefaultValue=false)]
        public ExtraRecipients ExtraRecipients { get; set; }
    
        /// <summary>
        /// Signature authentication
        /// </summary>
        /// <value>Signature authentication</value>
        [DataMember(Name="idAuth", EmitDefaultValue=false)]
        public IdAuth IdAuth { get; set; }
    
        /// <summary>
        /// \u7B7E\u7F72\u4EBA
        /// </summary>
        /// <value>\u7B7E\u7F72\u4EBA</value>
        [DataMember(Name="signers", EmitDefaultValue=false)]
        public Signers Signers { get; set; }
    
        /// <summary>
        /// Custom template number
        /// </summary>
        /// <value>Custom template number</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentDefinition {\n");
            sb.Append("  App: ").Append(App).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  ExtraRecipients: ").Append(ExtraRecipients).Append("\n");
            sb.Append("  IdAuth: ").Append(IdAuth).Append("\n");
            sb.Append("  Signers: ").Append(Signers).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            
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
            return this.Equals(obj as DocumentDefinition);
        }

        /// <summary>
        /// Returns true if DocumentDefinition instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.App == other.App ||
                    this.App != null &&
                    this.App.Equals(other.App)
                ) && 
                (
                    this.CustomFields == other.CustomFields ||
                    this.CustomFields != null &&
                    this.CustomFields.Equals(other.CustomFields)
                ) && 
                (
                    this.Documents == other.Documents ||
                    this.Documents != null &&
                    this.Documents.SequenceEqual(other.Documents)
                ) && 
                (
                    this.ExtraRecipients == other.ExtraRecipients ||
                    this.ExtraRecipients != null &&
                    this.ExtraRecipients.Equals(other.ExtraRecipients)
                ) && 
                (
                    this.IdAuth == other.IdAuth ||
                    this.IdAuth != null &&
                    this.IdAuth.Equals(other.IdAuth)
                ) && 
                (
                    this.Signers == other.Signers ||
                    this.Signers != null &&
                    this.Signers.Equals(other.Signers)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
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
                
                if (this.App != null)
                    hash = hash * 59 + this.App.GetHashCode();
                
                if (this.CustomFields != null)
                    hash = hash * 59 + this.CustomFields.GetHashCode();
                
                if (this.Documents != null)
                    hash = hash * 59 + this.Documents.GetHashCode();
                
                if (this.ExtraRecipients != null)
                    hash = hash * 59 + this.ExtraRecipients.GetHashCode();
                
                if (this.IdAuth != null)
                    hash = hash * 59 + this.IdAuth.GetHashCode();
                
                if (this.Signers != null)
                    hash = hash * 59 + this.Signers.GetHashCode();
                
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                
                return hash;
            }
        }

    }
}
