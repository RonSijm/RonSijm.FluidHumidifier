// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerJobJobOutputDataConfigFactory(Action<Humidifier.Braket.JobTypes.JobOutputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Braket.JobTypes.JobOutputDataConfig>
{

    protected override Humidifier.Braket.JobTypes.JobOutputDataConfig Create()
    {
        var jobOutputDataConfigResult = CreateJobOutputDataConfig();
        factoryAction?.Invoke(jobOutputDataConfigResult);

        return jobOutputDataConfigResult;
    }

    private Humidifier.Braket.JobTypes.JobOutputDataConfig CreateJobOutputDataConfig()
    {
        var jobOutputDataConfigResult = new Humidifier.Braket.JobTypes.JobOutputDataConfig();

        return jobOutputDataConfigResult;
    }

} // End Of Class

public static class InnerJobJobOutputDataConfigFactoryExtensions
{
}
