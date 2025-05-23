using Sadie.Db.Models.Players;

namespace Sadie.Db.Models;

public class Group
{
    public int Id { get; init; }
    public long PlayerId { get; init; }
    public required string Name { get; init; }
    public required string Description { get; init; }
    public int RoomId { get; init; }
    public int CreatedAt { get; init; }
    public ICollection<Player> Players { get; init; } = [];
}