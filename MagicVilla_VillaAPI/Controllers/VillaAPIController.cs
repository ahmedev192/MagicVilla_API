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

        protected ApiResponse _response;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;

        public VillaAPIController(IVillaRepository dbVilla, IMapper mapper)
        {
            _dbVilla = dbVilla;
            _mapper = mapper;
            _response = new();
        }


        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetVillas()
        {
            try
            {
                IEnumerable<Villa> villaList = await _dbVilla.GetAllAsync();
                _response.Result = _mapper.Map<List<VillaDTO>>(villaList);
                _response.StatusCode = System.Net.HttpStatusCode.OK;


                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add(ex.ToString());

            }
            return _response;
        }




        [HttpGet("{id:int}", Name = "GetVilla")]
        [ProducesResponseType(typeof(VillaUpdateDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        public async Task<ActionResult<ApiResponse>> GetVilla([FromRoute] int id)
        {
            try
            {

                Villa model = await _dbVilla.GetAsync(u => u.Id == id);
                if (id == 0)
                    return BadRequest();
                else if (model == null)
                    return NotFound();
                _response.Result = _mapper.Map<VillaDTO>(model);
                _response.StatusCode = System.Net.HttpStatusCode.OK;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add(ex.ToString());

            }
            return _response;
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> CreateVilla([FromBody] VillaCreateDTO villaDTO)
        {
            try
            {
                if (await _dbVilla.GetAsync(u => u.Name.ToLower() == villaDTO.Name.ToLower()) != null)
                    ModelState.AddModelError("Custom Error .", $"This Villa Name Is Already Exist , Please Choose Another Name Like {villaDTO.Name}_123 ");
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                else if (villaDTO == null)
                    return BadRequest(villaDTO);
                var model = _mapper.Map<Villa>(villaDTO);
                await _dbVilla.CreateAsync(model);
                _response.Result = model;
                _response.StatusCode = System.Net.HttpStatusCode.OK;


                return CreatedAtRoute("GetVilla", new { id = model.Id }, _response);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add(ex.ToString());

            }
            return _response;
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public async Task<ActionResult<ApiResponse>> DeleteVilla(int id)
        {
            try
            {
                if (id <= 0)
                    return BadRequest();
                var model = await _dbVilla.GetAsync(u => u.Id == id);
                if (model == null)
                    return NotFound();
                else
                {
                    await _dbVilla.RemoveAsync(model);
                    _response.StatusCode = System.Net.HttpStatusCode.NoContent;
    
                    return Ok(_response);
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add(ex.ToString());

            }
            return _response;

        }


        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> UpdateVilla(int id, [FromBody] VillaUpdateDTO villaDTO)
        {
            try
            {
                if (id <= 0 || villaDTO.Id != id || villaDTO == null) return BadRequest();
                var model = _mapper.Map<Villa>(villaDTO);
                await _dbVilla.UpdateAsync(model);

                _response.StatusCode = System.Net.HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add(ex.ToString());

            }
            return _response;

        }


        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            try
            {
                if (patchDTO == null) return BadRequest();
                var model = await _dbVilla.GetAsync(u => u.Id == id, false);
                var villaDTO = _mapper.Map<VillaUpdateDTO>(model);
                if (model == null) return BadRequest();
                patchDTO.ApplyTo(villaDTO, ModelState);
                model = _mapper.Map<Villa>(villaDTO);
                await _dbVilla.UpdateAsync(model);
                if (!ModelState.IsValid) return BadRequest();



                _response.StatusCode = System.Net.HttpStatusCode.NoContent;

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages.Add(ex.ToString());

            }
            return _response;
        }


    }
}
