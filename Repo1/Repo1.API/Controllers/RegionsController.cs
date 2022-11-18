using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repo1.API.Models.Domain;
using Repo1.API.Repositories;

namespace Repo1.API.Controllers
{
    [ApiController]
    [Route("Regions")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
        }

        [HttpGet]
        public IActionResult GetAllRegions()
        {
           var regions = regionRepository.GetAll();

            //return the DTO regions
            
            //var regionsDTO= new List<Models.DTO.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id= region.Id,
            //        Name= region.Name,
            //        Code= region.Code,
            //        Area= region.Area,
            //        Lat= region.Lat,
            //        Long= region.Long,
            //        Population= region.Population,
            //    };
            //    regionsDTO.Add(regionDTO);
            //});


            return Ok(regions);
         
        }




    }
}
