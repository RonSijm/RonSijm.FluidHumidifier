// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensSelectionCriteriaFactory(Action<Humidifier.S3.StorageLensTypes.SelectionCriteria> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.SelectionCriteria>
{

    protected override Humidifier.S3.StorageLensTypes.SelectionCriteria Create()
    {
        var selectionCriteriaResult = CreateSelectionCriteria();
        factoryAction?.Invoke(selectionCriteriaResult);

        return selectionCriteriaResult;
    }

    private Humidifier.S3.StorageLensTypes.SelectionCriteria CreateSelectionCriteria()
    {
        var selectionCriteriaResult = new Humidifier.S3.StorageLensTypes.SelectionCriteria();

        return selectionCriteriaResult;
    }

} // End Of Class

public static class InnerStorageLensSelectionCriteriaFactoryExtensions
{
}
