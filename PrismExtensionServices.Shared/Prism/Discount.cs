using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class Discount
{

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? doc_item_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? new_disc_amt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? row_version;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? new_disc_perc;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? disc_pos;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? prev_price;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? created_datetime;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? new_price;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? spread_doc_disc_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? disc_promo_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? disc_type;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? disc_value;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? disc_orig_value;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? modified_by;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? new_tax_perc;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? controller_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? disc_reason;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? disc_promo_group;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tenant_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origin_application;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? modified_datetime;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? post_date;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? disc_source;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? lock_type;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? created_by;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? spread;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? new_disc_ext_amt;


    public Discount Clone()
    {
        return new Discount()
        {
            controller_sid = this.controller_sid,
            created_by = this.created_by,
            created_datetime = this.created_datetime,
            disc_orig_value = this.new_price,
            disc_pos = this.row_version,
            disc_promo_group = this.disc_promo_group,
            disc_promo_name = this.disc_promo_name,
            disc_reason = this.disc_reason,
            disc_source = this.disc_source,
            disc_type = this.disc_type,
            disc_value = this.disc_value,
            doc_item_sid = this.doc_item_sid,
            lock_type = this.lock_type,
            modified_by = this.created_by,
            modified_datetime = this.created_datetime,
            new_disc_amt = this.new_disc_amt,
            new_disc_ext_amt = this.new_disc_ext_amt,
            new_disc_perc = this.new_disc_perc,
            new_price = this.new_price,
            new_tax_perc = this.new_price,
            origin_application = this.origin_application,
            post_date = this.post_date,
            prev_price = this.prev_price,
            row_version = this.row_version,
            sid = this.doc_item_sid,
            spread = this.spread,
            spread_doc_disc_sid = this.spread_doc_disc_sid,
            tenant_sid = this.tenant_sid
        };
    }
}
