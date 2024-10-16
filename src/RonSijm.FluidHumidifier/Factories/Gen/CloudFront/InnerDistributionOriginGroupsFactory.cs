// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionOriginGroupsFactory(Action<Humidifier.CloudFront.DistributionTypes.OriginGroups> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.OriginGroups>
{

    protected override Humidifier.CloudFront.DistributionTypes.OriginGroups Create()
    {
        var originGroupsResult = CreateOriginGroups();
        factoryAction?.Invoke(originGroupsResult);

        return originGroupsResult;
    }

    private Humidifier.CloudFront.DistributionTypes.OriginGroups CreateOriginGroups()
    {
        var originGroupsResult = new Humidifier.CloudFront.DistributionTypes.OriginGroups();

        return originGroupsResult;
    }

} // End Of Class

public static class InnerDistributionOriginGroupsFactoryExtensions
{
}
