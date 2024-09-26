// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Evidently;

public class InnerFeatureEntityOverrideFactory(Action<Humidifier.Evidently.FeatureTypes.EntityOverride> factoryAction = null) : SubResourceFactory<Humidifier.Evidently.FeatureTypes.EntityOverride>
{

    protected override Humidifier.Evidently.FeatureTypes.EntityOverride Create()
    {
        var entityOverrideResult = CreateEntityOverride();
        factoryAction?.Invoke(entityOverrideResult);

        return entityOverrideResult;
    }

    private Humidifier.Evidently.FeatureTypes.EntityOverride CreateEntityOverride()
    {
        var entityOverrideResult = new Humidifier.Evidently.FeatureTypes.EntityOverride();

        return entityOverrideResult;
    }

} // End Of Class

public static class InnerFeatureEntityOverrideFactoryExtensions
{
}
