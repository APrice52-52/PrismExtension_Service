using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class InvoiceItem
{

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lty_orig_points_earned;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string09;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  note4;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  discount_reason;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? is_competing_component;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? activity2_percent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tax_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? maxaccumdiscpercent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? ship_method_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? order_ship_method_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee3_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? item_origin;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employee1_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee3_full_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? central_return_commit_state;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? so_cancel_flag;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? kit_type;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee2_login_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? inventory_item_type;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  item_description3;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  note8;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  item_description1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lty_piece_of_tbe_points;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata11;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata13;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? hist_discount_perc5;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string14;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string04;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_address_line3;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? package_sequence_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? invn_sbs_item_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? item_status;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? qty_available_for_return;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  style_image_path;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Discount[]? discounts;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? original_cost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? st_primary;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  hist_discount_reason4;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? gift_add_value;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  note3;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? lot_type;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? ref_order_item_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  gift_transaction_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdatabscust;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? hist_discount_amt1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee1_full_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  total_discount_reason;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? order_quantity_filled;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata18;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? active_price;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_company_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata16;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? post_date;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  ship_method;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? commission2_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata7;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  gift_expire_date;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? inventory_on_hand_quantity;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata0;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? tax_perc_lock;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  dcs_code;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? activity3_percent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? price;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee1_login_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? central_document_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? order_ship_method_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee3_login_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? tax2_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_address_line2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? fulfill_store_sbs_no;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employee5_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? returned_item_invoice_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string01;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? udf_float01;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? price_before_detax;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? ship_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  hist_discount_reason5;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string10;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee2_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? commission_code;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata14;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? employee1_orig_sbs_no;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? spif;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  price_lvl_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? style_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? internal_item_pos;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? commission3_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata10;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string13;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? dip_discount_amt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata12;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? hist_discount_perc2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_postal_code_extension;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employee3_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? commission_percent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? item_pos;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? st_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? activity4_percent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? returned_item_qty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? detax_flag;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? custom_flag;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? st_price_lvl;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? discount_amt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? total_discount_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? row_version;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata15;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string07;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? employee4_orig_sbs_no;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? dip_tax_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employee5_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? lty_redeem_applicable_manually;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  order_ship_method;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? enhanced_item_pos;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  item_description2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee5_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  manual_disc_reason;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata4;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tax_code_rule2_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? override_check_qty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string05;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string11;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? total_discount_percent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? tax_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  package_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  scan_upc;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? so_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? shipping_amt_bdt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  image_path;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employee3_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? maxdiscpercent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? invn_item_uid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? item_type;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee5_full_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? subsidiary_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  note10;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tax_code_rule_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employee2_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  customer_field;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? tax2_percent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? udf_date01;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string06;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? override_max_disc_perc;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? subloc_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_address_line5;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? original_component_item_uid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? ref_sale_item_pos;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? manual_disc_value;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tax_code2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? original_price_before_detax;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lty_points_earned;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_last_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? fulfill_store_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_country;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata5;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata19;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string03;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_first_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tax_code;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  hist_discount_reason2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employee4_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? price_lvl;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lty_orig_price_in_points;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  note2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  commission_level;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  item_lookup;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  vendor_code;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? commission5_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  alu;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string08;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? schedule_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata3;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  serial_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata17;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? promotion_flag;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? udf_float02;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? so_deposit_amt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lty_price_in_points;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? st_security_lvl;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? ship_method_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? created_datetime;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? hist_discount_amt3;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? activation_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? inventory_quantity_per_case;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? inventory_use_quantity_decimals;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string12;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? special_order;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? commission_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? hist_discount_perc3;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tax_message;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? dip_price_bdt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_address_line1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tax_message2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? user_discount_percent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? central_item_pos;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tracking_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? authorize_date;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_title;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? promo_gift_item;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? ref_order_doc_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? hist_discount_perc4;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tenant_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? kit_flag;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public KitFlag? KitFlagValue
    {
        get {
            return kit_flag != null
                ? (KitFlag)kit_flag
                : null;
        }
        set { 
            kit_flag = value != null 
                ? (int)value 
                : null; 
        }
    }

    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public bool non_inventory = false;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  lot_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? discount_perc;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? modified_datetime;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? udf_float03;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? original_tax_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? commission4_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? hist_discount_amt4;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? st_detax_flag;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_tax_area_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? orig_document_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? activity5_percent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? archived;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? package_item_uid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lty_price_in_points_ext;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  item_size;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? original_price;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? store_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  lty_pgm_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? order_type;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employee4_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_price_lvl_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  attribute;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lty_piece_of_tbr_points;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? orig_subsidiary_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tax_name2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee1_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? delete_discount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? original_component_item_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdatabsmer;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata9;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employee2_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  item_description4;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string15;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? serial_type;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? activity_percent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee4_login_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  gift_activation_code;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tax_char;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  hist_discount_reason3;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? document_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? hist_discount_perc1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  udf_string02;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  created_by;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? ref_sale_doc_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? shipping_amt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? package_item_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  note5;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_primary_phone_no;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? employee5_orig_sbs_no;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  return_reason;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee5_login_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  note9;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employee1_id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  note1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? lty_type;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? price_lvl_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? st_address_uid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_address_line6;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? apply_type_to_all_items;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lty_piece_of_tbr_disc_amt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tax_area_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? promo_disc_modifiedmanually;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? st_cuid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  note6;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? hist_discount_amt5;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? employee2_orig_sbs_no;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? orig_sale_price;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tax_area2_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? dip_price;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  modified_by;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_postal_code;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_email;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? orig_store_number;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? quantity;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  note7;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? hist_discount_amt2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? gift_quantity;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? controller_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? lty_pgm_sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata8;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee2_full_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? dip_tax2_amount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  origin_application;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata6;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee4_full_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  employee4_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_tax_area2_name;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  hist_discount_reason1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? manual_disc_type;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  eftdata2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? employee3_orig_sbs_no;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_address_line4;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? tax_percent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  tax_char2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? fulfill_store_no;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? from_centrals;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  st_customer_lookup;


    public InvoiceItem Clone()
    {
        var item = new InvoiceItem() { 
            activation_sid = this.activation_sid,
            active_price = this.active_price,
            activity2_percent = this.activity2_percent,
            activity3_percent = this.activity3_percent,
            activity4_percent = this.activity4_percent,
            activity5_percent = this.activity5_percent,
            activity_percent = this.activity_percent,
            alu = this.alu,
            apply_type_to_all_items = this.apply_type_to_all_items,
            archived = this.archived,
            attribute = this.attribute,
            authorize_date = this.authorize_date,
            central_document_sid = this.central_document_sid,
            central_item_pos = this.central_item_pos,
            central_return_commit_state = this.central_return_commit_state,
            commission2_amount = this.commission2_amount,
            commission3_amount = this.commission3_amount,
            commission4_amount = this.commission4_amount,
            commission5_amount = this.commission5_amount,
            commission_amount = this.commission_amount,
            commission_code = this.commission_code,
            commission_level = this.commission_level,
            commission_percent = this.commission_percent,
            controller_sid = this.controller_sid,
            cost = this.cost,
            created_by = this.created_by,
            created_datetime = this.created_datetime,
            customer_field = this.customer_field,
            custom_flag = this.custom_flag,
            dcs_code = this.dcs_code,
            delete_discount = this.delete_discount,
            detax_flag = this.detax_flag,
            dip_discount_amt = this.dip_discount_amt,
            dip_price = this.dip_price,
            dip_price_bdt = this.dip_price_bdt,
            dip_tax2_amount = this.dip_tax2_amount,
            dip_tax_amount = this.dip_tax_amount,
            discounts = null,
            discount_amt = this.discount_amt,
            discount_perc = this.discount_perc,
            discount_reason = this.discount_reason,
            document_sid = this.document_sid,
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
            employee1_full_name = this.employee1_full_name,
            employee1_id = this.employee1_id,
            employee1_login_name = this.employee1_login_name,
            employee1_name = this.employee1_name,
            employee1_orig_sbs_no = this.employee1_orig_sbs_no,
            employee1_sid = this.employee1_sid,
            employee2_full_name = this.employee2_full_name,
            employee2_id = this.employee2_id,
            employee2_login_name = this.employee2_login_name,
            employee2_name = this.employee2_name,
            employee2_orig_sbs_no = this.employee2_orig_sbs_no,
            employee2_sid = this.employee2_sid,
            employee3_full_name = this.employee3_full_name,
            employee3_id = this.employee3_id,
            employee3_login_name = this.employee3_login_name,
            employee3_name = this.employee3_name,
            employee3_orig_sbs_no = this.employee3_orig_sbs_no,
            employee3_sid = this.employee3_sid,
            employee4_full_name = this.employee4_full_name,
            employee4_id = this.employee4_id,
            employee4_login_name = this.employee4_login_name,
            employee4_name = this.employee4_name,
            employee4_orig_sbs_no = this.employee4_orig_sbs_no,
            employee4_sid = this.employee4_sid,
            employee5_full_name = this.employee5_full_name,
            employee5_id = this.employee5_id,
            employee5_login_name = this.employee5_login_name,
            employee5_name = this.employee5_name,
            employee5_orig_sbs_no = this.employee5_orig_sbs_no,
            employee5_sid = this.employee5_sid,
            enhanced_item_pos = this.enhanced_item_pos,
            from_centrals = this.from_centrals,
            fulfill_store_no = this.fulfill_store_no,
            fulfill_store_sbs_no = this.fulfill_store_sbs_no,
            fulfill_store_sid = this.fulfill_store_sid,
            gift_activation_code = this.gift_activation_code,
            gift_add_value = this.gift_add_value,
            gift_expire_date = this.gift_expire_date,
            gift_quantity = this.gift_quantity,
            gift_transaction_id = this.gift_transaction_id,
            hist_discount_amt1 = this.hist_discount_amt1,
            hist_discount_amt2 = this.hist_discount_amt2,
            hist_discount_amt3 = this.hist_discount_amt3,
            hist_discount_amt4 = this.hist_discount_amt4,
            hist_discount_amt5 = this.hist_discount_amt5,
            hist_discount_perc1 = this.hist_discount_perc1,
            hist_discount_perc2 = this.hist_discount_perc2,
            hist_discount_perc3 = this.hist_discount_perc3,
            hist_discount_perc4 = this.hist_discount_perc4,
            hist_discount_perc5 = this.hist_discount_perc5,
            hist_discount_reason1 = this.hist_discount_reason1,
            hist_discount_reason2 = this.hist_discount_reason2,
            hist_discount_reason3 = this.hist_discount_reason3,
            hist_discount_reason4 = this.hist_discount_reason4,
            hist_discount_reason5 = this.hist_discount_reason5,
            image_path = this.image_path,
            internal_item_pos = this.internal_item_pos,
            inventory_item_type = this.inventory_item_type,
            inventory_on_hand_quantity = this.inventory_on_hand_quantity,
            inventory_quantity_per_case = this.inventory_quantity_per_case,
            inventory_use_quantity_decimals = this.inventory_use_quantity_decimals,
            invn_item_uid = this.invn_item_uid,
            invn_sbs_item_sid = this.invn_sbs_item_sid,
            is_competing_component = this.is_competing_component,
            item_description1 = this.item_description1,
            item_description2 = this.item_description2,
            item_description3 = this.item_description3,
            item_description4 = this.item_description4,
            item_lookup = this.item_lookup,
            item_origin = this.item_origin,
            item_pos = this.item_pos,
            item_size = this.item_size,
            item_status = this.item_status,
            item_type = this.item_type,
            kit_flag = this.kit_flag,
            kit_type = this.kit_type,
            lot_number = this.lot_number,
            lot_type = this.lot_type,
            lty_orig_points_earned = this.lty_orig_points_earned,
            lty_orig_price_in_points = this.lty_orig_price_in_points,
            lty_pgm_name = this.lty_pgm_name,
            lty_pgm_sid = this.lty_pgm_sid,
            lty_piece_of_tbe_points = this.lty_piece_of_tbe_points,
            lty_piece_of_tbr_disc_amt = this.lty_piece_of_tbr_disc_amt,
            lty_piece_of_tbr_points = this.lty_piece_of_tbr_points,
            lty_points_earned = this.lty_points_earned,
            lty_price_in_points = this.lty_price_in_points,
            lty_price_in_points_ext = this.lty_price_in_points_ext,
            lty_redeem_applicable_manually = this.lty_redeem_applicable_manually,
            lty_type = this.lty_type,
            manual_disc_reason = this.manual_disc_reason,
            manual_disc_type = this.manual_disc_type,
            manual_disc_value = this.manual_disc_value,
            maxaccumdiscpercent = this.maxaccumdiscpercent,
            maxdiscpercent = this.maxdiscpercent,
            modified_by = this.modified_by,
            modified_datetime = this.modified_datetime,
            note1 = this.note1,
            note10 = this.note10,
            note2 = this.note2,
            note3 = this.note3,
            note4 = this.note4,
            note5 = this.note5,
            note6 = this.note6,
            note7 = this.note7,
            note8 = this.note8,
            note9 = this.note9,
            order_quantity_filled = this.order_quantity_filled,
            order_ship_method = this.order_ship_method,
            order_ship_method_id = this.order_ship_method_id,
            order_ship_method_sid = this.order_ship_method_sid,
            order_type = this.order_type,
            original_component_item_sid = this.original_component_item_sid,
            original_component_item_uid = this.original_component_item_uid,
            original_cost = this.original_cost,
            original_price = this.original_price,
            original_price_before_detax = this.original_price_before_detax,
            original_tax_amount = this.original_tax_amount,
            origin_application = this.origin_application,
            orig_document_number = this.orig_document_number,
            orig_sale_price = this.orig_sale_price,
            orig_store_number = this.orig_store_number,
            orig_subsidiary_number = this.orig_subsidiary_number,
            override_check_qty = this.override_check_qty,
            override_max_disc_perc = this.override_max_disc_perc,
            package_item_sid = this.package_item_sid,
            package_item_uid = this.package_item_uid,
            package_number = this.package_number,
            package_sequence_number = this.package_sequence_number,
            post_date = this.post_date,
            price = this.price,
            price_before_detax = this.price_before_detax,
            price_lvl = this.price_lvl,
            price_lvl_name = this.price_lvl_name,
            price_lvl_sid = this.price_lvl_sid,
            promotion_flag = this.promotion_flag,
            promo_disc_modifiedmanually = this.promo_disc_modifiedmanually,
            promo_gift_item = this.promo_gift_item,
            qty_available_for_return = this.qty_available_for_return,
            quantity = this.quantity,
            ref_order_doc_sid = this.ref_order_doc_sid,
            ref_order_item_sid = this.ref_order_item_sid,
            ref_sale_doc_sid = this.ref_sale_doc_sid,
            ref_sale_item_pos = this.ref_sale_item_pos,
            returned_item_invoice_sid = this.returned_item_invoice_sid,
            returned_item_qty = this.returned_item_qty,
            return_reason = this.return_reason,
            row_version = this.row_version,
            scan_upc = this.scan_upc,
            schedule_number = this.schedule_number,
            serial_number = this.serial_number,
            serial_type = this.serial_type,
            shipping_amt = this.shipping_amt,
            shipping_amt_bdt = this.shipping_amt_bdt,
            ship_id = this.ship_id,
            ship_method = this.ship_method,
            ship_method_id = this.ship_method_id,
            ship_method_sid = this.ship_method_sid,
            sid = this.sid,
            so_cancel_flag = this.so_cancel_flag,
            so_deposit_amt = this.so_deposit_amt,
            so_number = this.so_number,
            special_order = this.special_order,
            spif = this.spif,
            store_number = this.store_number,
            style_image_path = this.style_image_path,
            style_sid = this.style_sid,
            st_address_line1 = this.st_address_line1,
            st_address_line2 = this.st_address_line2,
            st_address_line3 = this.st_address_line3,
            st_address_line4 = this.st_address_line4,
            st_address_line5 = this.st_address_line5,
            st_address_line6 = this.st_address_line6,
            st_address_uid = this.st_address_uid,
            st_company_name = this.st_company_name,
            st_country = this.st_country,
            st_cuid = this.st_cuid,
            st_customer_lookup = this.st_customer_lookup,
            st_detax_flag = this.st_detax_flag,
            st_email = this.st_email,
            st_first_name = this.st_first_name,
            st_id = this.st_id,
            st_last_name = this.st_last_name,
            st_postal_code = this.st_postal_code,
            st_postal_code_extension = this.st_postal_code_extension,
            st_price_lvl = this.st_price_lvl,
            st_price_lvl_name = this.st_price_lvl_name,
            st_primary = this.st_primary,
            st_primary_phone_no = this.st_primary_phone_no,
            st_security_lvl = this.st_security_lvl,
            st_tax_area2_name = this.st_tax_area2_name,
            st_tax_area_name = this.st_tax_area_name,
            st_title = this.st_title,
            subloc_id = this.subloc_id,
            subsidiary_number = this.subsidiary_number,
            tax2_amount = this.tax2_amount,
            tax2_percent = this.tax2_percent,
            tax_amount = this.tax_amount,
            tax_area2_name = this.tax_area2_name,
            tax_area_name = this.tax_area_name,
            tax_char = this.tax_char,
            tax_char2 = this.tax_char2,
            tax_code = this.tax_code,
            tax_code2 = this.tax_code2,
            tax_code_rule2_sid = this.tax_code_rule2_sid,
            tax_code_rule_sid = this.tax_code_rule_sid,
            tax_message = this.tax_message,
            tax_message2 = this.tax_message2,
            tax_name = this.tax_name,
            tax_name2 = this.tax_name2,
            tax_percent = this.tax_percent,
            tax_perc_lock = this.tax_perc_lock,
            tenant_sid = this.tenant_sid,
            total_discount_amount = this.total_discount_amount,
            total_discount_percent = this.total_discount_percent,
            total_discount_reason = this.total_discount_reason,
            tracking_number = this.tracking_number,
            udf_date01 = this.udf_date01,
            udf_float01 = this.udf_float01,
            udf_float02 = this.udf_float02,
            udf_float03 = this.udf_float03,
            udf_string01 = this.udf_string01,
            udf_string02 = this.udf_string02,
            udf_string03 = this.udf_string03,
            udf_string04 = this.udf_string04,
            udf_string05 = this.udf_string05,
            udf_string06 = this.udf_string06,
            udf_string07 = this.udf_string07,
            udf_string08 = this.udf_string08,
            udf_string09 = this.udf_string09,
            udf_string10 = this.udf_string10,
            udf_string11 = this.udf_string11,
            udf_string12 = this.udf_string12,
            udf_string13 = this.udf_string13,
            udf_string14 = this.udf_string14,
            udf_string15 = this.udf_string15,
            user_discount_percent = this.user_discount_percent,
            vendor_code = this.vendor_code,
            KitFlagValue = this.KitFlagValue,
            non_inventory = this.non_inventory
        };

        if (this.discounts != null) {
            var discs = new List<Discount>();
            foreach (var disc in this.discounts) {
                discs.Add(disc.Clone());

            }
            item.discounts = discs.ToArray();
        }

        return item;
    }

}

public class InvoiceItemPost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string?  origin_application = "RProPrismWeb";
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? invn_sbs_item_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? fulfill_store_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? document_sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? kit_type = 0;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? item_type = 1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? quantity;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? manual_disc_value;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? manual_disc_type = 0;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? non_committed;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? original_price;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? gift_activation_code;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? gift_expire_date;



    public static InvoiceItemPost FromInvoiceItem(InvoiceItem item)
    {
        return new InvoiceItemPost()
        {
            document_sid = item.document_sid,
            fulfill_store_sid = item.fulfill_store_sid,
            invn_sbs_item_sid = item.invn_sbs_item_sid,
            item_type = item.item_type,
            kit_type = item.kit_type,
            manual_disc_type = item.manual_disc_type,
            manual_disc_value = item.manual_disc_value,
            quantity = Math.Abs(item.quantity.HasValue ? item.quantity.Value : 0)
        };
    }
}

