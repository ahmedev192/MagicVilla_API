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
    public class VillaNumberAPIController : ControllerBase
    {

        protected ApiResponse _response;
        private readonly IVillaNumberRepository _dbVillaNumber;
        private readonly IVillaRepository _dbVilla;
        private readonly IMapper _mapper;

        public VillaNumberAPIController(IVillaNumberRepository dbVillaNumber, IMapper mapper, IVillaRepository dbVilla)
        {
            _dbVillaNumber = dbVillaNumber;
            _mapper = mapper;
            _response = new();
            _dbVilla = dbVilla;
        }


        [HttpGet]
        public async Task<ActionResult<ApiResponse>> GetVillas()
        {
            try
            {
                IEnumerable<VillaNumber> villaList = await _dbVillaNumber.GetAllAsync();
                _response.Result = _mapper.Map<List<VillaNumberDTO>>(villaList);
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




        [HttpGet("{villaNumber:int}", Name = "GetVillaNumber")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status406NotAcceptable)]
        public async Task<ActionResult<ApiResponse>> GetVillaNumber([FromRoute] int villaNumber)
        {
            try
            {

                VillaNumber model = await _dbVillaNumber.GetAsync(u => u.VillaNo == villaNumber);
                if (villaNumber == 0)
                    return BadRequest();
                else if (model == null)
                    return NotFound();
                _response.Result = _mapper.Map<VillaNumberDTO>(model);
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
        public async Task<ActionResult<ApiResponse>> CreateVillaNumber([FromBody] VillaNumberCreateDTO villaDTO)
        {
            try
            {
                if (await _dbVillaNumber.GetAsync(u => u.VillaNo == villaDTO.VillaNumber) != null)
                    ModelState.AddModelError("Custom Error .", $"This VillaNumber Name Is Already Exist , Please Choose Another Name Like {villaDTO.VillaNumber}_123 ");
                if(await _dbVilla.GetAsync(u=>u.Id == villaDTO.VillaID) == null)
                    ModelState.AddModelError("Custom Error .", $"This Villa ID Is Not Exist , Please Choose Valid ID ");

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                else if (villaDTO == null)
                    return BadRequest(villaDTO);
                var model = _mapper.Map<VillaNumber>(villaDTO);
                await _dbVillaNumber.CreateAsync(model);
                _response.Result = model;
                _response.StatusCode = System.Net.HttpStatusCode.OK;


                return CreatedAtRoute("GetVillaNumber", new { id = model.VillaNo }, _response);

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
        [HttpDelete("{villaNumber:int}", Name = "DeleteVillaNumber")]
        public async Task<ActionResult<ApiResponse>> DeleteVillaNumber(int villaNumber)
        {
            try
            {
                if (villaNumber <= 0)
                    return BadRequest();
                var model = await _dbVillaNumber.GetAsync(u => u.VillaNo == villaNumber);
                if (model == null)
                    return NotFound();
                else
                {
                    await _dbVillaNumber.RemoveAsync(model);
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


        [HttpPut("{villaNumber:int}", Name = "UpdateVillaNumber")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ApiResponse>> UpdateVillaNumber(int villaNumber, [FromBody] VillaNumberUpdateDTO villaDTO)
        {
            try
            {
                if (await _dbVilla.GetAsync(u => u.Id == villaDTO.VillaID) == null) { 
                    ModelState.AddModelError("Custom Error .", $"This Villa ID Is Not Exist , Please Choose Valid ID ");
                    return BadRequest(ModelState);
                }
                if (villaNumber <= 0 || villaDTO.VillaNumber != villaNumber || villaDTO == null) return BadRequest();
                var model = _mapper.Map<VillaNumber>(villaDTO);
                await _dbVillaNumber.UpdateAsync(model);

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


        //[HttpPatch("{villaNumber:int}", Name = "UpdatePartialVillaNumber")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<ActionResult<ApiResponse>> UpdatePartialVillaNumber(int villaNumber, JsonPatchDocument<VillaNumberUpdateDTO> patchDTO)
        //{
        //    try
        //    {
        //        if (patchDTO == null) return BadRequest();
        //        var model = await _dbVillaNumber.GetAsync(u => u.VillaNo == villaNumber, false);
        //        var villaDTO = _mapper.Map<VillaNumberUpdateDTO>(model);
        //        if (model == null) return BadRequest();
        //        patchDTO.ApplyTo(villaDTO, ModelState);
        //        model = _mapper.Map<VillaNumber>(villaDTO);
        //        await _dbVillaNumber.UpdateAsync(model);
        //        if (!ModelState.IsValid) return BadRequest();



        //        _response.StatusCode = System.Net.HttpStatusCode.NoContent;

        //        return Ok(_response);
        //    }
        //    catch (Exception ex)
        //    {
        //        _response.IsSuccess = false;
        //        _response.ErrorMessages.Add(ex.ToString());

        //    }
        //    return _response;
        //}


    }
}
