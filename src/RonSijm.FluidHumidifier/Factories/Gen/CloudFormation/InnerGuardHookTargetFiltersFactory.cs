// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerGuardHookTargetFiltersFactory(Action<Humidifier.CloudFormation.GuardHookTypes.TargetFilters> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.GuardHookTypes.TargetFilters>
{

    protected override Humidifier.CloudFormation.GuardHookTypes.TargetFilters Create()
    {
        var targetFiltersResult = CreateTargetFilters();
        factoryAction?.Invoke(targetFiltersResult);

        return targetFiltersResult;
    }

    private Humidifier.CloudFormation.GuardHookTypes.TargetFilters CreateTargetFilters()
    {
        var targetFiltersResult = new Humidifier.CloudFormation.GuardHookTypes.TargetFilters();

        return targetFiltersResult;
    }

} // End Of Class

public static class InnerGuardHookTargetFiltersFactoryExtensions
{
}
