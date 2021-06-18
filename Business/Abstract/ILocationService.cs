using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationService
    {


        IDataResult<Location> GetLocationId(int LocationId);
        IDataResult<List<Location>> ListLocationByRegionId(int regionId);

        IDataResult<List<Location>> ListLocation();

        IResult Create(Location location);
        IResult Update(Location location);
        IResult Delete(Location location);
        IDataResult<int> CountLocation();
        IDataResult<List<Location>> ListLocationWithRegion();
        //Arama
        IDataResult<List<Location>> ListLocationPaging(int page, int pageSize);

        IDataResult<List<Location>> ListLocationWithRegionPaging(int page, int pageSize);
        //Arama
        IDataResult<List<Location>> ListLocationWithRegionAndSearchPaging(string search_text, int page, int pageSize);
        IDataResult<List<Location>> ListLocationWithRegionPagingByRegionId(int Id, int page, int pageSize);
        //Arama
        IDataResult<List<Location>> ListLocationWithRegionPagingByRegionIdAndSearch(string search_text, int Id, int page, int pageSize);
        IDataResult<List<Location>> ListLocationWithRegionPagingByRegionTitle(string search_text, int page, int pageSize);
        IDataResult<Location> GetLocationWithRegionByLocationId(int Id);
        IDataResult<List<Location>> ListLocationWithRegionByRegionId(int Id);
        IDataResult<int> CountLocationByRegionId(int Id);


    }
}
