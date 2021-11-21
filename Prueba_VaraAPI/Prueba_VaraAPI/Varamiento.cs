using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_VaraAPI
{
    public class Varamiento
    {
        public Varamiento()
        {

        }
        public Varamiento(bool finalizado, string nombreInformante, string telefonoInformante, string direccioninformante, string ordenAnimal, string condicionAnimal, int numeroAnimales, string observaciones, bool facilAcceso, bool acantilado, string sustrato, string primeraVezVisto, string fechaAvistamiento, string pais, string estado, string ciudad, string localidad, string informacionAdicionalUbicacion, string latitud, string longitud)
        {
            this.finalizado = finalizado;
            this.nombreInformante = nombreInformante;
            this.telefonoInformante = telefonoInformante;
            this.direccioninformante = direccioninformante;
            this.ordenAnimal = ordenAnimal;
            this.condicionAnimal = condicionAnimal;
            this.numeroAnimales = numeroAnimales;
            this.observaciones = observaciones;
            this.facilAcceso = facilAcceso;
            this.acantilado = acantilado;
            this.sustrato = sustrato;
            this.primeraVezVisto = primeraVezVisto;
            this.fechaAvistamiento = fechaAvistamiento;
            this.pais = pais;
            this.estado = estado;
            this.ciudad = ciudad;
            this.localidad = localidad;
            this.informacionAdicionalUbicacion = informacionAdicionalUbicacion;
            this.latitud = latitud;
            this.longitud = longitud;
        }

        public Varamiento(string? uuid, bool finalizado, string nombreInformante, string telefonoInformante, string direccioninformante, string ordenAnimal, string condicionAnimal, int numeroAnimales, string observaciones, bool facilAcceso, bool acantilado, string sustrato, string primeraVezVisto, string fechaAvistamiento, string pais, string estado, string ciudad, string localidad, string informacionAdicionalUbicacion, string latitud, string longitud)
        {
            this.uuid = uuid;
            this.finalizado = finalizado;
            this.nombreInformante = nombreInformante;
            this.telefonoInformante = telefonoInformante;
            this.direccioninformante = direccioninformante;
            this.ordenAnimal = ordenAnimal;
            this.condicionAnimal = condicionAnimal;
            this.numeroAnimales = numeroAnimales;
            this.observaciones = observaciones;
            this.facilAcceso = facilAcceso;
            this.acantilado = acantilado;
            this.sustrato = sustrato;
            this.primeraVezVisto = primeraVezVisto;
            this.fechaAvistamiento = fechaAvistamiento;
            this.pais = pais;
            this.estado = estado;
            this.ciudad = ciudad;
            this.localidad = localidad;
            this.informacionAdicionalUbicacion = informacionAdicionalUbicacion;
            this.latitud = latitud;
            this.longitud = longitud;
        }

        public string? uuid { get; set; }
        public bool finalizado { get; set; }
        public string nombreInformante { get; set; }
        public string telefonoInformante { get; set; }
        public string direccioninformante { get; set; }
        public string ordenAnimal { get; set; }
        public string condicionAnimal { get; set; }
        public int numeroAnimales { get; set; }
        public string observaciones { get; set; }
        public bool facilAcceso { get; set; }
        public bool acantilado { get; set; }
        public string sustrato { get; set; }
        public string primeraVezVisto { get; set; }
        public string fechaAvistamiento { get; set; }
        public string pais { get; set; }
        public string estado { get; set; }
        public string ciudad { get; set; }
        public string localidad { get; set; }
        public string informacionAdicionalUbicacion { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }

    }
}
