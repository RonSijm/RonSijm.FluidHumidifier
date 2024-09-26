// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerFeatureVariationObjectFactory(Action<Humidifier.Evidently.FeatureTypes.VariationObject> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.FeatureTypes.VariationObject>
{

    protected override Humidifier.Evidently.FeatureTypes.VariationObject Create()
    {
        var variationObjectResult = CreateVariationObject();
        factoryAction?.Invoke(variationObjectResult);

        return variationObjectResult;
    }

    private Humidifier.Evidently.FeatureTypes.VariationObject CreateVariationObject()
    {
        var variationObjectResult = new Humidifier.Evidently.FeatureTypes.VariationObject();

        return variationObjectResult;
    }

} // End Of Class

public static class InnerFeatureVariationObjectFactoryExtensions
{
}
