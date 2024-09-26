// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerEndpointPrimaryFactory(Action<Humidifier.Events.EndpointTypes.Primary> factoryAction = null) : SubResourceFactory<Humidifier.Events.EndpointTypes.Primary>
{

    protected override Humidifier.Events.EndpointTypes.Primary Create()
    {
        var primaryResult = CreatePrimary();
        factoryAction?.Invoke(primaryResult);

        return primaryResult;
    }

    private Humidifier.Events.EndpointTypes.Primary CreatePrimary()
    {
        var primaryResult = new Humidifier.Events.EndpointTypes.Primary();

        return primaryResult;
    }

} // End Of Class

public static class InnerEndpointPrimaryFactoryExtensions
{
}
