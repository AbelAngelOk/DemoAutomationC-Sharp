using Boa.Constrictor.Screenplay;
using System.Threading;

namespace DemoAutomation.Interactions
{
    /// <summary>
    /// Proposito: Detiene la ejecucion por un tiempo dado en segundos.
    /// </summary>
    internal class Espera : ITask
    {
        #region metodos instanciadores
        public static Espera UnTiempo(string tiempo)
        {
            return new Espera(tiempo);
        }
        #endregion

        #region metodo constructor
        public Espera(string tiempo)
        {
            this.tiempo = tiempo;
        }
        #endregion

        #region variables

        readonly string tiempo;

        #endregion

        public void PerformAs(IActor cualquierActor)
        {
            Thread.Sleep( int.Parse(tiempo) );
        }

    }
}
