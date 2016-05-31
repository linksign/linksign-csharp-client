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
    /// \u7B7E\u7F72\u76F8\u5173\u4FE1\u606F
    /// </summary>
    [DataContract]
    public partial class Tabs :  IEquatable<Tabs>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Tabs" /> class.
        /// Initializes a new instance of the <see cref="Tabs" />class.
        /// </summary>
        /// <param name="DateTabs">\u7B7E\u7F72\u65F6\u95F4\u4FE1\u606F.</param>
        /// <param name="SignHereTabs">SignHereTabs.</param>

        public Tabs(List<SignDateTime> DateTabs = null, List<SignHere> SignHereTabs = null)
        {
            this.DateTabs = DateTabs;
            this.SignHereTabs = SignHereTabs;
            
        }
        
    
        /// <summary>
        /// \u7B7E\u7F72\u65F6\u95F4\u4FE1\u606F
        /// </summary>
        /// <value>\u7B7E\u7F72\u65F6\u95F4\u4FE1\u606F</value>
        [DataMember(Name="dateTabs", EmitDefaultValue=false)]
        public List<SignDateTime> DateTabs { get; set; }
    
        /// <summary>
        /// Gets or Sets SignHereTabs
        /// </summary>
        [DataMember(Name="signHereTabs", EmitDefaultValue=false)]
        public List<SignHere> SignHereTabs { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tabs {\n");
            sb.Append("  DateTabs: ").Append(DateTabs).Append("\n");
            sb.Append("  SignHereTabs: ").Append(SignHereTabs).Append("\n");
            
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
            return this.Equals(obj as Tabs);
        }

        /// <summary>
        /// Returns true if Tabs instances are equal
        /// </summary>
        /// <param name="other">Instance of Tabs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tabs other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DateTabs == other.DateTabs ||
                    this.DateTabs != null &&
                    this.DateTabs.SequenceEqual(other.DateTabs)
                ) && 
                (
                    this.SignHereTabs == other.SignHereTabs ||
                    this.SignHereTabs != null &&
                    this.SignHereTabs.SequenceEqual(other.SignHereTabs)
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
                
                if (this.DateTabs != null)
                    hash = hash * 59 + this.DateTabs.GetHashCode();
                
                if (this.SignHereTabs != null)
                    hash = hash * 59 + this.SignHereTabs.GetHashCode();
                
                return hash;
            }
        }

    }
}
