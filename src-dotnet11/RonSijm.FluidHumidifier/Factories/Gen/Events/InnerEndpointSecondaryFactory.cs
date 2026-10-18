// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerEndpointSecondaryFactory(Action<Humidifier.Events.EndpointTypes.Secondary> factoryAction = null) : SubResourceFactory<Humidifier.Events.EndpointTypes.Secondary>
{

    protected override Humidifier.Events.EndpointTypes.Secondary Create()
    {
        var secondaryResult = CreateSecondary();
        factoryAction?.Invoke(secondaryResult);

        return secondaryResult;
    }

    private Humidifier.Events.EndpointTypes.Secondary CreateSecondary()
    {
        var secondaryResult = new Humidifier.Events.EndpointTypes.Secondary();

        return secondaryResult;
    }

} // End Of Class

public static class InnerEndpointSecondaryFactoryExtensions
{
}
