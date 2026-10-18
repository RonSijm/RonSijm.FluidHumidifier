// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigScaleInPolicyFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy Create()
    {
        var scaleInPolicyResult = CreateScaleInPolicy();
        factoryAction?.Invoke(scaleInPolicyResult);

        return scaleInPolicyResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy CreateScaleInPolicy()
    {
        var scaleInPolicyResult = new Humidifier.SageMaker.EndpointConfigTypes.ScaleInPolicy();

        return scaleInPolicyResult;
    }

} // End Of Class

public static class InnerEndpointConfigScaleInPolicyFactoryExtensions
{
}
