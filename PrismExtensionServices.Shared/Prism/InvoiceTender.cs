using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class InvoiceTender
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata0;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata3;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata4;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata5;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata6;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata7;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata8;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata9;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata10;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata11;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata12;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata13;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata14;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata15;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata16;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata17;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata18;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? eftdata19;

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //public string? central_card_number;
    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //public string? central_payment_id;
    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //public decimal? central_credit_balance;


    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? store_credit_balance;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  first_name;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  central_card_number;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  emv_pinstatement;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  foreign_currency_name;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  company;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  certificate_number;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? charge_net_days;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? taken;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  new_credit_id_10;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  authorization_code;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? foreign_currency_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  central_payment_id;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  home_phone;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? payment_date;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  emv_ci_cardexpirydate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? prevent_void;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tender_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? created_datetime;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? tender_pos;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  state;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? balance;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? currency_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? check_type;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? charge_discount_days;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  internal_reference_number;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? central_commit_state;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  work_phone;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdatabscust;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  trace_number;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  currency_name;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  failure_message;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  card_number;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tenant_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? is_normal_sale;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tender_name;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? is_present;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? modified_datetime;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? post_date;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  l2_result_code;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? central_credit_balance;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  new_credit_id;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? central_card_expiredate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  redeem_credit_id;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  payment_remark;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  emv_crypto_cryptogram;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  avs_response_code;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  card_type_name;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  emv_crypto_cryptogramtype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  last_name;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? base_given;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? tender_type;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  drivers_license;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? entry_method;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  redeem_credit_id_10;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdatabsmer;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eft_transaction_id;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? take_rate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? eft_res_tender_state;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  central_txn_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? amount;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  alphabetic_code;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? give_rate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? date_of_birth;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  manual_name;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? document_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  created_by;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  emv_ai_aid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  emv_ai_applabel;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? row_version;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? given;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? card_type_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? card_expiration_month;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? charge_discount_percent;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? matched;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  modified_by;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? card_expiration_year;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  foreign_alphabetic_code;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? drivers_license_expiration;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? controller_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  manual_remark;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  central_activation_id;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  origin_application;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? new_credit_value;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? base_taken;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  check_number;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  card_postal_code;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  card_holder_name;


    // Sage info:
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public string? SageCustomerCode { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public string? SageTransactionCode { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public string? SageOrderNumber { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public string? SageReference { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public string? SageDescription { get; set; }


    public InvoiceTender Clone()
    {
        return new InvoiceTender()
        {
            alphabetic_code = this.alphabetic_code,
            amount = this.amount,
            authorization_code = this.authorization_code,
            avs_response_code = this.avs_response_code,
            balance = this.balance,
            base_given = this.base_given,
            base_taken = this.base_taken,
            card_expiration_month = this.card_expiration_month,
            card_expiration_year = this.card_expiration_year,
            card_holder_name = this.card_holder_name,
            card_number = this.card_number,
            card_postal_code = this.card_postal_code,
            card_type_name = this.card_type_name,
            card_type_sid = this.card_type_sid,
            central_activation_id = this.central_activation_id,
            central_card_expiredate = this.central_card_expiredate,
            central_card_number = this.central_card_number,
            central_commit_state = this.central_commit_state,
            central_credit_balance = this.central_credit_balance,
            central_payment_id = this.central_payment_id,
            central_txn_sid = this.central_txn_sid,
            certificate_number = this.certificate_number,
            charge_discount_days = this.charge_discount_days,
            charge_discount_percent = this.charge_discount_percent,
            charge_net_days = this.charge_net_days,
            check_number = this.check_number,
            check_type = this.check_type,
            company = this.company,
            controller_sid = this.controller_sid,
            created_by = this.created_by,
            created_datetime = this.created_datetime,
            currency_name = this.currency_name,
            currency_sid = this.currency_sid,
            date_of_birth = this.date_of_birth,
            document_sid = this.document_sid,
            drivers_license = this.drivers_license,
            drivers_license_expiration = this.drivers_license_expiration,
            eftdata0 = this.eftdata0,
            eftdata1 = this.eftdata1,
            eftdata10 = this.eftdata10,
            eftdata11 = this.eftdata11,
            eftdata12 = this.eftdata12,
            eftdata13 = this.eftdata13,
            eftdata14 = this.eftdata14,
            eftdata15 = this.eftdata15,
            eftdata16 = this.eftdata16,
            eftdata17 = this.eftdata17,
            eftdata18 = this.eftdata18,
            eftdata19 = this.eftdata19,
            eftdata2 = this.eftdata2,
            eftdata3 = this.eftdata3,
            eftdata4 = this.eftdata4,
            eftdata5 = this.eftdata5,
            eftdata6 = this.eftdata6,
            eftdata7 = this.eftdata7,
            eftdata8 = this.eftdata8,
            eftdata9 = this.eftdata9,
            eftdatabscust = this.eftdatabscust,
            eftdatabsmer = this.eftdatabsmer,
            eft_res_tender_state = this.eft_res_tender_state,
            eft_transaction_id = this.eft_transaction_id,
            emv_ai_aid = this.emv_ai_aid,
            emv_ai_applabel = this.emv_ai_applabel,
            emv_ci_cardexpirydate = this.emv_ci_cardexpirydate,
            emv_crypto_cryptogram = this.emv_crypto_cryptogram,
            emv_crypto_cryptogramtype = this.emv_crypto_cryptogramtype,
            emv_pinstatement = this.emv_pinstatement,
            entry_method = this.entry_method,
            failure_message = this.failure_message,
            first_name = this.first_name,
            foreign_alphabetic_code = this.foreign_alphabetic_code,
            foreign_currency_name = this.foreign_currency_name,
            foreign_currency_sid = this.foreign_currency_sid,
            given = this.given,
            give_rate = this.given,
            home_phone = this.home_phone,
            internal_reference_number = this.internal_reference_number,
            is_normal_sale = this.is_normal_sale,
            is_present = this.is_present,
            l2_result_code = this.l2_result_code,
            last_name = this.last_name,
            manual_name = this.manual_name,
            manual_remark = this.manual_remark,
            matched = this.matched,
            modified_by = this.modified_by,
            modified_datetime = this.modified_datetime,
            new_credit_id = this.new_credit_id,
            new_credit_id_10 = this.new_credit_id_10,
            new_credit_value = this.new_credit_value,
            origin_application = this.origin_application,
            payment_date = this.payment_date,
            payment_remark = this.payment_remark,
            post_date = this.post_date,
            prevent_void = this.prevent_void,
            redeem_credit_id = this.redeem_credit_id,
            redeem_credit_id_10 = this.redeem_credit_id_10,
            row_version = this.row_version,
            SageCustomerCode = this.SageCustomerCode,
            SageDescription = this.SageDescription,
            SageOrderNumber = this.SageOrderNumber,
            SageReference = this.SageReference,
            SageTransactionCode = this.SageTransactionCode,
            sid = this.sid,
            state = this.state,
            store_credit_balance = this.store_credit_balance,
            taken = this.taken,
            take_rate = this.take_rate,
            tenant_sid = this.tenant_sid,
            tender_name = this.tender_name,
            tender_pos = this.tender_pos,
            tender_sid = this.tender_sid,
            tender_type = this.tender_type,
            trace_number = this.trace_number,
            work_phone = this.work_phone
        };
    }
}


public class InvoiceTenderPost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  origin_application = "RProPrismWeb";
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? tender_type = 0;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? document_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? taken;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? given;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tender_name = "Cash";
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? central_card_number;

    //public InvoiceTenderPost() { }
    //public InvoiceTenderPost(long docSid, decimal amount, InvoiceTenderType tenderType = InvoiceTenderType.Cash) 
    //{
    //    document_sid = docSid;
    //    if (amount >= 0)
    //        taken = amount;
    //    else
    //        given = Math.Abs(amount);

    //    tender_type = (int)tenderType;
    //    tender_name = tenderType.Tostring();
    //}

}