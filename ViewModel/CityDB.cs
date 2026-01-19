using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class CityDB:BaseDB
    {
        public CityList SelectAl()
        {
            command.CommandText = $"SELEST *FROM CityRbl";
            CityList groupList = new CityList(base.Select());
            return groupList;

        }
        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            City ct = entity as City;
            ct.CityName = reader["CityName"].ToString();
            base.CreateModel(entity);
            return ct;
        }
        public override BaseEntity NewEntity()
        {
            return new City();
        }
        
    }
}
