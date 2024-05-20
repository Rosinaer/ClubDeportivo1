using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    internal class GestionClubDeportivo
    {
        public List<Socio> Socios { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Cuota> CuotasPendientes { get; set; }
        public List<Actividad> Actividades { get; set; }

        public GestionClubDeportivo()
        {
            // Inicializa las listas
            Socios = new List<Socio>();
            Profesores = new List<Profesor>();
            CuotasPendientes = new List<Cuota>();
            Actividades = new List<Actividad>();
        }
        // Método para registrar a un socio si no está previamente registrado
        public void altaSocio(string nombre, string direccion, string contacto, string tipo, DateTime FechaAfiliacion)
        {
            // Verificar si el socio ya está registrado
            bool socioExistente = Socios.Any(s => s.Nombre == nombre && s.Direccion == direccion && s.Contacto == contacto);

            if (!socioExistente)
            {
                // Crear una nueva instancia de Socio
                Socio nuevoSocio = new Socio(nombre, direccion, contacto, tipo, FechaAfiliacion);

                // Agregar el nuevo socio a la lista
                Socios.Add(nuevoSocio);

            }
        }

        // Método para inscribir a un socio en una actividad deportiva
        public string inscribirActividad(string nombreActividad, int idSocio)
        {
            // Buscar la actividad deportiva por su nombre
            Actividad actividad = Actividades.FirstOrDefault(a => a.Nombre == nombreActividad);

            if (actividad == null)
            {
                return "ACTIVIDAD INEXISTENTE";
            }

            // Buscar al socio por su ID
            Socio socio = Socios.FirstOrDefault(s => s.IdSocio == idSocio);

            if (socio == null)
            {
                return "SOCIO INEXISTENTE";
            }

            // Verificar si el socio ya está inscrito en tres actividades
            if (socio.Actividades.Count >= 3)
            {
                return "TOPE DE ACTIVIDADES ALCANZADO";
            }

            // Verificar si el socio ya está inscrito en la actividad
            if (socio.Actividades.Any(a => a.Nombre == nombreActividad))
            {
                return "INSCRIPCIÓN EXITOSA";
            }

            // Inscribir al socio en la actividad y reservar un cupo
            socio.Actividades.Add(actividad);
            actividad.Cupo--;

            return "INSCRIPCIÓN EXITOSA";
        }
        // metodo para registrr pago de cuota
        public void CobrarCuotaMensual(Socio socio, float monto, DateTime fechaPago)
        {
            Cuota cuotaPagada = new Cuota(fechaPago, monto, "Pagado");
            CuotasPendientes.Add(cuotaPagada);
        }
        // metodo para buscar socios con cuota pendiente
        public List<Socio> ListarSociosCuotaVence(DateTime fecha)
        {
            List<Socio> sociosCuotaVence = new List<Socio>();
            foreach (Socio socio in Socios)
            {
                foreach (Cuota cuota in CuotasPendientes)
                {
                    if (cuota.FechaPago == fecha)
                    {
                        sociosCuotaVence.Add(socio);
                        break;
                    }
                }
            }
            return sociosCuotaVence;
        }

    }
}

