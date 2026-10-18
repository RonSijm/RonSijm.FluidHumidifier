// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerLambdaHookTargetFiltersFactory(Action<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.LambdaHookTypes.TargetFilters>
{

    protected override Humidifier.CloudFormation.LambdaHookTypes.TargetFilters Create()
    {
        var targetFiltersResult = CreateTargetFilters();
        factoryAction?.Invoke(targetFiltersResult);

        return targetFiltersResult;
    }

    private Humidifier.CloudFormation.LambdaHookTypes.TargetFilters CreateTargetFilters()
    {
        var targetFiltersResult = new Humidifier.CloudFormation.LambdaHookTypes.TargetFilters();

        return targetFiltersResult;
    }

} // End Of Class

public static class InnerLambdaHookTargetFiltersFactoryExtensions
{
}
