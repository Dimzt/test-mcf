using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mcfapi.Dtos.user;
using mcfapi.Models;

namespace mcfapi.Mappers
{
    public static class userMappers
    {
        public static userDto ToUserDto(this ms_user userModel)
        {
            return new userDto
            {
                // user_id = userModel.user_id,
                user_name = userModel.user_name,
                password = userModel.password,
                // is_active = userModel.is_active
            };
        }
    }
}