// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleSqsParametersFactory(Action<Humidifier.Events.RuleTypes.SqsParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.SqsParameters>
{

    protected override Humidifier.Events.RuleTypes.SqsParameters Create()
    {
        var sqsParametersResult = CreateSqsParameters();
        factoryAction?.Invoke(sqsParametersResult);

        return sqsParametersResult;
    }

    private Humidifier.Events.RuleTypes.SqsParameters CreateSqsParameters()
    {
        var sqsParametersResult = new Humidifier.Events.RuleTypes.SqsParameters();

        return sqsParametersResult;
    }

} // End Of Class

public static class InnerRuleSqsParametersFactoryExtensions
{
}
