namespace CycleCount.Models
{
    public class CycleCountItem
    {
        public long ItemSid { get; set; }

        public long StoreSid { get; set; }

        public string ALU { get; set; } = "";

        public string Description1 { get; set; } = "";

        public string Description2 { get; set; } = "";

        public string Attribute { get; set; } = "";

        public string Size { get; set; } = "";

        // Hidden from user
        public decimal SystemQty { get; set; }

        // User enters this
        public decimal CountedQty { get; set; } = 0;
    }
}
