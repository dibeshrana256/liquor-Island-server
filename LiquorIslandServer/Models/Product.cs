
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;


namespace LiquorIslandServer.Controllers.Models
{
    [Table("Product")]
    public class Product : BaseModel
    {
        [PrimaryKey("id", false)]
        public int Id { get; set; }
        [Column("upc_id")]
        public string? Upc_Id { get; set; }
        [Column("sku_id")]
        public string? Sku_Id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("category_1")]
        public string? Category_1 { get; set; }
        [Column("category_2")]
        public string? Category_2 { get; set; }
        [Column("price")]
        public decimal? Price { get; set; }
        [Column("currency")]
        public string? Currency { get; set; }
        [Column("status")]
        public bool Status { get; set; }
        [Column("created_at")]
        public DateTime? Created_At { get; set; }
    }
}
