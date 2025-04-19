namespace Sadie.Db.Models.Players;

public class PlayerSsoToken
{
    public int Id { get; init; }
    public long PlayerId { get; init; }
    public string? Token { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime ExpiresAt { get; init; }
    public DateTime? UsedAt { get; set; }
}