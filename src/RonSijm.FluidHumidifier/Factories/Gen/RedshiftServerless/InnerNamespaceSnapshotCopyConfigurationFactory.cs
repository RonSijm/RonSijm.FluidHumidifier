// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RedshiftServerless;

public class InnerNamespaceSnapshotCopyConfigurationFactory(Action<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration>
{

    protected override Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration Create()
    {
        var snapshotCopyConfigurationResult = CreateSnapshotCopyConfiguration();
        factoryAction?.Invoke(snapshotCopyConfigurationResult);

        return snapshotCopyConfigurationResult;
    }

    private Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration CreateSnapshotCopyConfiguration()
    {
        var snapshotCopyConfigurationResult = new Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration();

        return snapshotCopyConfigurationResult;
    }

} // End Of Class

public static class InnerNamespaceSnapshotCopyConfigurationFactoryExtensions
{
}
