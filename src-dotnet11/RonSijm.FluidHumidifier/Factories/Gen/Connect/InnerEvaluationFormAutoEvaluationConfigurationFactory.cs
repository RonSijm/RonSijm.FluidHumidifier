// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerEvaluationFormAutoEvaluationConfigurationFactory(Action<Humidifier.Connect.EvaluationFormTypes.AutoEvaluationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Connect.EvaluationFormTypes.AutoEvaluationConfiguration>
{

    protected override Humidifier.Connect.EvaluationFormTypes.AutoEvaluationConfiguration Create()
    {
        var autoEvaluationConfigurationResult = CreateAutoEvaluationConfiguration();
        factoryAction?.Invoke(autoEvaluationConfigurationResult);

        return autoEvaluationConfigurationResult;
    }

    private Humidifier.Connect.EvaluationFormTypes.AutoEvaluationConfiguration CreateAutoEvaluationConfiguration()
    {
        var autoEvaluationConfigurationResult = new Humidifier.Connect.EvaluationFormTypes.AutoEvaluationConfiguration();

        return autoEvaluationConfigurationResult;
    }

} // End Of Class

public static class InnerEvaluationFormAutoEvaluationConfigurationFactoryExtensions
{
}
