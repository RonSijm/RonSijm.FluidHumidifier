// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleAppSyncParametersFactory(Action<Humidifier.Events.RuleTypes.AppSyncParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.AppSyncParameters>
{

    protected override Humidifier.Events.RuleTypes.AppSyncParameters Create()
    {
        var appSyncParametersResult = CreateAppSyncParameters();
        factoryAction?.Invoke(appSyncParametersResult);

        return appSyncParametersResult;
    }

    private Humidifier.Events.RuleTypes.AppSyncParameters CreateAppSyncParameters()
    {
        var appSyncParametersResult = new Humidifier.Events.RuleTypes.AppSyncParameters();

        return appSyncParametersResult;
    }

} // End Of Class

public static class InnerRuleAppSyncParametersFactoryExtensions
{
}
