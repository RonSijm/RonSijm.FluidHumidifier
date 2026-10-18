// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResilienceHub;

public class InnerAppPhysicalResourceIdFactory(Action<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId> factoryAction = null) : SubResourceFactory<Humidifier.ResilienceHub.AppTypes.PhysicalResourceId>
{

    protected override Humidifier.ResilienceHub.AppTypes.PhysicalResourceId Create()
    {
        var physicalResourceIdResult = CreatePhysicalResourceId();
        factoryAction?.Invoke(physicalResourceIdResult);

        return physicalResourceIdResult;
    }

    private Humidifier.ResilienceHub.AppTypes.PhysicalResourceId CreatePhysicalResourceId()
    {
        var physicalResourceIdResult = new Humidifier.ResilienceHub.AppTypes.PhysicalResourceId();

        return physicalResourceIdResult;
    }

} // End Of Class

public static class InnerAppPhysicalResourceIdFactoryExtensions
{
}
