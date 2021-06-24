using Business.Abstract;
using Core.AdminUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonetimUI.ViewModels;
using Entities.Concrete;
namespace YonetimUI.Controllers
{
    public class LocationController : Controller
    {

        ILocationService _locationService;
        IRegionService _regionService;

        public LocationController(ILocationService locationService, IRegionService regionService)
        {
            _locationService = locationService;
            _regionService = regionService;

        }

        [HttpGet]
        public IActionResult Index(int limit, string text, int regionId, int page = 1)
        {
            if (limit == 0)
            {
                limit = 10;
            }

            //const int pageSize = 10;
            var locations = _locationService.ListLocationWithRegionPagingByRegionIdAndSearch(text, regionId, page, limit);

            if (locations.Success)
            {

                var models = new LocationViewModel()
                {
                    title = "Lokasyonlar",
                    message = "Bu konumda lokasyon bilgileriniz listelenmektedir.",
                    Locations = locations.Data,
                    PagingInfo = new PagingInfo()
                    {
                        CurrentPage = page,
                        ItemsPerPage = limit,
                        TotalItems = _locationService.CountLocationByRegionId(regionId).Data
                        //CurrentCategory = radioApiId

                    }

                };

                List<SelectListItem> note = new List<SelectListItem>();
                note.Insert(0, new SelectListItem() { Value = "0", Text = " --- Bölge Seçiniz --- " });
                //foreach (var item in _radioApiService.ListWebRadio().Data)
                //{
                //    var selectList = new SelectListItem
                //    {
                //        Text = item.title,
                //        Value = item.radioApiId.ToString(),
                //    };
                //    note.Add(selectList);
                //}
                models.RegionsListItem = note;

                if (!string.IsNullOrEmpty(text))
                {
                    models.Search = text;
                }


                return View(models);


            }
            return View();



















            //if (djs.Success)
            //{


            //}
            //else
            //{
            //    TempData.Put("message", new ResultMessage()
            //    {
            //        Title = ProsesMessages.TitleError,
            //        Message = ProsesMessages.MessageError,
            //        Css = ProsesMessages.CssError,
            //    });
            //    return View();
            //}
        }

        [HttpGet]
        public IActionResult Create()
        {
            LocationViewModel model = new LocationViewModel()
            {
                title = "Yeni Lokasyon Ekleme Bölümü",
                RegionsListItem = new SelectList(_regionService.ListRegion().Data, "regionId", "title", " -- Seçim Yapınız -- "),
                Location = new Location(),

            };
            return View(model);
        }



        [HttpPost]
        public IActionResult Create(LocationViewModel model)
        {



            return View("Index");

        }
    }
}
