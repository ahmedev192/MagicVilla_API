using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTOs;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{

    // [Route("api/VillaAPI")]
    [Route("api/[Controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {

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
        public IActionResult GetVillas()
        {
            return Ok(Villas.villas);
        }




        [HttpGet("{id:int}", Name = "GetVilla")]
        //[ProducesResponseType(typeof(VillaDTO), 200)]
        //[ProducesResponseType(typeof(VillaDTO), 404)]
        //[ProducesResponseType(typeof(VillaDTO), 400)]

        /* Best Practice */
        [ProducesResponseType(typeof(VillaDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(VillaDTO), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(VillaDTO), StatusCodes.Status400BadRequest)]
        public IActionResult GetVilla(int id)
        {


            VillaDTO villa = Villas.villas.FirstOrDefault(u => u.Id == id);
            if (id == 0)
                return BadRequest();
            else if (villa == null)
                return NotFound();

            return Ok(villa);
        }



        [HttpPost]
        [ProducesResponseType( StatusCodes.Status201Created)]
        [ProducesResponseType( StatusCodes.Status404NotFound)]
        [ProducesResponseType( StatusCodes.Status400BadRequest)]
        public IActionResult CreateVilla(VillaDTO villa)
        {
            if (Villas.villas.FirstOrDefault(u => u.Name.ToLower() == villa.Name.ToLower()) != null)
                ModelState.AddModelError("Custom Error .", $"This Villa Name Is Already Exist , Please Choose Another Name Like {villa.Name}_123 ");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else if (villa == null)
                return BadRequest(villa);
            else if (villa.Id > 0)
                return StatusCode(StatusCodes.Status500InternalServerError);
            villa.Id = Villas.villas.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
            Villas.villas.Add(villa);
            return CreatedAtRoute("GetVilla", new { id = villa.Id }, villa);
        }

        [ProducesResponseType( StatusCodes.Status204NoContent)]
        [ProducesResponseType( StatusCodes.Status404NotFound)]
        [ProducesResponseType( StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}" ,Name = "DeleteVilla")]
        public IActionResult DeleteVilla(int id)
        {
            if (id <= 0)
                return BadRequest();
            else if (Villas.villas.FirstOrDefault(u => u.Id == id) == null)
                return NotFound();
            else
                Villas.villas.Remove(Villas.villas.FirstOrDefault(u => u.Id == id));
            return NoContent();
        }


        [HttpPut("{id:int}", Name="UpdateVilla")]
        [ProducesResponseType(typeof(VillaDTO), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(VillaDTO), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(VillaDTO), StatusCodes.Status400BadRequest)]
        public IActionResult UpdateVilla(int id , [FromBody] VillaDTO villa)
        {
            if(id <= 0|| villa.Id != id || villa == null) return BadRequest();
            var v = Villas.villas.FirstOrDefault(u => u.Id == id);
            v.Name = villa.Name;
            v.Occupancy = villa.Occupancy;
            v.Sqft = villa.Sqft;
            return NoContent();

        }


        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(typeof(VillaDTO), StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(VillaDTO), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(VillaDTO), StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaDTO> patchDTO )
        {
            if(patchDTO == null) return BadRequest();
            var villa = Villas.villas.FirstOrDefault(u=>u.Id == id);
            if(villa == null) return BadRequest();
            patchDTO.ApplyTo(villa, ModelState);
            if (!ModelState.IsValid) return BadRequest();
            return NoContent();

        }






    }
}
