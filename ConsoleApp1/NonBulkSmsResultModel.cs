using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Services.SMS.SmsModel
{
    public class NonBulkSmsResultModel
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }

        [JsonProperty("jobCost")]
        public string JobCost { get; set; }

        [JsonProperty("recipientCnt")]
        public int RecipientCnt { get; set; }

        [JsonProperty("requireApproval")]
        public bool RequireApproval { get; set; }

        [JsonProperty("totalCnt")]
        public int TotalCnt { get; set; }

        [JsonProperty("campaignId")]
        public string CampaignId { get; set; }
    }
}
