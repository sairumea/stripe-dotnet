// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class QuoteLineActionSetDiscountDiscountEnd : StripeEntity<QuoteLineActionSetDiscountDiscountEnd>
    {
        /// <summary>
        /// The discount end timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The discount end type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}