using Boa.Constrictor.Screenplay;

namespace DemoAutomation.Interactions
{
    /// <summary>
    /// <b>Proposito:</b> Realiza una tarea solamente si se cumple la condicion. <br/>
    /// <b>Advertencia:</b> No se probó el funcionamiento de est funcion. 
    /// </summary>
    internal class IfSo2 : ITask
    {
        #region properties
        IQuestion<bool> Cond { get; set; }
        ITask So { get; }
        #endregion
        public IfSo2(IQuestion<bool> condition, ITask then)
        {
            Cond = condition;
            So = then;
        }
        public static IfSo2 Then(IQuestion<bool> condition, ITask then)
        {
            return new IfSo2(condition, then);
        }
        public void PerformAs(IActor actor)
        {
            if (Cond.RequestAs(actor) == true)
            {
                actor.AttemptsTo(RunTasks.InOrder(So));
            }
        }
    }
}