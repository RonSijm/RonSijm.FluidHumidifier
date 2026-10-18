// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class InnerVolumeTagSpecificationFactory(Action<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification> factoryAction = null) : SubResourceFactory<Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification>
{

    protected override Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification Create()
    {
        var tagSpecificationResult = CreateTagSpecification();
        factoryAction?.Invoke(tagSpecificationResult);

        return tagSpecificationResult;
    }

    private Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification CreateTagSpecification()
    {
        var tagSpecificationResult = new Humidifier.WorkspacesInstances.VolumeTypes.TagSpecification();

        return tagSpecificationResult;
    }

} // End Of Class

public static class InnerVolumeTagSpecificationFactoryExtensions
{
}
