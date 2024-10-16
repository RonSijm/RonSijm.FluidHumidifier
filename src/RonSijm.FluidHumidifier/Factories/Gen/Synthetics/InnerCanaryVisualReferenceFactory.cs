// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Synthetics;

public class InnerCanaryVisualReferenceFactory(Action<Humidifier.Synthetics.CanaryTypes.VisualReference> factoryAction = null) : SubResourceFactory<Humidifier.Synthetics.CanaryTypes.VisualReference>
{

    protected override Humidifier.Synthetics.CanaryTypes.VisualReference Create()
    {
        var visualReferenceResult = CreateVisualReference();
        factoryAction?.Invoke(visualReferenceResult);

        return visualReferenceResult;
    }

    private Humidifier.Synthetics.CanaryTypes.VisualReference CreateVisualReference()
    {
        var visualReferenceResult = new Humidifier.Synthetics.CanaryTypes.VisualReference();

        return visualReferenceResult;
    }

} // End Of Class

public static class InnerCanaryVisualReferenceFactoryExtensions
{
}
