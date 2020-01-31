using System;
using System.Collections.Generic;
using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PMM.Common.Exceptions;
using PMM.DTO.Movies;
using PMM.ORM.Models;
using PMM.Service.Services;

namespace PersonalMovieManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMapper _mapper;
        private IMovieService _movieService;

        public MoviesController(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        /// <summary>
        /// Get movie information
        /// </summary>
        /// <remarks>
        /// {
        ///     "id": 5
        /// }
        /// </remarks>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllMovies()
        {
            throw new AppException("hahah");
        }

        /// <summary>
        /// Get single movie information by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetMovieById(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest($"Invalid movie id: {id}");
            var movieEntity = _movieService.GetMovieInfo(id);
            if (null == movieEntity)
                return NotFound($"Movie was not found with id: {id}");
            var result = _mapper.Map<MovieDto>(movieEntity);
            return Ok(result);
        }

        /// <summary>
        /// Create new movie information
        /// </summary>
        /// <param name="movieDto"></param>
        [HttpPost]
        public IActionResult CreateMovie([FromBody] MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest($"Invalid request: {movieDto}");
            var movieEntity = _mapper.Map<Movie>(movieDto);
            _movieService.CreateMovie(movieEntity);
            return Ok(movieDto);
        }

        /// <summary>
        /// Update single movie information
        /// </summary>
        /// <param name="movieDto"></param>
        [HttpPut("{id}")]
        public IActionResult UpdateMovie([FromBody] MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest($"Invalid request: {movieDto}");
            var movieEntity = _mapper.Map<Movie>(movieDto);
            _movieService.UpdateMovieInfo(movieEntity);
            return Ok();
        }

        /// <summary>
        /// Delete movie information.
        /// </summary>
        /// <remarks>
        /// DELETE / Movies
        /// {
        ///     "id" : 5
        /// }
        /// </remarks>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest($"Invalid movie id: {id}");
            _movieService.DeleteMovie(id);
            return Ok();
        }
    }
}