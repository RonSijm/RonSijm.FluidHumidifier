// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskSetScaleFactory(Action<Humidifier.ECS.TaskSetTypes.Scale> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskSetTypes.Scale>
{

    protected override Humidifier.ECS.TaskSetTypes.Scale Create()
    {
        var scaleResult = CreateScale();
        factoryAction?.Invoke(scaleResult);

        return scaleResult;
    }

    private Humidifier.ECS.TaskSetTypes.Scale CreateScale()
    {
        var scaleResult = new Humidifier.ECS.TaskSetTypes.Scale();

        return scaleResult;
    }

} // End Of Class

public static class InnerTaskSetScaleFactoryExtensions
{
}
