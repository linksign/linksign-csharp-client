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
    public partial class App :  IEquatable<App>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// Initializes a new instance of the <see cref="App" />class.
        /// </summary>
        /// <param name="EmailTemplateId">\u90AE\u4EF6\u6A21\u677F\u7F16\u53F7.</param>
        /// <param name="RedirectUri">Signature completed redirected link.</param>
        /// <param name="SealHtml5TemplateId">\u5370\u7AE0\u91C7\u96C6H5\u9875\u9762\u6A21\u677F\u7F16\u53F7.</param>
        /// <param name="SignatureHtml5TemplateId">\u7B7E\u540D\u91C7\u96C6H5\u9875\u9762\u6A21\u677F\u7F16\u53F7.</param>
        /// <param name="SmsTemplateId">\u77ED\u4FE1\u6A21\u677F\u7F16\u53F7.</param>

        public App(string EmailTemplateId = null, string RedirectUri = null, string SealHtml5TemplateId = null, string SignatureHtml5TemplateId = null, string SmsTemplateId = null)
        {
            this.EmailTemplateId = EmailTemplateId;
            this.RedirectUri = RedirectUri;
            this.SealHtml5TemplateId = SealHtml5TemplateId;
            this.SignatureHtml5TemplateId = SignatureHtml5TemplateId;
            this.SmsTemplateId = SmsTemplateId;
            
        }
        
    
        /// <summary>
        /// \u90AE\u4EF6\u6A21\u677F\u7F16\u53F7
        /// </summary>
        /// <value>\u90AE\u4EF6\u6A21\u677F\u7F16\u53F7</value>
        [DataMember(Name="emailTemplateId", EmitDefaultValue=false)]
        public string EmailTemplateId { get; set; }
    
        /// <summary>
        /// Signature completed redirected link
        /// </summary>
        /// <value>Signature completed redirected link</value>
        [DataMember(Name="redirectUri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }
    
        /// <summary>
        /// \u5370\u7AE0\u91C7\u96C6H5\u9875\u9762\u6A21\u677F\u7F16\u53F7
        /// </summary>
        /// <value>\u5370\u7AE0\u91C7\u96C6H5\u9875\u9762\u6A21\u677F\u7F16\u53F7</value>
        [DataMember(Name="sealHtml5TemplateId", EmitDefaultValue=false)]
        public string SealHtml5TemplateId { get; set; }
    
        /// <summary>
        /// \u7B7E\u540D\u91C7\u96C6H5\u9875\u9762\u6A21\u677F\u7F16\u53F7
        /// </summary>
        /// <value>\u7B7E\u540D\u91C7\u96C6H5\u9875\u9762\u6A21\u677F\u7F16\u53F7</value>
        [DataMember(Name="signatureHtml5TemplateId", EmitDefaultValue=false)]
        public string SignatureHtml5TemplateId { get; set; }
    
        /// <summary>
        /// \u77ED\u4FE1\u6A21\u677F\u7F16\u53F7
        /// </summary>
        /// <value>\u77ED\u4FE1\u6A21\u677F\u7F16\u53F7</value>
        [DataMember(Name="smsTemplateId", EmitDefaultValue=false)]
        public string SmsTemplateId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class App {\n");
            sb.Append("  EmailTemplateId: ").Append(EmailTemplateId).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  SealHtml5TemplateId: ").Append(SealHtml5TemplateId).Append("\n");
            sb.Append("  SignatureHtml5TemplateId: ").Append(SignatureHtml5TemplateId).Append("\n");
            sb.Append("  SmsTemplateId: ").Append(SmsTemplateId).Append("\n");
            
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
            return this.Equals(obj as App);
        }

        /// <summary>
        /// Returns true if App instances are equal
        /// </summary>
        /// <param name="other">Instance of App to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(App other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmailTemplateId == other.EmailTemplateId ||
                    this.EmailTemplateId != null &&
                    this.EmailTemplateId.Equals(other.EmailTemplateId)
                ) && 
                (
                    this.RedirectUri == other.RedirectUri ||
                    this.RedirectUri != null &&
                    this.RedirectUri.Equals(other.RedirectUri)
                ) && 
                (
                    this.SealHtml5TemplateId == other.SealHtml5TemplateId ||
                    this.SealHtml5TemplateId != null &&
                    this.SealHtml5TemplateId.Equals(other.SealHtml5TemplateId)
                ) && 
                (
                    this.SignatureHtml5TemplateId == other.SignatureHtml5TemplateId ||
                    this.SignatureHtml5TemplateId != null &&
                    this.SignatureHtml5TemplateId.Equals(other.SignatureHtml5TemplateId)
                ) && 
                (
                    this.SmsTemplateId == other.SmsTemplateId ||
                    this.SmsTemplateId != null &&
                    this.SmsTemplateId.Equals(other.SmsTemplateId)
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
                
                if (this.EmailTemplateId != null)
                    hash = hash * 59 + this.EmailTemplateId.GetHashCode();
                
                if (this.RedirectUri != null)
                    hash = hash * 59 + this.RedirectUri.GetHashCode();
                
                if (this.SealHtml5TemplateId != null)
                    hash = hash * 59 + this.SealHtml5TemplateId.GetHashCode();
                
                if (this.SignatureHtml5TemplateId != null)
                    hash = hash * 59 + this.SignatureHtml5TemplateId.GetHashCode();
                
                if (this.SmsTemplateId != null)
                    hash = hash * 59 + this.SmsTemplateId.GetHashCode();
                
                return hash;
            }
        }

    }
}
