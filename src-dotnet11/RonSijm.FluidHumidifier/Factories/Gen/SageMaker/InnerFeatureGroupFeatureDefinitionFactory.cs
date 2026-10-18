// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerFeatureGroupFeatureDefinitionFactory(Action<Humidifier.SageMaker.FeatureGroupTypes.FeatureDefinition> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.FeatureGroupTypes.FeatureDefinition>
{

    protected override Humidifier.SageMaker.FeatureGroupTypes.FeatureDefinition Create()
    {
        var featureDefinitionResult = CreateFeatureDefinition();
        factoryAction?.Invoke(featureDefinitionResult);

        return featureDefinitionResult;
    }

    private Humidifier.SageMaker.FeatureGroupTypes.FeatureDefinition CreateFeatureDefinition()
    {
        var featureDefinitionResult = new Humidifier.SageMaker.FeatureGroupTypes.FeatureDefinition();

        return featureDefinitionResult;
    }

} // End Of Class

public static class InnerFeatureGroupFeatureDefinitionFactoryExtensions
{
}
