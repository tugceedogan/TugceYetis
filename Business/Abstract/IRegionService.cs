using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRegionService
    {

        IDataResult<Region> GetRegionId(int RegionId);
        IDataResult<List<Region>> ListRegion();
        IResult Create(Region region);
        IResult Update(Region region);
        IResult Delete(Region region);
        IDataResult<int> CountRegion();
    }
}
