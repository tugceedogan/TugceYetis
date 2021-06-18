using Business.Abstract;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Managers
{
    public class LocationManager : ILocationService
    {

        private ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }



        public IResult Create(Location location)
        {
            _locationDal.Create(location);
            return new SuccessResult(Messages.SuccessTitle, Messages.Created);
        }


        public IDataResult<int> CountLocation()
        {
            return new SuccessDataResult<int>(_locationDal.GetAll().Count());
        }

       
        public IResult Delete(Location location)
        {
            _locationDal.Delete(location);
            return new SuccessResult(Messages.SuccessTitle, Messages.Deleted);
        }

        public IDataResult<Location> GetLocationId(int LocationId)
        {
            return new SuccessDataResult<Location>(_locationDal.Get(p => p.location_id == LocationId));
        }

        public IDataResult<List<Location>> ListLocationPaging(int page, int pageSize)
        {
            return new SuccessDataResult<List<Location>>(_locationDal.ListLocationPaging(page,pageSize));
        }

        public IDataResult<List<Location>> ListLocation()
        {
            return new SuccessDataResult<List<Location>>(_locationDal.GetAll().ToList());
        }

        public IDataResult<List<Location>> ListLocationWithRegion()
        {
            return new SuccessDataResult<List<Location>>(_locationDal.ListLocationWithRegion());
        }

        public IDataResult<List<Location>> ListLocationByRegionId(int regionId)
        {
            return new SuccessDataResult<List<Location>>(_locationDal.GetAll(p => p.regionId==regionId).ToList());
        }

        public IResult Update(Location location)
        {
            _locationDal.Update(location);
            return new SuccessResult(Messages.SuccessTitle, Messages.Updated);
        }

        public IDataResult<List<Location>> ListLocationWithRegionPaging(int page, int pageSize)
        {
            return new SuccessDataResult<List<Location>>(_locationDal.ListLocationWithRegionPaging(page, pageSize));
        }

        public IDataResult<List<Location>> ListLocationWithRegionAndSearchPaging(string search_text, int page, int pageSize)
        {
            return new SuccessDataResult<List<Location>>(_locationDal.ListLocationWithRegionAndSearchPaging(search_text,page, pageSize));
        }

        public IDataResult<List<Location>> ListLocationWithRegionPagingByRegionId(int Id, int page, int pageSize)
        {
            return new SuccessDataResult<List<Location>>(_locationDal.ListLocationWithRegionPagingByRegionId(Id, page, pageSize));
        }

        public IDataResult<List<Location>> ListLocationWithRegionPagingByRegionIdAndSearch(string search_text, int Id, int page, int pageSize)
        {
            return new SuccessDataResult<List<Location>>(_locationDal.ListLocationWithRegionPagingByRegionIdAndSearch(search_text, Id, page, pageSize));
        }

        public IDataResult<List<Location>> ListLocationWithRegionPagingByRegionTitle(string search_text, int page, int pageSize)
        {
            return new SuccessDataResult<List<Location>>(_locationDal.ListLocationWithRegionPagingByRegionTitle(search_text, page, pageSize));
        }

        public IDataResult<Location> GetLocationWithRegionByLocationId(int Id)
        {
            return new SuccessDataResult<Location>(_locationDal.GetLocationWithRegionByLocationId(Id));
        }

        public IDataResult<List<Location>> ListLocationWithRegionByRegionId(int Id)
        {
            return new SuccessDataResult<List<Location>>(_locationDal.ListLocationWithRegionByRegionId(Id));
        }

        public IDataResult<int> CountLocationByRegionId(int Id)
        {
            return new SuccessDataResult<int>(_locationDal.CountLocationByRegioniId(Id));
        }
    }
}
