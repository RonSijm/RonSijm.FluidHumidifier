// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class InnerTableSnapshotManagementFactory(Action<Humidifier.S3Tables.TableTypes.SnapshotManagement> factoryAction = null) : SubResourceFactory<Humidifier.S3Tables.TableTypes.SnapshotManagement>
{

    protected override Humidifier.S3Tables.TableTypes.SnapshotManagement Create()
    {
        var snapshotManagementResult = CreateSnapshotManagement();
        factoryAction?.Invoke(snapshotManagementResult);

        return snapshotManagementResult;
    }

    private Humidifier.S3Tables.TableTypes.SnapshotManagement CreateSnapshotManagement()
    {
        var snapshotManagementResult = new Humidifier.S3Tables.TableTypes.SnapshotManagement();

        return snapshotManagementResult;
    }

} // End Of Class

public static class InnerTableSnapshotManagementFactoryExtensions
{
}
