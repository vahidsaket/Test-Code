using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Services.SMS.SmsModel
{
    public class NonBulkSmsModel
    {
        [JsonProperty("msgCategory")]
        public string msgCategory { get; set; }

        [JsonProperty("contentType")]
        public string contentType { get; set; }

        [JsonProperty("senderAddr")]
        public string senderAddr { get; set; }

        [JsonProperty("dndCategory")]
        public string dndCategory { get; set; }

        [JsonProperty("priority")]
        public int priority { get; set; }

        [JsonProperty("clientTxnId")]
        public string clientTxnId { get; set; }

        [JsonProperty("recipient")]
        public string recipient { get; set; }

        [JsonProperty("msg")]
        public string msg { get; set; }

        [JsonProperty("expiryDt")]
        public string ExpiryDt { get; set; }

        [JsonProperty("dr")]
        public bool Dr { get; set; }

        [JsonProperty("desc")]
        public string desc { get; set; }

        [JsonProperty("campaignName")]
        public string campaignName { get; set; }
    }
}
