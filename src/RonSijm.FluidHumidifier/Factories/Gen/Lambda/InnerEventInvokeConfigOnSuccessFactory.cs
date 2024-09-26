// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerEventInvokeConfigOnSuccessFactory(Action<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess>
{

    protected override Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess Create()
    {
        var onSuccessResult = CreateOnSuccess();
        factoryAction?.Invoke(onSuccessResult);

        return onSuccessResult;
    }

    private Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess CreateOnSuccess()
    {
        var onSuccessResult = new Humidifier.Lambda.EventInvokeConfigTypes.OnSuccess();

        return onSuccessResult;
    }

} // End Of Class

public static class InnerEventInvokeConfigOnSuccessFactoryExtensions
{
}
