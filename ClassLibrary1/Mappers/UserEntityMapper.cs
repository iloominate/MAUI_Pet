using MauiApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Mappers;


public class UserEntityMapper : IEntityMapper<UserEntity>
{
    public void MapToExistingEntity(UserEntity exisingEntity, UserEntity newEntity)
    {
        exisingEntity.Id = newEntity.Id;
        exisingEntity.Email = newEntity.Email;
        exisingEntity.Name = newEntity.Name;
        exisingEntity.Password = newEntity.Password;

    }
}
