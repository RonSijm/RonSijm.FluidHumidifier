// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleHttpParametersFactory(Action<Humidifier.Events.RuleTypes.HttpParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.HttpParameters>
{

    protected override Humidifier.Events.RuleTypes.HttpParameters Create()
    {
        var httpParametersResult = CreateHttpParameters();
        factoryAction?.Invoke(httpParametersResult);

        return httpParametersResult;
    }

    private Humidifier.Events.RuleTypes.HttpParameters CreateHttpParameters()
    {
        var httpParametersResult = new Humidifier.Events.RuleTypes.HttpParameters();

        return httpParametersResult;
    }

} // End Of Class

public static class InnerRuleHttpParametersFactoryExtensions
{
}
