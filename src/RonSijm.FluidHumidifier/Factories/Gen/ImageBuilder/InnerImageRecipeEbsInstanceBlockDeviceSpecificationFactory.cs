// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactory(Action<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification>
{

    protected override Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification Create()
    {
        var ebsInstanceBlockDeviceSpecificationResult = CreateEbsInstanceBlockDeviceSpecification();
        factoryAction?.Invoke(ebsInstanceBlockDeviceSpecificationResult);

        return ebsInstanceBlockDeviceSpecificationResult;
    }

    private Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification CreateEbsInstanceBlockDeviceSpecification()
    {
        var ebsInstanceBlockDeviceSpecificationResult = new Humidifier.ImageBuilder.ImageRecipeTypes.EbsInstanceBlockDeviceSpecification();

        return ebsInstanceBlockDeviceSpecificationResult;
    }

} // End Of Class

public static class InnerImageRecipeEbsInstanceBlockDeviceSpecificationFactoryExtensions
{
}
