using Bulding_API_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bulding_Api_DAL.Repository
{
    public class BuildingRepo: IBuildingRepo
    {
        List<Building> buildingList = new List<Building>();

        public void AddBuilding(Building b)
        {
            buildingList.Add(b);
        }

        public List<Building> GetBuildings()
        {
            return buildingList;
        }

        public List<Building> GetBuilding(int id)
        {
            //var searchList = buildingList.FindAll(searchId => searchId.Equals(id));
            //return searchList;
            return buildingList.FindAll(searchId => searchId.Id.Equals(id));
        }

        public void UpdateBuilding(int id, Building b)
        {
            var searchList = buildingList.FirstOrDefault(s => s.Id == id);
            searchList.Name = b.Name;
            searchList.Description = b.Description;
        }

        public void DeleteBuilding(int id)
        {
            foreach (var building in buildingList.Where(build => build.Id == id).ToList()) buildingList.Remove(building);
            //Console.WriteLine("Building deleted");
        }
    }
}
