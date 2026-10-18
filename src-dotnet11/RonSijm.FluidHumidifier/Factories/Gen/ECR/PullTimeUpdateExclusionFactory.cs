// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class PullTimeUpdateExclusionFactory(string resourceName = null, Action<Humidifier.ECR.PullTimeUpdateExclusion> factoryAction = null) : ResourceFactory<Humidifier.ECR.PullTimeUpdateExclusion>(resourceName)
{

    protected override Humidifier.ECR.PullTimeUpdateExclusion Create()
    {
        var pullTimeUpdateExclusionResult = CreatePullTimeUpdateExclusion();
        factoryAction?.Invoke(pullTimeUpdateExclusionResult);

        return pullTimeUpdateExclusionResult;
    }

    private Humidifier.ECR.PullTimeUpdateExclusion CreatePullTimeUpdateExclusion()
    {
        var pullTimeUpdateExclusionResult = new Humidifier.ECR.PullTimeUpdateExclusion
        {
            GivenName = InputResourceName,
        };

        return pullTimeUpdateExclusionResult;
    }

} // End Of Class

public static class PullTimeUpdateExclusionFactoryExtensions
{
}
