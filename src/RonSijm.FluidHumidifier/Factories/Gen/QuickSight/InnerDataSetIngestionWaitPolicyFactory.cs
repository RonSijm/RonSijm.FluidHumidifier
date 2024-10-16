// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetIngestionWaitPolicyFactory(Action<Humidifier.QuickSight.DataSetTypes.IngestionWaitPolicy> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.IngestionWaitPolicy>
{

    protected override Humidifier.QuickSight.DataSetTypes.IngestionWaitPolicy Create()
    {
        var ingestionWaitPolicyResult = CreateIngestionWaitPolicy();
        factoryAction?.Invoke(ingestionWaitPolicyResult);

        return ingestionWaitPolicyResult;
    }

    private Humidifier.QuickSight.DataSetTypes.IngestionWaitPolicy CreateIngestionWaitPolicy()
    {
        var ingestionWaitPolicyResult = new Humidifier.QuickSight.DataSetTypes.IngestionWaitPolicy();

        return ingestionWaitPolicyResult;
    }

} // End Of Class

public static class InnerDataSetIngestionWaitPolicyFactoryExtensions
{
}
