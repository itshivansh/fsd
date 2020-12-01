using Bulding_API_Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bulding_Api_DAL.Repository
{
    public interface IBuildingRepo
    {
        void AddBuilding(Building b);
        List<Building> GetBuildings();
        // Building GetBulding(int id);
        List<Building> GetBuilding(int id);
        void UpdateBuilding(int id, Building b);

        void DeleteBuilding(int id);

    }
}
