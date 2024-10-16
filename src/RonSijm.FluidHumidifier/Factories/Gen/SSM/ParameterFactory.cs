// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class ParameterFactory(string resourceName = null, Action<Humidifier.SSM.Parameter> factoryAction = null) : ResourceFactory<Humidifier.SSM.Parameter>(resourceName)
{

    protected override Humidifier.SSM.Parameter Create()
    {
        var parameterResult = CreateParameter();
        factoryAction?.Invoke(parameterResult);

        return parameterResult;
    }

    private Humidifier.SSM.Parameter CreateParameter()
    {
        var parameterResult = new Humidifier.SSM.Parameter
        {
            GivenName = InputResourceName,
        };

        return parameterResult;
    }

} // End Of Class

public static class ParameterFactoryExtensions
{
}
