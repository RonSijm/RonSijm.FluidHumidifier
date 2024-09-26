// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventSourceMappingOnFailureFactory(Action<Humidifier.Lambda.EventSourceMappingTypes.OnFailure> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventSourceMappingTypes.OnFailure>
{

    protected override Humidifier.Lambda.EventSourceMappingTypes.OnFailure Create()
    {
        var onFailureResult = CreateOnFailure();
        factoryAction?.Invoke(onFailureResult);

        return onFailureResult;
    }

    private Humidifier.Lambda.EventSourceMappingTypes.OnFailure CreateOnFailure()
    {
        var onFailureResult = new Humidifier.Lambda.EventSourceMappingTypes.OnFailure();

        return onFailureResult;
    }

} // End Of Class

public static class InnerEventSourceMappingOnFailureFactoryExtensions
{
}
