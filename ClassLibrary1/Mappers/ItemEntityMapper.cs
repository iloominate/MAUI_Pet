using ClassLibrary1.Mappers;
using MauiApp.DAL.Entities;
using MauiApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp.DAL.Mappers;

internal class ItemEntityMapper : IEntityMapper<ItemEntity>
{
    public void MapToExistingEntity(ItemEntity existingEntity, ItemEntity newEntity)
    {
       existingEntity.Name = newEntity.Name;
       existingEntity.Description = newEntity.Description;
    }
}

