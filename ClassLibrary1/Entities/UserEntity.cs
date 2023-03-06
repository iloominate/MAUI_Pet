using MauiApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Entities;

 public record UserEntity : IEntity
 {
    public required Guid Id { get; set; }
    public required string Name { get; set; }

    public required string Email { get; set; }
    public required string Password { get; set; }
    public ICollection<ItemEntity> Items { get; init; } = new List<ItemEntity>();
}
