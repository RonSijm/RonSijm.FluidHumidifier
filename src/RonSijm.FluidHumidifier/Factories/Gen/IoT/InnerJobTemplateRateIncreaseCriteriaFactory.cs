// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobTemplateRateIncreaseCriteriaFactory(Action<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria>
{

    protected override Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria Create()
    {
        var rateIncreaseCriteriaResult = CreateRateIncreaseCriteria();
        factoryAction?.Invoke(rateIncreaseCriteriaResult);

        return rateIncreaseCriteriaResult;
    }

    private Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria CreateRateIncreaseCriteria()
    {
        var rateIncreaseCriteriaResult = new Humidifier.IoT.JobTemplateTypes.RateIncreaseCriteria();

        return rateIncreaseCriteriaResult;
    }

} // End Of Class

public static class InnerJobTemplateRateIncreaseCriteriaFactoryExtensions
{
}
