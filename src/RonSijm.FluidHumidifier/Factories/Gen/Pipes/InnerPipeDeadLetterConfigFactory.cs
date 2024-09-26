// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeDeadLetterConfigFactory(Action<Humidifier.Pipes.PipeTypes.DeadLetterConfig> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.DeadLetterConfig>
{

    protected override Humidifier.Pipes.PipeTypes.DeadLetterConfig Create()
    {
        var deadLetterConfigResult = CreateDeadLetterConfig();
        factoryAction?.Invoke(deadLetterConfigResult);

        return deadLetterConfigResult;
    }

    private Humidifier.Pipes.PipeTypes.DeadLetterConfig CreateDeadLetterConfig()
    {
        var deadLetterConfigResult = new Humidifier.Pipes.PipeTypes.DeadLetterConfig();

        return deadLetterConfigResult;
    }

} // End Of Class

public static class InnerPipeDeadLetterConfigFactoryExtensions
{
}
