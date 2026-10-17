// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerClusterClusterAccountingDatabaseFactory(Action<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase>
{

    protected override Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase Create()
    {
        var clusterAccountingDatabaseResult = CreateClusterAccountingDatabase();
        factoryAction?.Invoke(clusterAccountingDatabaseResult);

        return clusterAccountingDatabaseResult;
    }

    private Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase CreateClusterAccountingDatabase()
    {
        var clusterAccountingDatabaseResult = new Humidifier.SageMaker.ClusterTypes.ClusterAccountingDatabase();

        return clusterAccountingDatabaseResult;
    }

} // End Of Class

public static class InnerClusterClusterAccountingDatabaseFactoryExtensions
{
}
