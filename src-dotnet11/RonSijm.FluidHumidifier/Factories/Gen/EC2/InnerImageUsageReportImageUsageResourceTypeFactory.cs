// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerImageUsageReportImageUsageResourceTypeFactory(Action<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType>
{

    protected override Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType Create()
    {
        var imageUsageResourceTypeResult = CreateImageUsageResourceType();
        factoryAction?.Invoke(imageUsageResourceTypeResult);

        return imageUsageResourceTypeResult;
    }

    private Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType CreateImageUsageResourceType()
    {
        var imageUsageResourceTypeResult = new Humidifier.EC2.ImageUsageReportTypes.ImageUsageResourceType();

        return imageUsageResourceTypeResult;
    }

} // End Of Class

public static class InnerImageUsageReportImageUsageResourceTypeFactoryExtensions
{
}
