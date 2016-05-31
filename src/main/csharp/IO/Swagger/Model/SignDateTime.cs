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
    /// \u7B7E\u7F72\u65F6\u95F4\u4FE1\u606F
    /// </summary>
    [DataContract]
    public partial class SignDateTime :  IEquatable<SignDateTime>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SignDateTime" /> class.
        /// Initializes a new instance of the <see cref="SignDateTime" />class.
        /// </summary>
        /// <param name="DateTimePattern">\u65F6\u95F4\u663E\u793A\u683C\u5F0F.</param>
        /// <param name="DocumentIndex">\u6587\u6863\u7D22\u5F15.</param>
        /// <param name="FontName">\u5B57\u4F53\u540D\u79F0.</param>
        /// <param name="FontSize">\u5B57\u4F53\u5927\u5C0F.</param>
        /// <param name="PageNumber">\u9875\u7801.</param>
        /// <param name="RecipientIndex">\u7B7E\u7F72\u4EBA\u7D22\u5F15\u53F7.</param>
        /// <param name="TemplateDateFieldId">\u6A21\u677F\u65F6\u95F4\u5B57\u6BB5\u540D.</param>
        /// <param name="Width">\u5BBD\u5EA6.</param>
        /// <param name="XPosition">X\u5750\u6807.</param>
        /// <param name="YPosition">Y\u5750\u6807.</param>

        public SignDateTime(string DateTimePattern = null, string DocumentIndex = null, string FontName = null, float? FontSize = null, int? PageNumber = null, string RecipientIndex = null, string TemplateDateFieldId = null, int? Width = null, int? XPosition = null, int? YPosition = null)
        {
            this.DateTimePattern = DateTimePattern;
            this.DocumentIndex = DocumentIndex;
            this.FontName = FontName;
            this.FontSize = FontSize;
            this.PageNumber = PageNumber;
            this.RecipientIndex = RecipientIndex;
            this.TemplateDateFieldId = TemplateDateFieldId;
            this.Width = Width;
            this.XPosition = XPosition;
            this.YPosition = YPosition;
            
        }
        
    
        /// <summary>
        /// \u65F6\u95F4\u663E\u793A\u683C\u5F0F
        /// </summary>
        /// <value>\u65F6\u95F4\u663E\u793A\u683C\u5F0F</value>
        [DataMember(Name="dateTimePattern", EmitDefaultValue=false)]
        public string DateTimePattern { get; set; }
    
        /// <summary>
        /// \u6587\u6863\u7D22\u5F15
        /// </summary>
        /// <value>\u6587\u6863\u7D22\u5F15</value>
        [DataMember(Name="documentIndex", EmitDefaultValue=false)]
        public string DocumentIndex { get; set; }
    
        /// <summary>
        /// \u5B57\u4F53\u540D\u79F0
        /// </summary>
        /// <value>\u5B57\u4F53\u540D\u79F0</value>
        [DataMember(Name="fontName", EmitDefaultValue=false)]
        public string FontName { get; set; }
    
        /// <summary>
        /// \u5B57\u4F53\u5927\u5C0F
        /// </summary>
        /// <value>\u5B57\u4F53\u5927\u5C0F</value>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public float? FontSize { get; set; }
    
        /// <summary>
        /// \u9875\u7801
        /// </summary>
        /// <value>\u9875\u7801</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
    
        /// <summary>
        /// \u7B7E\u7F72\u4EBA\u7D22\u5F15\u53F7
        /// </summary>
        /// <value>\u7B7E\u7F72\u4EBA\u7D22\u5F15\u53F7</value>
        [DataMember(Name="recipientIndex", EmitDefaultValue=false)]
        public string RecipientIndex { get; set; }
    
        /// <summary>
        /// \u6A21\u677F\u65F6\u95F4\u5B57\u6BB5\u540D
        /// </summary>
        /// <value>\u6A21\u677F\u65F6\u95F4\u5B57\u6BB5\u540D</value>
        [DataMember(Name="templateDateFieldId", EmitDefaultValue=false)]
        public string TemplateDateFieldId { get; set; }
    
        /// <summary>
        /// \u5BBD\u5EA6
        /// </summary>
        /// <value>\u5BBD\u5EA6</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }
    
        /// <summary>
        /// X\u5750\u6807
        /// </summary>
        /// <value>X\u5750\u6807</value>
        [DataMember(Name="xPosition", EmitDefaultValue=false)]
        public int? XPosition { get; set; }
    
        /// <summary>
        /// Y\u5750\u6807
        /// </summary>
        /// <value>Y\u5750\u6807</value>
        [DataMember(Name="yPosition", EmitDefaultValue=false)]
        public int? YPosition { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignDateTime {\n");
            sb.Append("  DateTimePattern: ").Append(DateTimePattern).Append("\n");
            sb.Append("  DocumentIndex: ").Append(DocumentIndex).Append("\n");
            sb.Append("  FontName: ").Append(FontName).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  RecipientIndex: ").Append(RecipientIndex).Append("\n");
            sb.Append("  TemplateDateFieldId: ").Append(TemplateDateFieldId).Append("\n");
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
            return this.Equals(obj as SignDateTime);
        }

        /// <summary>
        /// Returns true if SignDateTime instances are equal
        /// </summary>
        /// <param name="other">Instance of SignDateTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignDateTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateTimePattern == other.DateTimePattern ||
                    this.DateTimePattern != null &&
                    this.DateTimePattern.Equals(other.DateTimePattern)
                ) && 
                (
                    this.DocumentIndex == other.DocumentIndex ||
                    this.DocumentIndex != null &&
                    this.DocumentIndex.Equals(other.DocumentIndex)
                ) && 
                (
                    this.FontName == other.FontName ||
                    this.FontName != null &&
                    this.FontName.Equals(other.FontName)
                ) && 
                (
                    this.FontSize == other.FontSize ||
                    this.FontSize != null &&
                    this.FontSize.Equals(other.FontSize)
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
                    this.TemplateDateFieldId == other.TemplateDateFieldId ||
                    this.TemplateDateFieldId != null &&
                    this.TemplateDateFieldId.Equals(other.TemplateDateFieldId)
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
                
                if (this.DateTimePattern != null)
                    hash = hash * 59 + this.DateTimePattern.GetHashCode();
                
                if (this.DocumentIndex != null)
                    hash = hash * 59 + this.DocumentIndex.GetHashCode();
                
                if (this.FontName != null)
                    hash = hash * 59 + this.FontName.GetHashCode();
                
                if (this.FontSize != null)
                    hash = hash * 59 + this.FontSize.GetHashCode();
                
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                
                if (this.RecipientIndex != null)
                    hash = hash * 59 + this.RecipientIndex.GetHashCode();
                
                if (this.TemplateDateFieldId != null)
                    hash = hash * 59 + this.TemplateDateFieldId.GetHashCode();
                
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
