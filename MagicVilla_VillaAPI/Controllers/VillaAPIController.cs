using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Loger;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTOs;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVilla_VillaAPI.Controllers
{

    // [Route("api/VillaAPI")]
    [Route("api/[Controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        /*
         * Using Serilog Logging
        private ILogger<VillaAPIController> _logger { get; }


        public VillaAPIController(ILogger<VillaAPIController> logger)
        {
            _logger = logger;
        }

        */


        private readonly ApplicationDbContext _db;


        public VillaAPIController(ApplicationDbContext db)
        {
            _db = db;
        }




        /*
         IEnumerable<T> is an interface that tells us that we can enumerate over a sequence of T instances.
        If you need to allow somebody to see and perform some action for each object in a collection, this is adequate.

        List<T>, on the other hand, is a specific implementation of IEnumerable<T> that stores the objects in a specific,
        known manner. Internally, this may be a very good way to store your values that you expose via IEnumerable<T>,
        but a List<T> is not always appropriate. For example, if you do not need to access items by index,
        but constantly insert items at the beginning of your collection and then remove items from the end, a Queue<T> would be far more appropriate to use.

        By using IEnumerable<T> in your API, you provide yourself the flexibility to change the internal implementation at any time without changing any other code.
        This has huge benefits in terms of allowing your code to be flexible and maintainable.
         */
        [HttpGet]
        public async Task<IActionResult> GetVillas()
        {
            return Ok(await _db.Villas.ToListAsync());
        }




        [HttpGet("{id:int}", Name = "GetVilla")]
        //[ProducesResponseType(typeof(VillaDTO), 200)]
        //[ProducesResponseType( 404)]
        //[ProducesResponseType( 400)]

        // Best Practice 
        [ProducesResponseType(typeof(VillaUpdateDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        public async Task<IActionResult> GetVilla([FromRoute] int id)
        {


            Villa model = await _db.Villas.FirstOrDefaultAsync(u => u.Id == id);
            if (id == 0)
                return BadRequest();
            else if (model == null)
                return NotFound();
            VillaUpdateDTO villaDTO = new VillaUpdateDTO();
            villaDTO.Id = model.Id;
            villaDTO.ImageURL = model.ImageURL;
            villaDTO.Amenity = model.Amenity;
            villaDTO.Sqft = model.Sqft;
            villaDTO.Rate = model.Rate;
            villaDTO.Details = model.Details;
            villaDTO.Occupancy = model.Occupancy;
            villaDTO.Name = model.Name;

            return Ok(villaDTO);
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateVilla([FromBody] VillaCreateDTO villaDTO)
        {
            if (await _db.Villas.FirstOrDefaultAsync(u => u.Name.ToLower() == villaDTO.Name.ToLower()) != null)
                ModelState.AddModelError("Custom Error .", $"This Villa Name Is Already Exist , Please Choose Another Name Like {villaDTO.Name}_123 ");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else if (villaDTO == null)
                return BadRequest(villaDTO);
            //else if (villaDTO.Id > 0)
            //    return StatusCode(StatusCodes.Status500InternalServerError);
            Villa model = new Villa()
            {
                Name = villaDTO.Name,
                Occupancy = villaDTO.Occupancy,
                Details = villaDTO.Details,
                Sqft = villaDTO.Sqft,
                Amenity = villaDTO.Amenity,
                ImageURL = villaDTO.ImageURL,
                Rate = villaDTO.Rate,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            await _db.Villas.AddAsync(model);
            await _db.SaveChangesAsync();

            // Return a 201 Created response with a Location header pointing to the newly created resource.
            // Params:
            // - routeName: "GetVilla" specifies the name of the route to use for generating the URL.
            //              It should match the name specified in the route attribute of the target endpoint.
            // - routeValues: new { id = createdVilla.Id } specifies route values used to replace tokens
            //                in the route template of the specified routeName.
            //                Here, it provides the id of the newly created resource for the "GetVilla" route.
            // - value: createdVillaDTO represents the content to format in the response body.
            //          It typically includes the newly created resource or relevant details for client consumption.

            return CreatedAtRoute("GetVilla", new { id = model.Id }, model);
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            if (id <= 0)
                return BadRequest();
            else if (_db.Villas.FirstOrDefault(u => u.Id == id) == null)
                return NotFound();
            else
            {
                _db.Villas.Remove(_db.Villas.FirstOrDefault(u => u.Id == id));
                await _db.SaveChangesAsync();
                return NoContent();
            }

        }


        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateVilla(int id, [FromBody] VillaUpdateDTO villaDTO)
        {
            if (id <= 0 || villaDTO.Id != id || villaDTO == null) return BadRequest();
            var model = new Villa()
            {
                Id = id,
                Name = villaDTO.Name,
                Occupancy = villaDTO.Occupancy,
                Details = villaDTO.Details,
                Sqft = villaDTO.Sqft,
                Amenity = villaDTO.Amenity,
                ImageURL = villaDTO.ImageURL,
                Rate = villaDTO.Rate,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            _db.Update(model);
            await _db.SaveChangesAsync();

            return NoContent();

        }


        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if (patchDTO == null) return BadRequest();
            var model = await _db.Villas.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
            var villaDTO = new VillaUpdateDTO()
            {
                Id = model.Id,
                Name = model.Name,
                Occupancy = model.Occupancy,
                Details = model.Details,
                Sqft = model.Sqft,
                Amenity = model.Amenity,
                ImageURL = model.ImageURL,
                Rate = model.Rate,
            };

            if (model == null) return BadRequest();
            patchDTO.ApplyTo(villaDTO, ModelState);
            model = new Villa()
            {
                Id = villaDTO.Id,
                Name = villaDTO.Name,
                Occupancy = villaDTO.Occupancy,
                Details = villaDTO.Details,
                Sqft = villaDTO.Sqft,
                Amenity = villaDTO.Amenity,
                ImageURL = villaDTO.ImageURL,
                Rate = villaDTO.Rate,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            _db.Update(model);
            await _db.SaveChangesAsync();
            if (!ModelState.IsValid) return BadRequest();
            return NoContent();

        }


    }
}
