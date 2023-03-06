using MauiApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp.DAL.Entities;

public record ItemEntity : IEntity
{
    // TO DO: establish connection between Item and User
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }


}
