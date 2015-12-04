﻿// <auto-generated />
// Generated from /Users/chakrit/Documents/omise/omise-dotnet/Omise/Models/Models.tt
// on 12/4/2015 4:34:26 PM
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Omise.Models {
    public partial class Account : ModelBase {
        [JsonProperty("email")] public string Email { get; set; }
    }

    public partial class Balance : ModelBase {
        [JsonProperty("available")] public long Available { get; set; }
        [JsonProperty("total")] public long Total { get; set; }
        [JsonProperty("currency")] public string Currency { get; set; }
    }

    public partial class BankAccount : ModelBase {
        [JsonProperty("brand")] public string Brand { get; set; }
        [JsonProperty("number")] public string Number { get; set; }
        [JsonProperty("last_digits")] public string LastDigits { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
    }

    public partial class Card : ModelBase {
        [JsonProperty("country")] public string Country { get; set; }
        [JsonProperty("city")] public string City { get; set; }
        [JsonProperty("bank")] public string Bank { get; set; }
        [JsonProperty("postal_code")] public string PostalCode { get; set; }
        [JsonProperty("financing")] public string Financing { get; set; }
        [JsonProperty("last_digits")] public string LastDigits { get; set; }
        [JsonProperty("brand")] public string Brand { get; set; }
        [JsonProperty("expiration_month")] public int ExpirationMonth { get; set; }
        [JsonProperty("expiration_year")] public int ExpirationYear { get; set; }
        [JsonProperty("fingerprint")] public string Fingerprint { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("security_code_check")] public bool SecurityCodeCheck { get; set; }
    }

    public partial class Charge : ModelBase {
        [JsonProperty("status")] public ChargeStatus Status { get; set; }
        [JsonProperty("amount")] public long Amount { get; set; }
        [JsonProperty("currency")] public string Currency { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("capture")] public bool Capture { get; set; }
        [JsonProperty("captured")] public bool Captured { get; set; }
        [JsonProperty("authorized")] public bool Authorized { get; set; }
        [JsonProperty("paid")] public bool Paid { get; set; }
        [JsonProperty("transaction")] public string Transaction { get; set; }
        [JsonProperty("card")] public Card Card { get; set; }
        [JsonProperty("refunded")] public long Refunded { get; set; }
        [JsonProperty("refunds")] public IList<Refund> Refunds { get; set; }
        [JsonProperty("failure_code")] public string FailureCode { get; set; }
        [JsonProperty("failure_message")] public string FailureMessage { get; set; }
        [JsonProperty("customer")] public string CustomerID { get; set; }
        [JsonProperty("ip")] public string IP { get; set; }
        [JsonProperty("dispute")] public Dispute Dispute { get; set; }
        [JsonProperty("return_uri")] public string ReturnURI { get; set; }
        [JsonProperty("authorize_uri")] public string AuthorizeURI { get; set; }
    }

    public partial class Customer : ModelBase {
        [JsonProperty("default_card")] public string DefaultCard { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("cards")] public IList<Card> Cards { get; set; }
    }

    public partial class Dispute : ModelBase {
        [JsonProperty("amount")] public long Amount { get; set; }
        [JsonProperty("currency")] public string Currency { get; set; }
        [JsonProperty("status")] public DisputeStatus Status { get; set; }
        [JsonProperty("message")] public string Message { get; set; }
        [JsonProperty("charge")] public string Charge { get; set; }
    }

    public partial class Event<T> : ModelBase {
        [JsonProperty("key")] public string Key { get; set; }
        [JsonProperty("data")] public T Data { get; set; }
    }

    public partial class Recipient : ModelBase {
        [JsonProperty("verified")] public bool Verified { get; set; }
        [JsonProperty("active")] public bool Active { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("email")] public string Email { get; set; }
        [JsonProperty("description")] public string Description { get; set; }
        [JsonProperty("type")] public RecipientType Type { get; set; }
        [JsonProperty("taxid")] public string TaxID { get; set; }
        [JsonProperty("bankaccount")] public BankAccount BankAccount { get; set; }
        [JsonProperty("failure_code")] public string FailureCode { get; set; }
    }

    public partial class Refund : ModelBase {
        [JsonProperty("amount")] public long Amount { get; set; }
        [JsonProperty("currency")] public string Currency { get; set; }
        [JsonProperty("charge")] public string Charge { get; set; }
        [JsonProperty("transaction")] public string Transaction { get; set; }
    }

    public partial class Token : ModelBase {
        [JsonProperty("used")] public bool Used { get; set; }
        [JsonProperty("card")] public Card Card { get; set; }
    }

    public partial class Transaction : ModelBase {
        [JsonProperty("amount")] public long Amount { get; set; }
        [JsonProperty("currency")] public string Currency { get; set; }
        [JsonProperty("type")] public TransactionType Type { get; set; }
    }

    public partial class Transfer : ModelBase {
        [JsonProperty("recipient")] public string Recipient { get; set; }
        [JsonProperty("bankaccount")] public BankAccount BankAccount { get; set; }
        [JsonProperty("sent")] public bool Sent { get; set; }
        [JsonProperty("paid")] public bool Paid { get; set; }
        [JsonProperty("amount")] public long Amount { get; set; }
        [JsonProperty("currency")] public string Currency { get; set; }
        [JsonProperty("failure_code")] public string FailureCode { get; set; }
        [JsonProperty("failure_message")] public string FailureMessage { get; set; }
        [JsonProperty("transaction")] public string Transaction { get; set; }
    }
}