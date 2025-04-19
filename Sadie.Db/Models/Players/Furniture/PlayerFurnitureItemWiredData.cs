using System.ComponentModel.DataAnnotations;

namespace Sadie.Db.Models.Players.Furniture;

public class PlayerFurnitureItemWiredData
{
    [Key] public int Id { get; init; }
    public required int PlayerFurnitureItemPlacementDataId { get; init; }
    public required PlayerFurnitureItemPlacementData PlacementData { get; init; }
    public ICollection<PlayerFurnitureItemPlacementData> SelectedItems { get; init; } = [];
    public required string Message { get; init; }
    public int Delay { get; init; }
}