// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensStorageLensGroupSelectionCriteriaFactory(Action<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria>
{

    protected override Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria Create()
    {
        var storageLensGroupSelectionCriteriaResult = CreateStorageLensGroupSelectionCriteria();
        factoryAction?.Invoke(storageLensGroupSelectionCriteriaResult);

        return storageLensGroupSelectionCriteriaResult;
    }

    private Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria CreateStorageLensGroupSelectionCriteria()
    {
        var storageLensGroupSelectionCriteriaResult = new Humidifier.S3.StorageLensTypes.StorageLensGroupSelectionCriteria();

        return storageLensGroupSelectionCriteriaResult;
    }

} // End Of Class

public static class InnerStorageLensStorageLensGroupSelectionCriteriaFactoryExtensions
{
}
