// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DAX;

public class SubnetGroupFactory(string resourceName = null, Action<Humidifier.DAX.SubnetGroup> factoryAction = null) : ResourceFactory<Humidifier.DAX.SubnetGroup>(resourceName)
{

    protected override Humidifier.DAX.SubnetGroup Create()
    {
        var subnetGroupResult = CreateSubnetGroup();
        factoryAction?.Invoke(subnetGroupResult);

        return subnetGroupResult;
    }

    private Humidifier.DAX.SubnetGroup CreateSubnetGroup()
    {
        var subnetGroupResult = new Humidifier.DAX.SubnetGroup
        {
            GivenName = InputResourceName,
        };

        return subnetGroupResult;
    }

} // End Of Class

public static class SubnetGroupFactoryExtensions
{
}
