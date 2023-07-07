﻿using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ILocationRepository
    {
        List<LocationDTO> GetLocations();
        void AddLocation(LocationDTO LocationDTO);
        void UpdateLocation(LocationDTO LocationDTO);
        void DeleteLocation(int id);
    }
}