// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchService;

public class InnerDomainServerlessVectorAccelerationFactory(Action<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration>
{

    protected override Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration Create()
    {
        var serverlessVectorAccelerationResult = CreateServerlessVectorAcceleration();
        factoryAction?.Invoke(serverlessVectorAccelerationResult);

        return serverlessVectorAccelerationResult;
    }

    private Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration CreateServerlessVectorAcceleration()
    {
        var serverlessVectorAccelerationResult = new Humidifier.OpenSearchService.DomainTypes.ServerlessVectorAcceleration();

        return serverlessVectorAccelerationResult;
    }

} // End Of Class

public static class InnerDomainServerlessVectorAccelerationFactoryExtensions
{
}
