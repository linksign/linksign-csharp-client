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
    /// \u9519\u8BEF\u4FE1\u606F
    /// </summary>
    [DataContract]
    public partial class ApiError :  IEquatable<ApiError>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError" /> class.
        /// Initializes a new instance of the <see cref="ApiError" />class.
        /// </summary>
        /// <param name="ErrCode">ErrCode (required).</param>
        /// <param name="ErrMsg">ErrMsg (required).</param>

        public ApiError(int? ErrCode = null, string ErrMsg = null)
        {
            // to ensure "ErrCode" is required (not null)
            if (ErrCode == null)
            {
                throw new InvalidDataException("ErrCode is a required property for ApiError and cannot be null");
            }
            else
            {
                this.ErrCode = ErrCode;
            }
            // to ensure "ErrMsg" is required (not null)
            if (ErrMsg == null)
            {
                throw new InvalidDataException("ErrMsg is a required property for ApiError and cannot be null");
            }
            else
            {
                this.ErrMsg = ErrMsg;
            }
            
        }
        
    
        /// <summary>
        /// Gets or Sets ErrCode
        /// </summary>
        [DataMember(Name="errCode", EmitDefaultValue=false)]
        public int? ErrCode { get; set; }
    
        /// <summary>
        /// Gets or Sets ErrMsg
        /// </summary>
        [DataMember(Name="errMsg", EmitDefaultValue=false)]
        public string ErrMsg { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiError {\n");
            sb.Append("  ErrCode: ").Append(ErrCode).Append("\n");
            sb.Append("  ErrMsg: ").Append(ErrMsg).Append("\n");
            
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
            return this.Equals(obj as ApiError);
        }

        /// <summary>
        /// Returns true if ApiError instances are equal
        /// </summary>
        /// <param name="other">Instance of ApiError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiError other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrCode == other.ErrCode ||
                    this.ErrCode != null &&
                    this.ErrCode.Equals(other.ErrCode)
                ) && 
                (
                    this.ErrMsg == other.ErrMsg ||
                    this.ErrMsg != null &&
                    this.ErrMsg.Equals(other.ErrMsg)
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
                
                if (this.ErrCode != null)
                    hash = hash * 59 + this.ErrCode.GetHashCode();
                
                if (this.ErrMsg != null)
                    hash = hash * 59 + this.ErrMsg.GetHashCode();
                
                return hash;
            }
        }

    }
}
