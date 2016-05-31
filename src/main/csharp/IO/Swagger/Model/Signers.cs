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
    public partial class Signers :  IEquatable<Signers>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Signers" /> class.
        /// Initializes a new instance of the <see cref="Signers" />class.
        /// </summary>
        /// <param name="SignerCompanys">\u7B7E\u7F72\u4EBA\u5217\u8868\uFF08\u516C\u53F8\uFF09.</param>
        /// <param name="SignerPersons">\u7B7E\u7F72\u4EBA\u5217\u8868\uFF08\u4E2A\u4EBA\uFF09.</param>
        /// <param name="Tabs">\u7B7E\u7F72\u4FE1\u606F\u9762\u677F.</param>

        public Signers(List<Company> SignerCompanys = null, List<Personal> SignerPersons = null, Tabs Tabs = null)
        {
            this.SignerCompanys = SignerCompanys;
            this.SignerPersons = SignerPersons;
            this.Tabs = Tabs;
            
        }
        
    
        /// <summary>
        /// \u7B7E\u7F72\u4EBA\u5217\u8868\uFF08\u516C\u53F8\uFF09
        /// </summary>
        /// <value>\u7B7E\u7F72\u4EBA\u5217\u8868\uFF08\u516C\u53F8\uFF09</value>
        [DataMember(Name="signerCompanys", EmitDefaultValue=false)]
        public List<Company> SignerCompanys { get; set; }
    
        /// <summary>
        /// \u7B7E\u7F72\u4EBA\u5217\u8868\uFF08\u4E2A\u4EBA\uFF09
        /// </summary>
        /// <value>\u7B7E\u7F72\u4EBA\u5217\u8868\uFF08\u4E2A\u4EBA\uFF09</value>
        [DataMember(Name="signerPersons", EmitDefaultValue=false)]
        public List<Personal> SignerPersons { get; set; }
    
        /// <summary>
        /// \u7B7E\u7F72\u4FE1\u606F\u9762\u677F
        /// </summary>
        /// <value>\u7B7E\u7F72\u4FE1\u606F\u9762\u677F</value>
        [DataMember(Name="tabs", EmitDefaultValue=false)]
        public Tabs Tabs { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Signers {\n");
            sb.Append("  SignerCompanys: ").Append(SignerCompanys).Append("\n");
            sb.Append("  SignerPersons: ").Append(SignerPersons).Append("\n");
            sb.Append("  Tabs: ").Append(Tabs).Append("\n");
            
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
            return this.Equals(obj as Signers);
        }

        /// <summary>
        /// Returns true if Signers instances are equal
        /// </summary>
        /// <param name="other">Instance of Signers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signers other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SignerCompanys == other.SignerCompanys ||
                    this.SignerCompanys != null &&
                    this.SignerCompanys.SequenceEqual(other.SignerCompanys)
                ) && 
                (
                    this.SignerPersons == other.SignerPersons ||
                    this.SignerPersons != null &&
                    this.SignerPersons.SequenceEqual(other.SignerPersons)
                ) && 
                (
                    this.Tabs == other.Tabs ||
                    this.Tabs != null &&
                    this.Tabs.Equals(other.Tabs)
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
                
                if (this.SignerCompanys != null)
                    hash = hash * 59 + this.SignerCompanys.GetHashCode();
                
                if (this.SignerPersons != null)
                    hash = hash * 59 + this.SignerPersons.GetHashCode();
                
                if (this.Tabs != null)
                    hash = hash * 59 + this.Tabs.GetHashCode();
                
                return hash;
            }
        }

    }
}
