// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventInvokeConfigOnFailureFactory(Action<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventInvokeConfigTypes.OnFailure>
{

    protected override Humidifier.Lambda.EventInvokeConfigTypes.OnFailure Create()
    {
        var onFailureResult = CreateOnFailure();
        factoryAction?.Invoke(onFailureResult);

        return onFailureResult;
    }

    private Humidifier.Lambda.EventInvokeConfigTypes.OnFailure CreateOnFailure()
    {
        var onFailureResult = new Humidifier.Lambda.EventInvokeConfigTypes.OnFailure();

        return onFailureResult;
    }

} // End Of Class

public static class InnerEventInvokeConfigOnFailureFactoryExtensions
{
}
