// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerLifecyclePolicyIncludeResourcesFactory(Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources>
{

    protected override Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources Create()
    {
        var includeResourcesResult = CreateIncludeResources();
        factoryAction?.Invoke(includeResourcesResult);

        return includeResourcesResult;
    }

    private Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources CreateIncludeResources()
    {
        var includeResourcesResult = new Humidifier.ImageBuilder.LifecyclePolicyTypes.IncludeResources();

        return includeResourcesResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyIncludeResourcesFactoryExtensions
{
}
