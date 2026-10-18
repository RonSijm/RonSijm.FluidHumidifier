// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class BuildBatchFactory(string resourceName = null, Action<Humidifier.CodeBuild.BuildBatch> factoryAction = null) : ResourceFactory<Humidifier.CodeBuild.BuildBatch>(resourceName)
{

    protected override Humidifier.CodeBuild.BuildBatch Create()
    {
        var buildBatchResult = CreateBuildBatch();
        factoryAction?.Invoke(buildBatchResult);

        return buildBatchResult;
    }

    private Humidifier.CodeBuild.BuildBatch CreateBuildBatch()
    {
        var buildBatchResult = new Humidifier.CodeBuild.BuildBatch
        {
            GivenName = InputResourceName,
        };

        return buildBatchResult;
    }

} // End Of Class

public static class BuildBatchFactoryExtensions
{
}
