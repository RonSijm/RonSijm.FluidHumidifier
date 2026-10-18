// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleRedshiftDataParametersFactory(Action<Humidifier.Events.RuleTypes.RedshiftDataParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.RedshiftDataParameters>
{

    protected override Humidifier.Events.RuleTypes.RedshiftDataParameters Create()
    {
        var redshiftDataParametersResult = CreateRedshiftDataParameters();
        factoryAction?.Invoke(redshiftDataParametersResult);

        return redshiftDataParametersResult;
    }

    private Humidifier.Events.RuleTypes.RedshiftDataParameters CreateRedshiftDataParameters()
    {
        var redshiftDataParametersResult = new Humidifier.Events.RuleTypes.RedshiftDataParameters();

        return redshiftDataParametersResult;
    }

} // End Of Class

public static class InnerRuleRedshiftDataParametersFactoryExtensions
{
}
