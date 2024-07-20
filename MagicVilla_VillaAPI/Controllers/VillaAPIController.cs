using AutoMapper;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTOs;
using MagicVilla_VillaAPI.Repository;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {


        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;

        public VillaAPIController(IVillaRepository dbVilla, IMapper mapper)
        {
            _dbVilla = dbVilla;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetVillas()
        {
            IEnumerable<Villa> villaList = await _dbVilla.GetAllAsync();
            return Ok(_mapper.Map<List<VillaUpdateDTO>>(villaList));
        }




        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(typeof(VillaUpdateDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        public async Task<IActionResult> GetVilla([FromRoute] int id)
        {


            Villa model = await _dbVilla.GetAsync(u => u.Id == id);
            if (id == 0)
                return BadRequest();
            else if (model == null)
                return NotFound();
            return Ok(_mapper.Map<VillaUpdateDTO>(model));
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateVilla([FromBody] VillaCreateDTO villaDTO)
        {
            if (await _dbVilla.GetAsync(u => u.Name.ToLower() == villaDTO.Name.ToLower()) != null)
                ModelState.AddModelError("Custom Error .", $"This Villa Name Is Already Exist , Please Choose Another Name Like {villaDTO.Name}_123 ");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else if (villaDTO == null)
                return BadRequest(villaDTO);
            var model = _mapper.Map<Villa>(villaDTO);
            await _dbVilla.CreateAsync(model);
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
            var model = await _dbVilla.GetAsync(u => u.Id == id);
            if (model == null)
                return NotFound();
            else
            {
                await _dbVilla.RemoveAsync(model);
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
            var model = _mapper.Map<Villa>(villaDTO);
            await _dbVilla.UpdateAsync(model);

            return NoContent();

        }


        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if (patchDTO == null) return BadRequest();
            var model = await _dbVilla.GetAsync(u => u.Id == id,false);
            var villaDTO = _mapper.Map<VillaUpdateDTO>(model);
            if (model == null) return BadRequest();
            patchDTO.ApplyTo(villaDTO, ModelState);
            model = _mapper.Map<Villa>(villaDTO);
            await _dbVilla.UpdateAsync(model);
            if (!ModelState.IsValid) return BadRequest();
            return NoContent();

        }


    }
}
