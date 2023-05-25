// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetailsPaypal : StripeEntity<MandatePaymentMethodDetailsPaypal>
    {
        /// <summary>
        /// The PayPal Billing Agreement ID (BAID). This is an ID generated by PayPal which
        /// represents the mandate between the merchant and the customer.
        /// </summary>
        [JsonProperty("billing_agreement_id")]
        public string BillingAgreementId { get; set; }

        /// <summary>
        /// Uniquely identifies this particular PayPal account. You can use this attribute to check
        /// whether two PayPal accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// PayPal account PayerID. This identifier uniquely identifies the PayPal customer.
        /// </summary>
        [JsonProperty("payer_id")]
        public string PayerId { get; set; }

        /// <summary>
        /// Owner's verified email. Values are verified or provided by PayPal directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_email")]
        public string VerifiedEmail { get; set; }
    }
}