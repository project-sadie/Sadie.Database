namespace Sadie.Db.Models.Players;

public class PlayerBadge
{
    public int Id { get; init; }
    public long PlayerId { get; init; }
    public int BadgeId { get; init; }
    public Badge? Badge { get; init; }
    public int Slot { get; init; }
}