// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleKinesisParametersFactory(Action<Humidifier.Events.RuleTypes.KinesisParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.KinesisParameters>
{

    protected override Humidifier.Events.RuleTypes.KinesisParameters Create()
    {
        var kinesisParametersResult = CreateKinesisParameters();
        factoryAction?.Invoke(kinesisParametersResult);

        return kinesisParametersResult;
    }

    private Humidifier.Events.RuleTypes.KinesisParameters CreateKinesisParameters()
    {
        var kinesisParametersResult = new Humidifier.Events.RuleTypes.KinesisParameters();

        return kinesisParametersResult;
    }

} // End Of Class

public static class InnerRuleKinesisParametersFactoryExtensions
{
}
