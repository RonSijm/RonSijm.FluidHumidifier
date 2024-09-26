// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DocDB;

public class DBSubnetGroupFactory(string resourceName = null, Action<Humidifier.DocDB.DBSubnetGroup> factoryAction = null) : ResourceFactory<Humidifier.DocDB.DBSubnetGroup>(resourceName)
{

    protected override Humidifier.DocDB.DBSubnetGroup Create()
    {
        var dBSubnetGroupResult = CreateDBSubnetGroup();
        factoryAction?.Invoke(dBSubnetGroupResult);

        return dBSubnetGroupResult;
    }

    private Humidifier.DocDB.DBSubnetGroup CreateDBSubnetGroup()
    {
        var dBSubnetGroupResult = new Humidifier.DocDB.DBSubnetGroup
        {
            GivenName = InputResourceName,
        };

        return dBSubnetGroupResult;
    }

} // End Of Class

public static class DBSubnetGroupFactoryExtensions
{
}
