// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerCapacityProviderPropagateTagsConfigFactory(Action<Humidifier.Lambda.CapacityProviderTypes.PropagateTagsConfig> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.CapacityProviderTypes.PropagateTagsConfig>
{

    protected override Humidifier.Lambda.CapacityProviderTypes.PropagateTagsConfig Create()
    {
        var propagateTagsConfigResult = CreatePropagateTagsConfig();
        factoryAction?.Invoke(propagateTagsConfigResult);

        return propagateTagsConfigResult;
    }

    private Humidifier.Lambda.CapacityProviderTypes.PropagateTagsConfig CreatePropagateTagsConfig()
    {
        var propagateTagsConfigResult = new Humidifier.Lambda.CapacityProviderTypes.PropagateTagsConfig();

        return propagateTagsConfigResult;
    }

} // End Of Class

public static class InnerCapacityProviderPropagateTagsConfigFactoryExtensions
{
}
