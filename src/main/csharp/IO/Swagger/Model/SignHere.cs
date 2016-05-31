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
    /// \u7B7E\u7F72\u4F4D\u7F6E\u4FE1\u606F
    /// </summary>
    [DataContract]
    public partial class SignHere :  IEquatable<SignHere>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SignHere" /> class.
        /// Initializes a new instance of the <see cref="SignHere" />class.
        /// </summary>
        /// <param name="DocumentIndex">\u7B7E\u540D\u6587\u4EF6\u7D22\u5F15\uFF0C \u4E0EDocument\u5BF9\u5E94.</param>
        /// <param name="Height">\u7B7E\u7F72\u533A\u57DF\u9AD8\u5EA6.</param>
        /// <param name="PageNumber">PageNumber.</param>
        /// <param name="RecipientIndex">\u7B7E\u7F72\u4EBA\u7D22\u5F15.</param>
        /// <param name="SealHeight">\u5370\u7AE0\u9AD8\u5EA6.</param>
        /// <param name="SealId">\u5370\u7AE0\u7F16\u53F7.</param>
        /// <param name="SealPageNumber">\u5370\u7AE0\u9875\u7801.</param>
        /// <param name="SealWidth">\u5370\u7AE0\u5BBD\u5EA6.</param>
        /// <param name="SealXPosition">\u5370\u7AE0X\u5750\u6807.</param>
        /// <param name="SealYPosition">\u5370\u7AE0Y\u5750\u6807.</param>
        /// <param name="SignatureId">\u7B7E\u540D\u7F16\u53F7.</param>
        /// <param name="TemplateSealFieldId">\u6A21\u677F\u516C\u7AE0\u5B57\u6BB5\u540D.</param>
        /// <param name="TemplateSignatureFieldId">\u6A21\u677F\u7B7E\u540D\u5B57\u6BB5\u540D.</param>
        /// <param name="Width">\u7B7E\u540D\u57DF\u5BBD\u5EA6.</param>
        /// <param name="XPosition">x\u5750\u6807.</param>
        /// <param name="YPosition">y\u5750\u6807.</param>

        public SignHere(string DocumentIndex = null, int? Height = null, int? PageNumber = null, string RecipientIndex = null, int? SealHeight = null, string SealId = null, int? SealPageNumber = null, int? SealWidth = null, int? SealXPosition = null, int? SealYPosition = null, string SignatureId = null, string TemplateSealFieldId = null, string TemplateSignatureFieldId = null, int? Width = null, int? XPosition = null, int? YPosition = null)
        {
            this.DocumentIndex = DocumentIndex;
            this.Height = Height;
            this.PageNumber = PageNumber;
            this.RecipientIndex = RecipientIndex;
            this.SealHeight = SealHeight;
            this.SealId = SealId;
            this.SealPageNumber = SealPageNumber;
            this.SealWidth = SealWidth;
            this.SealXPosition = SealXPosition;
            this.SealYPosition = SealYPosition;
            this.SignatureId = SignatureId;
            this.TemplateSealFieldId = TemplateSealFieldId;
            this.TemplateSignatureFieldId = TemplateSignatureFieldId;
            this.Width = Width;
            this.XPosition = XPosition;
            this.YPosition = YPosition;
            
        }
        
    
        /// <summary>
        /// \u7B7E\u540D\u6587\u4EF6\u7D22\u5F15\uFF0C \u4E0EDocument\u5BF9\u5E94
        /// </summary>
        /// <value>\u7B7E\u540D\u6587\u4EF6\u7D22\u5F15\uFF0C \u4E0EDocument\u5BF9\u5E94</value>
        [DataMember(Name="documentIndex", EmitDefaultValue=false)]
        public string DocumentIndex { get; set; }
    
        /// <summary>
        /// \u7B7E\u7F72\u533A\u57DF\u9AD8\u5EA6
        /// </summary>
        /// <value>\u7B7E\u7F72\u533A\u57DF\u9AD8\u5EA6</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }
    
        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
    
        /// <summary>
        /// \u7B7E\u7F72\u4EBA\u7D22\u5F15
        /// </summary>
        /// <value>\u7B7E\u7F72\u4EBA\u7D22\u5F15</value>
        [DataMember(Name="recipientIndex", EmitDefaultValue=false)]
        public string RecipientIndex { get; set; }
    
        /// <summary>
        /// \u5370\u7AE0\u9AD8\u5EA6
        /// </summary>
        /// <value>\u5370\u7AE0\u9AD8\u5EA6</value>
        [DataMember(Name="sealHeight", EmitDefaultValue=false)]
        public int? SealHeight { get; set; }
    
        /// <summary>
        /// \u5370\u7AE0\u7F16\u53F7
        /// </summary>
        /// <value>\u5370\u7AE0\u7F16\u53F7</value>
        [DataMember(Name="sealId", EmitDefaultValue=false)]
        public string SealId { get; set; }
    
        /// <summary>
        /// \u5370\u7AE0\u9875\u7801
        /// </summary>
        /// <value>\u5370\u7AE0\u9875\u7801</value>
        [DataMember(Name="sealPageNumber", EmitDefaultValue=false)]
        public int? SealPageNumber { get; set; }
    
        /// <summary>
        /// \u5370\u7AE0\u5BBD\u5EA6
        /// </summary>
        /// <value>\u5370\u7AE0\u5BBD\u5EA6</value>
        [DataMember(Name="sealWidth", EmitDefaultValue=false)]
        public int? SealWidth { get; set; }
    
        /// <summary>
        /// \u5370\u7AE0X\u5750\u6807
        /// </summary>
        /// <value>\u5370\u7AE0X\u5750\u6807</value>
        [DataMember(Name="sealXPosition", EmitDefaultValue=false)]
        public int? SealXPosition { get; set; }
    
        /// <summary>
        /// \u5370\u7AE0Y\u5750\u6807
        /// </summary>
        /// <value>\u5370\u7AE0Y\u5750\u6807</value>
        [DataMember(Name="sealYPosition", EmitDefaultValue=false)]
        public int? SealYPosition { get; set; }
    
        /// <summary>
        /// \u7B7E\u540D\u7F16\u53F7
        /// </summary>
        /// <value>\u7B7E\u540D\u7F16\u53F7</value>
        [DataMember(Name="signatureId", EmitDefaultValue=false)]
        public string SignatureId { get; set; }
    
        /// <summary>
        /// \u6A21\u677F\u516C\u7AE0\u5B57\u6BB5\u540D
        /// </summary>
        /// <value>\u6A21\u677F\u516C\u7AE0\u5B57\u6BB5\u540D</value>
        [DataMember(Name="templateSealFieldId", EmitDefaultValue=false)]
        public string TemplateSealFieldId { get; set; }
    
        /// <summary>
        /// \u6A21\u677F\u7B7E\u540D\u5B57\u6BB5\u540D
        /// </summary>
        /// <value>\u6A21\u677F\u7B7E\u540D\u5B57\u6BB5\u540D</value>
        [DataMember(Name="templateSignatureFieldId", EmitDefaultValue=false)]
        public string TemplateSignatureFieldId { get; set; }
    
        /// <summary>
        /// \u7B7E\u540D\u57DF\u5BBD\u5EA6
        /// </summary>
        /// <value>\u7B7E\u540D\u57DF\u5BBD\u5EA6</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }
    
        /// <summary>
        /// x\u5750\u6807
        /// </summary>
        /// <value>x\u5750\u6807</value>
        [DataMember(Name="xPosition", EmitDefaultValue=false)]
        public int? XPosition { get; set; }
    
        /// <summary>
        /// y\u5750\u6807
        /// </summary>
        /// <value>y\u5750\u6807</value>
        [DataMember(Name="yPosition", EmitDefaultValue=false)]
        public int? YPosition { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignHere {\n");
            sb.Append("  DocumentIndex: ").Append(DocumentIndex).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  RecipientIndex: ").Append(RecipientIndex).Append("\n");
            sb.Append("  SealHeight: ").Append(SealHeight).Append("\n");
            sb.Append("  SealId: ").Append(SealId).Append("\n");
            sb.Append("  SealPageNumber: ").Append(SealPageNumber).Append("\n");
            sb.Append("  SealWidth: ").Append(SealWidth).Append("\n");
            sb.Append("  SealXPosition: ").Append(SealXPosition).Append("\n");
            sb.Append("  SealYPosition: ").Append(SealYPosition).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  TemplateSealFieldId: ").Append(TemplateSealFieldId).Append("\n");
            sb.Append("  TemplateSignatureFieldId: ").Append(TemplateSignatureFieldId).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  XPosition: ").Append(XPosition).Append("\n");
            sb.Append("  YPosition: ").Append(YPosition).Append("\n");
            
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
            return this.Equals(obj as SignHere);
        }

        /// <summary>
        /// Returns true if SignHere instances are equal
        /// </summary>
        /// <param name="other">Instance of SignHere to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignHere other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocumentIndex == other.DocumentIndex ||
                    this.DocumentIndex != null &&
                    this.DocumentIndex.Equals(other.DocumentIndex)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) && 
                (
                    this.RecipientIndex == other.RecipientIndex ||
                    this.RecipientIndex != null &&
                    this.RecipientIndex.Equals(other.RecipientIndex)
                ) && 
                (
                    this.SealHeight == other.SealHeight ||
                    this.SealHeight != null &&
                    this.SealHeight.Equals(other.SealHeight)
                ) && 
                (
                    this.SealId == other.SealId ||
                    this.SealId != null &&
                    this.SealId.Equals(other.SealId)
                ) && 
                (
                    this.SealPageNumber == other.SealPageNumber ||
                    this.SealPageNumber != null &&
                    this.SealPageNumber.Equals(other.SealPageNumber)
                ) && 
                (
                    this.SealWidth == other.SealWidth ||
                    this.SealWidth != null &&
                    this.SealWidth.Equals(other.SealWidth)
                ) && 
                (
                    this.SealXPosition == other.SealXPosition ||
                    this.SealXPosition != null &&
                    this.SealXPosition.Equals(other.SealXPosition)
                ) && 
                (
                    this.SealYPosition == other.SealYPosition ||
                    this.SealYPosition != null &&
                    this.SealYPosition.Equals(other.SealYPosition)
                ) && 
                (
                    this.SignatureId == other.SignatureId ||
                    this.SignatureId != null &&
                    this.SignatureId.Equals(other.SignatureId)
                ) && 
                (
                    this.TemplateSealFieldId == other.TemplateSealFieldId ||
                    this.TemplateSealFieldId != null &&
                    this.TemplateSealFieldId.Equals(other.TemplateSealFieldId)
                ) && 
                (
                    this.TemplateSignatureFieldId == other.TemplateSignatureFieldId ||
                    this.TemplateSignatureFieldId != null &&
                    this.TemplateSignatureFieldId.Equals(other.TemplateSignatureFieldId)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.XPosition == other.XPosition ||
                    this.XPosition != null &&
                    this.XPosition.Equals(other.XPosition)
                ) && 
                (
                    this.YPosition == other.YPosition ||
                    this.YPosition != null &&
                    this.YPosition.Equals(other.YPosition)
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
                
                if (this.DocumentIndex != null)
                    hash = hash * 59 + this.DocumentIndex.GetHashCode();
                
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                
                if (this.RecipientIndex != null)
                    hash = hash * 59 + this.RecipientIndex.GetHashCode();
                
                if (this.SealHeight != null)
                    hash = hash * 59 + this.SealHeight.GetHashCode();
                
                if (this.SealId != null)
                    hash = hash * 59 + this.SealId.GetHashCode();
                
                if (this.SealPageNumber != null)
                    hash = hash * 59 + this.SealPageNumber.GetHashCode();
                
                if (this.SealWidth != null)
                    hash = hash * 59 + this.SealWidth.GetHashCode();
                
                if (this.SealXPosition != null)
                    hash = hash * 59 + this.SealXPosition.GetHashCode();
                
                if (this.SealYPosition != null)
                    hash = hash * 59 + this.SealYPosition.GetHashCode();
                
                if (this.SignatureId != null)
                    hash = hash * 59 + this.SignatureId.GetHashCode();
                
                if (this.TemplateSealFieldId != null)
                    hash = hash * 59 + this.TemplateSealFieldId.GetHashCode();
                
                if (this.TemplateSignatureFieldId != null)
                    hash = hash * 59 + this.TemplateSignatureFieldId.GetHashCode();
                
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                
                if (this.XPosition != null)
                    hash = hash * 59 + this.XPosition.GetHashCode();
                
                if (this.YPosition != null)
                    hash = hash * 59 + this.YPosition.GetHashCode();
                
                return hash;
            }
        }

    }
}
