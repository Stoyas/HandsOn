using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PMM.Service.Services;

namespace PersonalMovieManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
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
        public IActionResult Get()
        {
            return Ok();
        }

        /// <summary>
        /// Get single movie information by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetMovieById(int id)
        {
            var movieEntity = _movieService.GetMovieInfo(id);
            return Ok(movieEntity);
        }

        /// <summary>
        /// Create new movie information
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void CreateMovie([FromBody] string value)
        {
        }

        /// <summary>
        /// Update single movie information
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void UpdateMovie(int id, [FromBody] string value)
        {

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
        public void DeleteMovie(int id)
        {
        }
    }
}
