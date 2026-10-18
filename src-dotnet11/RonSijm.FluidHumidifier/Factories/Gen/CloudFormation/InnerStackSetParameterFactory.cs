// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerStackSetParameterFactory(Action<Humidifier.CloudFormation.StackSetTypes.Parameter> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.StackSetTypes.Parameter>
{

    protected override Humidifier.CloudFormation.StackSetTypes.Parameter Create()
    {
        var parameterResult = CreateParameter();
        factoryAction?.Invoke(parameterResult);

        return parameterResult;
    }

    private Humidifier.CloudFormation.StackSetTypes.Parameter CreateParameter()
    {
        var parameterResult = new Humidifier.CloudFormation.StackSetTypes.Parameter();

        return parameterResult;
    }

} // End Of Class

public static class InnerStackSetParameterFactoryExtensions
{
}
