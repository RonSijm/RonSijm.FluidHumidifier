// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionCodeFactory(Action<Humidifier.Lambda.FunctionTypes.Code> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.Code>
{

    protected override Humidifier.Lambda.FunctionTypes.Code Create()
    {
        var codeResult = CreateCode();
        factoryAction?.Invoke(codeResult);

        return codeResult;
    }

    private Humidifier.Lambda.FunctionTypes.Code CreateCode()
    {
        var codeResult = new Humidifier.Lambda.FunctionTypes.Code();

        return codeResult;
    }

} // End Of Class

public static class InnerFunctionCodeFactoryExtensions
{
}
