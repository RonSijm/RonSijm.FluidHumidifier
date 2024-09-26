// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationOutputLambdaOutputFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.LambdaOutput> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.LambdaOutput>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.LambdaOutput Create()
    {
        var lambdaOutputResult = CreateLambdaOutput();
        factoryAction?.Invoke(lambdaOutputResult);

        return lambdaOutputResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.LambdaOutput CreateLambdaOutput()
    {
        var lambdaOutputResult = new Humidifier.KinesisAnalyticsV2.ApplicationOutputTypes.LambdaOutput();

        return lambdaOutputResult;
    }

} // End Of Class

public static class InnerApplicationOutputLambdaOutputFactoryExtensions
{
}
