// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class InnerDashboardFrequencyFactory(Action<Humidifier.CloudTrail.DashboardTypes.Frequency> factoryAction = null) : SubResourceFactory<Humidifier.CloudTrail.DashboardTypes.Frequency>
{

    protected override Humidifier.CloudTrail.DashboardTypes.Frequency Create()
    {
        var frequencyResult = CreateFrequency();
        factoryAction?.Invoke(frequencyResult);

        return frequencyResult;
    }

    private Humidifier.CloudTrail.DashboardTypes.Frequency CreateFrequency()
    {
        var frequencyResult = new Humidifier.CloudTrail.DashboardTypes.Frequency();

        return frequencyResult;
    }

} // End Of Class

public static class InnerDashboardFrequencyFactoryExtensions
{
}
