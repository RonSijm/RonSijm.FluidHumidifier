// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardFunctionFactory(Action<Humidifier.SageMaker.ModelCardTypes.Function> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.Function>
{

    protected override Humidifier.SageMaker.ModelCardTypes.Function Create()
    {
        var functionResult = CreateFunction();
        factoryAction?.Invoke(functionResult);

        return functionResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.Function CreateFunction()
    {
        var functionResult = new Humidifier.SageMaker.ModelCardTypes.Function();

        return functionResult;
    }

} // End Of Class

public static class InnerModelCardFunctionFactoryExtensions
{
}
