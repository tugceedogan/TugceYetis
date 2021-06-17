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


        //Devam edecek


    }
}
