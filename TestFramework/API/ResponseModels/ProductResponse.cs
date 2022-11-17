using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsFramework.Api.ResponseModels
{
    public class ProductResponse
    {
        public Data data { get; set; }
        public bool success { get; set; }
    }

    public class Data
    {
        public int id { get; set; }
        public string title { get; set; }
        public string price { get; set; }
        public string old_price { get; set; }
        public string price_pcs { get; set; }
        public string href { get; set; }
        public string name { get; set; }
        public int comments_amount { get; set; }
        public string sell_status { get; set; }
        public string status { get; set; }
        public string status_inherited { get; set; }
        public string comments_mark { get; set; }
        public int category_id { get; set; }
        public int seller_id { get; set; }
        public int merchant_id { get; set; }
        public int group_id { get; set; }
        public int producer_id { get; set; }
        public string docket { get; set; }
        public string state { get; set; }
        public object title_short { get; set; }
        public string promo_title_part { get; set; }
        public string mpath { get; set; }
        public bool is_set { get; set; }
        public string brand { get; set; }
        public int brand_id { get; set; }
        public string brand_name { get; set; }
        public object brand_logo { get; set; }
        public Breadcrumb[] breadcrumbs { get; set; }
        public Last_Category last_category { get; set; }
        public Image[] images { get; set; }
        public Tag tag { get; set; }
        public int sla_id { get; set; }
        public int is_markdown { get; set; }
        public bool use_group_links { get; set; }
        public object[] custom_buttons { get; set; }
        public string article { get; set; }
        public Recount_Info recount_info { get; set; }
        public Cart_Quantity cart_quantity { get; set; }
        public bool has_alternate { get; set; }
        public bool isCanonical { get; set; }
        public int discount { get; set; }
        public string mark_percent { get; set; }
        public Adult_Alert adult_alert { get; set; }
        public string[] warning { get; set; }
        public object[] videos { get; set; }
        public object[] video_presentation { get; set; }
        public Description description { get; set; }
        public bool isPreorder { get; set; }
        public Seo seo { get; set; }
        public string short_title { get; set; }
        public object size_chart_link { get; set; }
        public bool size_chart_in_modal { get; set; }
        public object size_chart_goods_option { get; set; }
        public object[] documents { get; set; }
        public object order_counter { get; set; }
        public Category category { get; set; }
        public bool forbid_comment { get; set; }
        public bool forbid_question { get; set; }
    }

    public class Last_Category
    {
        public int id { get; set; }
        public string title { get; set; }
        public string href { get; set; }
        public string rz_mpath { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public string title { get; set; }
        public int priority { get; set; }
    }

    public class Recount_Info
    {
        public string goods_value { get; set; }
        public string goods_unit { get; set; }
        public string goods_value_recount { get; set; }
        public int goods_price_recount { get; set; }
    }

    public class Cart_Quantity
    {
        public int min { get; set; }
        public object max { get; set; }
    }

    public class Adult_Alert
    {
        public string text { get; set; }
        public string label { get; set; }
    }

    public class Description
    {
        public string text { get; set; }
        public object html { get; set; }
        public bool isRichNoLimit { get; set; }
    }

    public class Seo
    {
        public Breadcrumblist BreadcrumbList { get; set; }
        public Product Product { get; set; }
    }

    public class Breadcrumblist
    {
        public string context { get; set; }
        public string type { get; set; }
        public Itemlistelement[] ItemListElement { get; set; }
    }

    public class Itemlistelement
    {
        public string type { get; set; }
        public int position { get; set; }
        public Item item { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Product
    {
        public string context { get; set; }
        public string type { get; set; }
        public string sku { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string[] image { get; set; }
        public string description { get; set; }
        public string itemCondition { get; set; }
        public Offers offers { get; set; }
        public Brand brand { get; set; }
        public string gtin13 { get; set; }
    }

    public class Offers
    {
        public string type { get; set; }
        public string availability { get; set; }
        public string url { get; set; }
        public string price { get; set; }
        public string priceCurrency { get; set; }
        public DateTime priceValidUntil { get; set; }
    }

    public class Brand
    {
        public string type { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Category
    {
        public bool isSuperMarket { get; set; }
    }

    public class Breadcrumb
    {
        public int id { get; set; }
        public string title { get; set; }
        public string href { get; set; }
    }

    public class Image
    {
        public long id { get; set; }
        public Original original { get; set; }
        public Base_Action base_action { get; set; }
        public Preview preview { get; set; }
        public Small small { get; set; }
        public Medium medium { get; set; }
        public Large large { get; set; }
        public Big_Tile big_tile { get; set; }
        public Big big { get; set; }
        public Mobile_Medium mobile_medium { get; set; }
        public Mobile_Large mobile_large { get; set; }
    }

    public class Original
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Base_Action
    {
        public string url { get; set; }
        public object width { get; set; }
        public object height { get; set; }
    }

    public class Preview
    {
        public string url { get; set; }
        public object width { get; set; }
        public object height { get; set; }
    }

    public class Small
    {
        public string url { get; set; }
        public object width { get; set; }
        public object height { get; set; }
    }

    public class Medium
    {
        public string url { get; set; }
        public object width { get; set; }
        public object height { get; set; }
    }

    public class Large
    {
        public string url { get; set; }
        public object width { get; set; }
        public object height { get; set; }
    }

    public class Big_Tile
    {
        public string url { get; set; }
        public object width { get; set; }
        public object height { get; set; }
    }

    public class Big
    {
        public string url { get; set; }
        public object width { get; set; }
        public object height { get; set; }
    }

    public class Mobile_Medium
    {
        public string url { get; set; }
        public object width { get; set; }
        public object height { get; set; }
    }

    public class Mobile_Large
    {
        public string url { get; set; }
        public object width { get; set; }
        public object height { get; set; }
    }
}
