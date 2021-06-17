using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ILocationDal: IEntityRepository<Location>
    {

        List<Location> ListLocationWithRegion();
        List<Location> ListLocationPaging(int page, int pageSize);
        List<Location> ListLocationWithRegionPaging(int page, int pageSize);

        //Arama
        List<Location> LisLocationWithRegionAndSearchPaging(string search_text, int page, int pageSize);

        List<Location> ListLocationWithRegionPagingByRegionId(int Id, int page, int pageSize);

        //Arama
        List<Location> ListLocationWithRegionPagingByRegionIdAndSearch(string search_text, int Id, int page, int pageSize);

        List<Location> ListLocationWithRegionPagingByRegionSearch(string search_text, int page, int pageSize);


    }
}
