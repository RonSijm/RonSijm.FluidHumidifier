// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class ServiceRevisionFactory(string resourceName = null, Action<Humidifier.ECS.ServiceRevision> factoryAction = null) : ResourceFactory<Humidifier.ECS.ServiceRevision>(resourceName)
{

    protected override Humidifier.ECS.ServiceRevision Create()
    {
        var serviceRevisionResult = CreateServiceRevision();
        factoryAction?.Invoke(serviceRevisionResult);

        return serviceRevisionResult;
    }

    private Humidifier.ECS.ServiceRevision CreateServiceRevision()
    {
        var serviceRevisionResult = new Humidifier.ECS.ServiceRevision
        {
            GivenName = InputResourceName,
        };

        return serviceRevisionResult;
    }

} // End Of Class

public static class ServiceRevisionFactoryExtensions
{
}
