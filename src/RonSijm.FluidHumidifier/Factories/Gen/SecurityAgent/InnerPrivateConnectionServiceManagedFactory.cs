// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityAgent;

public class InnerPrivateConnectionServiceManagedFactory(Action<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged> factoryAction = null) : SubResourceFactory<Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged>
{

    protected override Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged Create()
    {
        var serviceManagedResult = CreateServiceManaged();
        factoryAction?.Invoke(serviceManagedResult);

        return serviceManagedResult;
    }

    private Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged CreateServiceManaged()
    {
        var serviceManagedResult = new Humidifier.SecurityAgent.PrivateConnectionTypes.ServiceManaged();

        return serviceManagedResult;
    }

} // End Of Class

public static class InnerPrivateConnectionServiceManagedFactoryExtensions
{
}
