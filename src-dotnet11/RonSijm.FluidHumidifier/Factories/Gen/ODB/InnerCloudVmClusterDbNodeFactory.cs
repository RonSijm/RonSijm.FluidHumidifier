// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ODB;

public class InnerCloudVmClusterDbNodeFactory(Action<Humidifier.ODB.CloudVmClusterTypes.DbNode> factoryAction = null) : SubResourceFactory<Humidifier.ODB.CloudVmClusterTypes.DbNode>
{

    protected override Humidifier.ODB.CloudVmClusterTypes.DbNode Create()
    {
        var dbNodeResult = CreateDbNode();
        factoryAction?.Invoke(dbNodeResult);

        return dbNodeResult;
    }

    private Humidifier.ODB.CloudVmClusterTypes.DbNode CreateDbNode()
    {
        var dbNodeResult = new Humidifier.ODB.CloudVmClusterTypes.DbNode();

        return dbNodeResult;
    }

} // End Of Class

public static class InnerCloudVmClusterDbNodeFactoryExtensions
{
}
