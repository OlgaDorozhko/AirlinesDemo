namespace AirlinesDemo.Repositories.Entities.Interfaces
{
    using Entities;

    public interface IObjectWithState
    {
        State State { get; set; }
    }
}
