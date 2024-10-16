namespace RonSijm.FluidHumidifier.Features.Consumer;

public interface IStackComposer
{
    StackCreateResult Create(object config);
    public EnvironmentConfig Environment { get; set; }
}