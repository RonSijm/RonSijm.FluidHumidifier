// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MemoryDB;

public class SubnetGroupFactory(string resourceName = null, Action<Humidifier.MemoryDB.SubnetGroup> factoryAction = null) : ResourceFactory<Humidifier.MemoryDB.SubnetGroup>(resourceName)
{

    protected override Humidifier.MemoryDB.SubnetGroup Create()
    {
        var subnetGroupResult = CreateSubnetGroup();
        factoryAction?.Invoke(subnetGroupResult);

        return subnetGroupResult;
    }

    private Humidifier.MemoryDB.SubnetGroup CreateSubnetGroup()
    {
        var subnetGroupResult = new Humidifier.MemoryDB.SubnetGroup
        {
            GivenName = InputResourceName,
        };

        return subnetGroupResult;
    }

} // End Of Class

public static class SubnetGroupFactoryExtensions
{
}
