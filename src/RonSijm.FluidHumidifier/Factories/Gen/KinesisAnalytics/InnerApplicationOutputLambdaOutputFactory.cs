// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationOutputLambdaOutputFactory(Action<Humidifier.KinesisAnalytics.ApplicationOutputTypes.LambdaOutput> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationOutputTypes.LambdaOutput>
{

    protected override Humidifier.KinesisAnalytics.ApplicationOutputTypes.LambdaOutput Create()
    {
        var lambdaOutputResult = CreateLambdaOutput();
        factoryAction?.Invoke(lambdaOutputResult);

        return lambdaOutputResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationOutputTypes.LambdaOutput CreateLambdaOutput()
    {
        var lambdaOutputResult = new Humidifier.KinesisAnalytics.ApplicationOutputTypes.LambdaOutput();

        return lambdaOutputResult;
    }

} // End Of Class

public static class InnerApplicationOutputLambdaOutputFactoryExtensions
{
}
