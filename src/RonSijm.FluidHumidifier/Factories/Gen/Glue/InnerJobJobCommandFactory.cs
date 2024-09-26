// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerJobJobCommandFactory(Action<Humidifier.Glue.JobTypes.JobCommand> factoryAction = null) : SubResourceFactory<Humidifier.Glue.JobTypes.JobCommand>
{

    protected override Humidifier.Glue.JobTypes.JobCommand Create()
    {
        var jobCommandResult = CreateJobCommand();
        factoryAction?.Invoke(jobCommandResult);

        return jobCommandResult;
    }

    private Humidifier.Glue.JobTypes.JobCommand CreateJobCommand()
    {
        var jobCommandResult = new Humidifier.Glue.JobTypes.JobCommand();

        return jobCommandResult;
    }

} // End Of Class

public static class InnerJobJobCommandFactoryExtensions
{
}
