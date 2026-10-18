// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTransformJobTransformOutputFactory(Action<Humidifier.SageMaker.TransformJobTypes.TransformOutput> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TransformJobTypes.TransformOutput>
{

    protected override Humidifier.SageMaker.TransformJobTypes.TransformOutput Create()
    {
        var transformOutputResult = CreateTransformOutput();
        factoryAction?.Invoke(transformOutputResult);

        return transformOutputResult;
    }

    private Humidifier.SageMaker.TransformJobTypes.TransformOutput CreateTransformOutput()
    {
        var transformOutputResult = new Humidifier.SageMaker.TransformJobTypes.TransformOutput();

        return transformOutputResult;
    }

} // End Of Class

public static class InnerTransformJobTransformOutputFactoryExtensions
{
}
