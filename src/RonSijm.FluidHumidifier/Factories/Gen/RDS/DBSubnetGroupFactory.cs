// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBSubnetGroupFactory(string resourceName = null, Action<Humidifier.RDS.DBSubnetGroup> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBSubnetGroup>(resourceName)
{

    protected override Humidifier.RDS.DBSubnetGroup Create()
    {
        var dBSubnetGroupResult = CreateDBSubnetGroup();
        factoryAction?.Invoke(dBSubnetGroupResult);

        return dBSubnetGroupResult;
    }

    private Humidifier.RDS.DBSubnetGroup CreateDBSubnetGroup()
    {
        var dBSubnetGroupResult = new Humidifier.RDS.DBSubnetGroup
        {
            GivenName = InputResourceName,
        };

        return dBSubnetGroupResult;
    }

} // End Of Class

public static class DBSubnetGroupFactoryExtensions
{
}
