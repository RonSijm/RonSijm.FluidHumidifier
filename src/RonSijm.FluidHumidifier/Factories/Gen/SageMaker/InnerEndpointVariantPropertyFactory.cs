// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointVariantPropertyFactory(Action<Humidifier.SageMaker.EndpointTypes.VariantProperty> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointTypes.VariantProperty>
{

    protected override Humidifier.SageMaker.EndpointTypes.VariantProperty Create()
    {
        var variantPropertyResult = CreateVariantProperty();
        factoryAction?.Invoke(variantPropertyResult);

        return variantPropertyResult;
    }

    private Humidifier.SageMaker.EndpointTypes.VariantProperty CreateVariantProperty()
    {
        var variantPropertyResult = new Humidifier.SageMaker.EndpointTypes.VariantProperty();

        return variantPropertyResult;
    }

} // End Of Class

public static class InnerEndpointVariantPropertyFactoryExtensions
{
}
