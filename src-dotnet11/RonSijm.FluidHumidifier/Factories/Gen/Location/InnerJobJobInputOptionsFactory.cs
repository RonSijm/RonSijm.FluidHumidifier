// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class InnerJobJobInputOptionsFactory(Action<Humidifier.Location.JobTypes.JobInputOptions> factoryAction = null) : SubResourceFactory<Humidifier.Location.JobTypes.JobInputOptions>
{

    protected override Humidifier.Location.JobTypes.JobInputOptions Create()
    {
        var jobInputOptionsResult = CreateJobInputOptions();
        factoryAction?.Invoke(jobInputOptionsResult);

        return jobInputOptionsResult;
    }

    private Humidifier.Location.JobTypes.JobInputOptions CreateJobInputOptions()
    {
        var jobInputOptionsResult = new Humidifier.Location.JobTypes.JobInputOptions();

        return jobInputOptionsResult;
    }

} // End Of Class

public static class InnerJobJobInputOptionsFactoryExtensions
{
}
