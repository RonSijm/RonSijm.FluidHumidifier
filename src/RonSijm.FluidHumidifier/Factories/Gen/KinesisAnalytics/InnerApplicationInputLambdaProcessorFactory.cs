// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationInputLambdaProcessorFactory(Action<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor>
{

    protected override Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor Create()
    {
        var inputLambdaProcessorResult = CreateInputLambdaProcessor();
        factoryAction?.Invoke(inputLambdaProcessorResult);

        return inputLambdaProcessorResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor CreateInputLambdaProcessor()
    {
        var inputLambdaProcessorResult = new Humidifier.KinesisAnalytics.ApplicationTypes.InputLambdaProcessor();

        return inputLambdaProcessorResult;
    }

} // End Of Class

public static class InnerApplicationInputLambdaProcessorFactoryExtensions
{
}
