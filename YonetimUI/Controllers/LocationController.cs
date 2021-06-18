using Business.Abstract;
using Core.AdminUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YonetimUI.ViewModels;

namespace YonetimUI.Controllers
{
    public class LocationController : Controller
    {
   
        ILocationService _locationService;
        public LocationController(ILocationService LocationService)
        {
            _locationService = LocationService;
        }


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

                     = djs.Data,
                    PagingInfo = new PagingInfo()
                    {
                        CurrentPage = page,
                        ItemsPerPage = limit,
                        TotalItems = _djService.CountDjByradioApiId(radioApiId).Data,
                        //CurrentCategory = radioApiId

                    }
                };

            }

















            if (djs.Success)
            {
                var models = new DjListViewModel()
                {
                    title = "Dj Listesi",
                    Djs = djs.Data,
                    //RadiosApi = new SelectList(_radioApiService.ListWebRadio().Data, "radioApiId", "title"),
                    PagingInfo = new PagingInfo()
                    {
                        CurrentPage = page,
                        ItemsPerPage = limit,
                        TotalItems = _djService.CountDjByradioApiId(radioApiId).Data,
                        //CurrentCategory = radioApiId

                    }
                };
                List<SelectListItem> note = new List<SelectListItem>();
                note.Insert(0, new SelectListItem() { Value = "0", Text = " --- Radyo Seçiniz --- " });
                foreach (var item in _radioApiService.ListWebRadio().Data)
                {
                    var selectList = new SelectListItem
                    {
                        Text = item.title,
                        Value = item.radioApiId.ToString(),
                    };
                    note.Add(selectList);
                }
                models.RadiosApi = note;

                if (!string.IsNullOrEmpty(metin))
                {
                    models.Search = metin;
                }


                return View(models);
            }
            else
            {
                TempData.Put("message", new ResultMessage()
                {
                    Title = ProsesMessages.TitleError,
                    Message = ProsesMessages.MessageError,
                    Css = ProsesMessages.CssError,
                });
                return View();
            }
        }
    }
}
