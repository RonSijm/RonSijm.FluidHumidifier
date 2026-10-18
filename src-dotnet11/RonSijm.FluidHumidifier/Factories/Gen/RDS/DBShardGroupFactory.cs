// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RDS;

public class DBShardGroupFactory(string resourceName = null, Action<Humidifier.RDS.DBShardGroup> factoryAction = null) : ResourceFactory<Humidifier.RDS.DBShardGroup>(resourceName)
{

    protected override Humidifier.RDS.DBShardGroup Create()
    {
        var dBShardGroupResult = CreateDBShardGroup();
        factoryAction?.Invoke(dBShardGroupResult);

        return dBShardGroupResult;
    }

    private Humidifier.RDS.DBShardGroup CreateDBShardGroup()
    {
        var dBShardGroupResult = new Humidifier.RDS.DBShardGroup
        {
            GivenName = InputResourceName,
        };

        return dBShardGroupResult;
    }

} // End Of Class

public static class DBShardGroupFactoryExtensions
{
}
