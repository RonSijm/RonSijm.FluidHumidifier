// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessGroupSseSpecificationFactory(Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification>
{

    protected override Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification Create()
    {
        var sseSpecificationResult = CreateSseSpecification();
        factoryAction?.Invoke(sseSpecificationResult);

        return sseSpecificationResult;
    }

    private Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification CreateSseSpecification()
    {
        var sseSpecificationResult = new Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification();

        return sseSpecificationResult;
    }

} // End Of Class

public static class InnerVerifiedAccessGroupSseSpecificationFactoryExtensions
{
}
