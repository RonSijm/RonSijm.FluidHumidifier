// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerPrivateConnectionServiceManagedModeFactory(Action<Humidifier.DevOpsAgent.PrivateConnectionTypes.ServiceManagedMode> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.PrivateConnectionTypes.ServiceManagedMode>
{

    protected override Humidifier.DevOpsAgent.PrivateConnectionTypes.ServiceManagedMode Create()
    {
        var serviceManagedModeResult = CreateServiceManagedMode();
        factoryAction?.Invoke(serviceManagedModeResult);

        return serviceManagedModeResult;
    }

    private Humidifier.DevOpsAgent.PrivateConnectionTypes.ServiceManagedMode CreateServiceManagedMode()
    {
        var serviceManagedModeResult = new Humidifier.DevOpsAgent.PrivateConnectionTypes.ServiceManagedMode();

        return serviceManagedModeResult;
    }

} // End Of Class

public static class InnerPrivateConnectionServiceManagedModeFactoryExtensions
{
}
