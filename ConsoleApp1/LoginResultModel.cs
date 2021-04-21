using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Services.SMS.SmsModel
{
    public class LoginResultModel
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("decodedValue")]
        public DecodedValue DecodedValue { get; set; }
    }

    public class DecodedValue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("loginId")]
        public string LoginId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("contactNo")]
        public string ContactNo { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("claims")]
        public string Claims { get; set; }

        [JsonProperty("createAt")]
        public string CreateAt { get; set; }

        [JsonProperty("expiryDt")]
        public string ExpiryDt { get; set; }

        [JsonProperty("enterpriceId")]
        public int EnterpriceId { get; set; }

        [JsonProperty("iat")]
        public int Iat { get; set; }
    }
}
