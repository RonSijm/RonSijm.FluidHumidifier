// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDatasetPartitionSpecFactory(Action<Humidifier.SCN.DatasetTypes.PartitionSpec> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DatasetTypes.PartitionSpec>
{

    protected override Humidifier.SCN.DatasetTypes.PartitionSpec Create()
    {
        var partitionSpecResult = CreatePartitionSpec();
        factoryAction?.Invoke(partitionSpecResult);

        return partitionSpecResult;
    }

    private Humidifier.SCN.DatasetTypes.PartitionSpec CreatePartitionSpec()
    {
        var partitionSpecResult = new Humidifier.SCN.DatasetTypes.PartitionSpec();

        return partitionSpecResult;
    }

} // End Of Class

public static class InnerDatasetPartitionSpecFactoryExtensions
{
}
