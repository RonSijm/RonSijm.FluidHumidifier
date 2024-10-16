// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Neptune;

public class DBSubnetGroupFactory(string resourceName = null, Action<Humidifier.Neptune.DBSubnetGroup> factoryAction = null) : ResourceFactory<Humidifier.Neptune.DBSubnetGroup>(resourceName)
{

    protected override Humidifier.Neptune.DBSubnetGroup Create()
    {
        var dBSubnetGroupResult = CreateDBSubnetGroup();
        factoryAction?.Invoke(dBSubnetGroupResult);

        return dBSubnetGroupResult;
    }

    private Humidifier.Neptune.DBSubnetGroup CreateDBSubnetGroup()
    {
        var dBSubnetGroupResult = new Humidifier.Neptune.DBSubnetGroup
        {
            GivenName = InputResourceName,
        };

        return dBSubnetGroupResult;
    }

} // End Of Class

public static class DBSubnetGroupFactoryExtensions
{
}
