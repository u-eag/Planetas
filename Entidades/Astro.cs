using System;
using System.Text;
using System.Threading;
using System.Xml.Serialization;

namespace Entidades
{
    public abstract class Astro
    {
        #region Fields

        public event AstroDelegate AstroEvent;
        protected int duracionRotacion;
        protected int duraOrbita;
        private Thread hiloRotacion;
        private Thread hiloOrbita;
        protected string nombre;

        #endregion

        #region Properties

        public int DuraOrbita
        {
            get
            {
                return duraOrbita;
            }
            set
            {
                duraOrbita = value;
            }
        }

        public int DuraRotacion
        {
            get
            {
                return duracionRotacion;
            }
            set
            {
                duracionRotacion = value;
            }
        }

        public Thread HiloOrbita
        {
            get
            {
                return this.hiloOrbita;
            }
            set
            {
                this.hiloOrbita = value;
            }
        }

        public Thread HiloRotacion
        {
            get
            {
                return this.hiloRotacion;
            }
            set
            {
                this.hiloRotacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        #endregion

        #region Constructors

        public Astro()
        {

        }

        public Astro(int duraOrbita, int duraRotacion, string nombre)
        {
            this.duraOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

        #endregion

        #region Methods

        protected string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Nombre: {0}", nombre);
            retorno.AppendFormat("Duracion de la orbita: {0}", duraOrbita);
            retorno.AppendFormat("Duracion de la rotacion: {0}", duracionRotacion);

            return retorno.ToString();
        }

        public void InvocarEvento(string elemento)
        {
            if(this.AstroEvent != null)
            {
                this.AstroEvent.Invoke(elemento);
            }
           
        }

        public bool NececitaInvocacion()
        {
            bool retorno = false;

            if (!(this.AstroEvent is null)
                && this.AstroEvent.GetInvocationList() is null)
            {
                retorno = true;
            }

            return retorno;
        }

        #endregion
    }
}
