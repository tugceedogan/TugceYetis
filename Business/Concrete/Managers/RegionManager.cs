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
    public class RegionManager : IRegionService
    {
        private IRegionDal _regionDal;

        public RegionManager(IRegionDal regionDal)
        {
            _regionDal = regionDal;
        }


        public IDataResult<int> CountRegion()
        {
            return new SuccessDataResult<int>(_regionDal.GetAll().Count());
        }

        public IResult Create(Region region)
        {
            _regionDal.Create(region);
            return new SuccessResult(Messages.SuccessTitle, Messages.Created);
        }

        public IResult Delete(Region region)
        {
            _regionDal.Delete(region);
            return new SuccessResult(Messages.SuccessTitle, Messages.Deleted);
        }

        public IDataResult<Region> GetRegionId(int RegionId)
        {
            return new SuccessDataResult<Region>(_regionDal.GetOne(p => p.regionId == RegionId));
        }

        public IDataResult<List<Region>> ListRegion()
        {
            return new SuccessDataResult<List<Region>>(_regionDal.GetAll().ToList());
        }

        public IResult Update(Region region)
        {
            _regionDal.Update(region);
            return new SuccessResult(Messages.SuccessTitle, Messages.Updated);
        }
    }
}
