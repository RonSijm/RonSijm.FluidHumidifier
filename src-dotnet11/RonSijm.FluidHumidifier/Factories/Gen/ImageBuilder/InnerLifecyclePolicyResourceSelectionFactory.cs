// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerLifecyclePolicyResourceSelectionFactory(Action<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection>
{

    protected override Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection Create()
    {
        var resourceSelectionResult = CreateResourceSelection();
        factoryAction?.Invoke(resourceSelectionResult);

        return resourceSelectionResult;
    }

    private Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection CreateResourceSelection()
    {
        var resourceSelectionResult = new Humidifier.ImageBuilder.LifecyclePolicyTypes.ResourceSelection();

        return resourceSelectionResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyResourceSelectionFactoryExtensions
{
}
