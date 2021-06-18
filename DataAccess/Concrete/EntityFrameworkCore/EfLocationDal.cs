using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.EntityFrameworkCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameworkCore
{
    public class EfLocationDal : EfEntityRepositoryBase<Location, AppDbContext>, ILocationDal
    {
        public List<Location> ListLocationWithRegionAndSearchPaging(string search_text, int page, int pageSize)
        {

            using (var context = new AppDbContext())
            {
                var cntxt = context.Locations.AsQueryable();
                cntxt = cntxt
                            .Include(i => i.Region);

                if (!string.IsNullOrEmpty(search_text))
                {
                    cntxt = cntxt.Where(q => q.title.Contains(search_text));
                }

                return cntxt.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public List<Location> ListLocationPaging(int page, int pageSize)
        {

            using (var context = new AppDbContext())
            {
                var cntxt = context.Locations.AsQueryable();
                return cntxt.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public List<Location> ListLocationWithRegion()
        {
            using (var context = new AppDbContext())
            {
                var cntxt = context.Locations.AsQueryable();
                cntxt = cntxt
                            .Include(i => i.Region);

                return cntxt.ToList();

          
            }
        }

        public List<Location> ListLocationWithRegionPaging(int page, int pageSize)
        {
            using (var context = new AppDbContext())
            {
                var cntxt = context.Locations.AsQueryable();
                cntxt = cntxt
                            .Include(i => i.Region);

                return cntxt.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public List<Location> ListLocationWithRegionPagingByRegionId(int Id, int page, int pageSize)
        {
            using (var context = new AppDbContext())
            {
                var cntxt = context.Locations.AsQueryable();
                cntxt = cntxt
                            .Include(i => i.Region);

                if (!string.IsNullOrEmpty(Id.ToString()))
                {
                    cntxt = cntxt.Where(i => i.regionId == Id);
                }

                return cntxt.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public List<Location> ListLocationWithRegionPagingByRegionIdAndSearch(string search_text, int Id, int page, int pageSize)
        {

            using (var context = new AppDbContext())
            {
                var cntxt = context.Locations.AsQueryable();

                if (!string.IsNullOrEmpty(Id.ToString()) && Id != 0)
                {
                    cntxt = cntxt.Where(i => i.regionId == Id);
                }

                if (!string.IsNullOrEmpty(search_text))
                {
                    cntxt = cntxt.Where(q => q.title.Contains(search_text));
                }
                cntxt = cntxt.Include(i => i.Region);

                return cntxt.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }


        }

        public List<Location> ListLocationWithRegionPagingByRegionTitle(string search_text, int page, int pageSize)
        {
            using (var context = new AppDbContext())
            {
                var cntxt = context.Locations.AsQueryable();
                if (!string.IsNullOrEmpty(search_text))
                {
                    cntxt = cntxt
                                .Include(i => i.Region)
                                .Where(i => i.Region.title == search_text);
                }
                return cntxt.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }

        public Location GetLocationWithRegionByLocationId(int Id)
        {
            using (var context = new AppDbContext())
            {
                return context.Locations
                             .Include(i => i.Region)
                             .Where(i => i.location_id == Id).SingleOrDefault();

            }
        }

        public List<Location> ListLocationWithRegionByRegionId(int Id)
        {
            using (var context = new AppDbContext())
            {
                return context.Locations
                            .Include(i => i.Region).ToList();

            }
        }

        public int CountLocationByRegioniId(int Id)
        {

            using (var context = new AppDbContext())
            {
                var cntxt = context.Locations.AsQueryable();

                if (!string.IsNullOrEmpty(Id.ToString()) && Id != 0)
                {
                    cntxt = cntxt
                                .Include(i => i.Region)
                                .Where(i => i.regionId == Id);
                }
                return cntxt.Count();
            }
        }
    }
}
