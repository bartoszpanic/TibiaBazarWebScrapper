namespace TibiaBazar.Domain.Entity
{
    public class Auction
    {
        public DateTimeOffset AuctionStart { get; set; }
        public DateTimeOffset AuctionEnd { get; set; }
        public int MinimumBid { get; set; }
        public Character Character { get; set; } = new();
    }
}
