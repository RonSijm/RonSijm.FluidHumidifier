// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class SubnetGroupFactory(string resourceName = null, Action<Humidifier.ElastiCache.SubnetGroup> factoryAction = null) : ResourceFactory<Humidifier.ElastiCache.SubnetGroup>(resourceName)
{

    protected override Humidifier.ElastiCache.SubnetGroup Create()
    {
        var subnetGroupResult = CreateSubnetGroup();
        factoryAction?.Invoke(subnetGroupResult);

        return subnetGroupResult;
    }

    private Humidifier.ElastiCache.SubnetGroup CreateSubnetGroup()
    {
        var subnetGroupResult = new Humidifier.ElastiCache.SubnetGroup
        {
            GivenName = InputResourceName,
        };

        return subnetGroupResult;
    }

} // End Of Class

public static class SubnetGroupFactoryExtensions
{
}
