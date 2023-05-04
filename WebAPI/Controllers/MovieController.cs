using Aplicacion.Commands.Movie;
using Aplicacion.Dtos;
using Aplicacion.Services.Comandos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MovieController
    {
        private readonly ICommandBus commandBus;


        public MovieController(ICommandBus commandBus)
        {
            this.commandBus = commandBus;

        }

        // POST: api/Prducto
        [HttpPost("rate-movie", Name = "rateMovie")]
        public IResponse RateMovie([FromBody] RatingMovieDto value)
        {
            return commandBus.execute(new AddRateMovie { RatingMovieDto = value });
        }

        [HttpPost]
        public IResponse Post([FromBody] MovieDto value)
        {
            return commandBus.execute(new CreateMovie { Movie = value });
        }

        // POST: api/Recibos
        [HttpPost("listMovies", Name = "listMovies")]
        public IResponse GetMovies([FromBody] GetMovies ownerParameter)
        {
            var respuesta = commandBus.execute(ownerParameter);
            return respuesta;
        }

        // PUT: api/recibo/
        [HttpPut]
        public void Put([FromBody] MovieDto value)
        {
            commandBus.execute(new UpdateMovie { Movie = value });
        }

        // DELETE: api/recibo/
        [HttpDelete("id")]
        public void Delete(int id)
        {
            commandBus.execute(new DeleteMovie { Id = id });
        }

        [HttpDelete("rate-movie/{id}", Name = "deleteRateMovie")]
        public void DleteRateMovie(int id)
        {
            commandBus.execute(new DeleteRateMovie { IdMovie = id });
        }

        [HttpGet("rate-movie/consultar")]
        public IResponse GetRatingsMovies()
        {
            return commandBus.execute(new GetAllRatingMovies());
        }


    }
}
