// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerLifecyclePolicyFilterFactory(Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.Filter> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.LifecyclePolicyTypes.Filter>
{

    protected override Humidifier.ImageBuilder.LifecyclePolicyTypes.Filter Create()
    {
        var filterResult = CreateFilter();
        factoryAction?.Invoke(filterResult);

        return filterResult;
    }

    private Humidifier.ImageBuilder.LifecyclePolicyTypes.Filter CreateFilter()
    {
        var filterResult = new Humidifier.ImageBuilder.LifecyclePolicyTypes.Filter();

        return filterResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyFilterFactoryExtensions
{
}
