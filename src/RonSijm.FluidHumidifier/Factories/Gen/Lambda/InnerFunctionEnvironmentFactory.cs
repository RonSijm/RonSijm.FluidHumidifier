// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerFunctionEnvironmentFactory(Action<Humidifier.Lambda.FunctionTypes.Environment> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.FunctionTypes.Environment>
{

    protected override Humidifier.Lambda.FunctionTypes.Environment Create()
    {
        var environmentResult = CreateEnvironment();
        factoryAction?.Invoke(environmentResult);

        return environmentResult;
    }

    private Humidifier.Lambda.FunctionTypes.Environment CreateEnvironment()
    {
        var environmentResult = new Humidifier.Lambda.FunctionTypes.Environment();

        return environmentResult;
    }

} // End Of Class

public static class InnerFunctionEnvironmentFactoryExtensions
{
}
