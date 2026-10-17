// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobLambdaInvokeOperationFactory(Action<Humidifier.S3.JobTypes.LambdaInvokeOperation> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.LambdaInvokeOperation>
{

    protected override Humidifier.S3.JobTypes.LambdaInvokeOperation Create()
    {
        var lambdaInvokeOperationResult = CreateLambdaInvokeOperation();
        factoryAction?.Invoke(lambdaInvokeOperationResult);

        return lambdaInvokeOperationResult;
    }

    private Humidifier.S3.JobTypes.LambdaInvokeOperation CreateLambdaInvokeOperation()
    {
        var lambdaInvokeOperationResult = new Humidifier.S3.JobTypes.LambdaInvokeOperation();

        return lambdaInvokeOperationResult;
    }

} // End Of Class

public static class InnerJobLambdaInvokeOperationFactoryExtensions
{
}
