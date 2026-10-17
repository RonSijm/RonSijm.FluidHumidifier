// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerJobRateIncreaseCriteriaFactory(Action<Humidifier.IoT.JobTypes.RateIncreaseCriteria> factoryAction = null) : SubResourceFactory<Humidifier.IoT.JobTypes.RateIncreaseCriteria>
{

    protected override Humidifier.IoT.JobTypes.RateIncreaseCriteria Create()
    {
        var rateIncreaseCriteriaResult = CreateRateIncreaseCriteria();
        factoryAction?.Invoke(rateIncreaseCriteriaResult);

        return rateIncreaseCriteriaResult;
    }

    private Humidifier.IoT.JobTypes.RateIncreaseCriteria CreateRateIncreaseCriteria()
    {
        var rateIncreaseCriteriaResult = new Humidifier.IoT.JobTypes.RateIncreaseCriteria();

        return rateIncreaseCriteriaResult;
    }

} // End Of Class

public static class InnerJobRateIncreaseCriteriaFactoryExtensions
{
}
