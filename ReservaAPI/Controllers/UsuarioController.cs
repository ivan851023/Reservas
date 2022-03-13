using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReservaAPI.Context;
using ReservaAPI.Entities;
using ReservaAPI.Models;
using ReservaAPI.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private IConfiguration _configuration;
        private static readonly ILog _log = Log.GetLogger();

        private dbContext Context { get; }

        public UsuarioController(IConfiguration configuration, IUsuario iusuario, IReserva ireserva, IHotel ihotel)
        {
            _iusuario = iusuario;
            _configuration = configuration;
            _ihotel = ihotel;
            _ireserva = ireserva;
        }

        private readonly IUsuario _iusuario;
        private readonly IReserva _ireserva;
        private readonly IHotel _ihotel;



        [HttpGet]
        public string Index()
        {
            return "Inicio API Reservas";
        }


        [HttpGet("DetalleReserva")]
        public IActionResult DetalleReserva(ReservaModel model)
        {

            try
            {



                var lstReservas = (from x in _ireserva.GetReservas()
                                   join y in _iusuario.GetUsuarios() on x.Id_Usuario equals y.Id
                                   join z in _ihotel.GetHoteles() on x.Id_Hotel equals z.Id
                                   where z.Activo == true
                                   && x.Fecha_Entrada.Date >= DateTime.Parse(model.Fecha_Entrada)
                                   && x.Fecha_Salida.Date <= DateTime.Parse(model.Fecha_Salida)
                                   select new
                                   {
                                       IdReserva = x.Id,
                                       IdUsuario = x.Id_Usuario,
                                       IdHotel = x.Id_Hotel,
                                       FechaReserva = x.Fecha_Reserva,
                                       NombreHotel = z.Nombre,
                                       CorreoUsuario = y.Email

                                   }).ToList();
                _log.Info("Resultado Exitoso");
                return Ok(lstReservas);
            }
            catch (Exception ex)
            {
                _log.Error(ex.Message);
                return StatusCode(500, ex.Message);
            }
            
            
        }

        [HttpPost("CancelarReserva")]
        public IActionResult CancelarReserva(ReservaModel model)
        {

            try
            {

                var reserva = _ireserva.GetReservas().Where(x => x.Id == int.Parse(model.IdReserva)).FirstOrDefault();
                if (reserva == null)
                {
                    return StatusCode(500, "Reserva no existe");
                }

                
                reserva.Estado = "CANCELADO";

                _ireserva.Update(reserva);

                var result = new ResultEntityMessage<int>();
                result.status = true;
                result.message = "Resultado Exitoso";
                _log.Info("Resultado Exitoso");
                return Ok(result);

            }
            catch (Exception ex)
            {
                _log.Error(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(ReservaModel model)
        {

            try
            {

                Reserva reserva = new Reserva();
                reserva.Id_Usuario = int.Parse(model.Id_Usuario);
                reserva.Id_Hotel = int.Parse(model.Id_Hotel);
                reserva.Fecha_Entrada = DateTime.Parse(model.Fecha_Entrada);
                reserva.Fecha_Salida = DateTime.Parse(model.Fecha_Salida);
                reserva.Fecha_Reserva = DateTime.Parse(model.Fecha_Reserva);
                reserva.Estado = "RESERVADO";

                _ireserva.Insert(reserva);

                var result = new ResultEntityMessage<int>();
                result.status = true;
                result.message = "Resultado Exitoso";
                _log.Info("Resultado Exitoso");
                return Ok(result);

            }
            catch (Exception ex)
            {
                _log.Error(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }
    }
}
