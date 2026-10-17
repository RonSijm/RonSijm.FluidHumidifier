// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class InnerJobJobOutputOptionsFactory(Action<Humidifier.Location.JobTypes.JobOutputOptions> factoryAction = null) : SubResourceFactory<Humidifier.Location.JobTypes.JobOutputOptions>
{

    protected override Humidifier.Location.JobTypes.JobOutputOptions Create()
    {
        var jobOutputOptionsResult = CreateJobOutputOptions();
        factoryAction?.Invoke(jobOutputOptionsResult);

        return jobOutputOptionsResult;
    }

    private Humidifier.Location.JobTypes.JobOutputOptions CreateJobOutputOptions()
    {
        var jobOutputOptionsResult = new Humidifier.Location.JobTypes.JobOutputOptions();

        return jobOutputOptionsResult;
    }

} // End Of Class

public static class InnerJobJobOutputOptionsFactoryExtensions
{
}
