// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessTrustProviderSseSpecificationFactory(Action<Humidifier.EC2.VerifiedAccessTrustProviderTypes.SseSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessTrustProviderTypes.SseSpecification>
{

    protected override Humidifier.EC2.VerifiedAccessTrustProviderTypes.SseSpecification Create()
    {
        var sseSpecificationResult = CreateSseSpecification();
        factoryAction?.Invoke(sseSpecificationResult);

        return sseSpecificationResult;
    }

    private Humidifier.EC2.VerifiedAccessTrustProviderTypes.SseSpecification CreateSseSpecification()
    {
        var sseSpecificationResult = new Humidifier.EC2.VerifiedAccessTrustProviderTypes.SseSpecification();

        return sseSpecificationResult;
    }

} // End Of Class

public static class InnerVerifiedAccessTrustProviderSseSpecificationFactoryExtensions
{
}
