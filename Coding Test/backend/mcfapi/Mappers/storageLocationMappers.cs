using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mcfapi.Dtos.storage_location;
using mcfapi.Models;

namespace mcfapi.Mappers
{
    public static class storageLocationMappers
    {
        public static storageLocationDto ToStorageLocationDto(this ms_storage_location storageLocationModel)
        {
            return new storageLocationDto
            {
                location_id = storageLocationModel.location_id,
                location_name = storageLocationModel.location_name,

            };
        }
    }
}