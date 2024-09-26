// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerProjectBatchRestrictionsFactory(Action<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ProjectTypes.BatchRestrictions>
{

    protected override Humidifier.CodeBuild.ProjectTypes.BatchRestrictions Create()
    {
        var batchRestrictionsResult = CreateBatchRestrictions();
        factoryAction?.Invoke(batchRestrictionsResult);

        return batchRestrictionsResult;
    }

    private Humidifier.CodeBuild.ProjectTypes.BatchRestrictions CreateBatchRestrictions()
    {
        var batchRestrictionsResult = new Humidifier.CodeBuild.ProjectTypes.BatchRestrictions();

        return batchRestrictionsResult;
    }

} // End Of Class

public static class InnerProjectBatchRestrictionsFactoryExtensions
{
}
