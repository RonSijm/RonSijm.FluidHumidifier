// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RedshiftServerless;

public class InnerWorkgroupConfigParameterFactory(Action<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter> factoryAction = null) : SubResourceFactory<Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter>
{

    protected override Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter Create()
    {
        var configParameterResult = CreateConfigParameter();
        factoryAction?.Invoke(configParameterResult);

        return configParameterResult;
    }

    private Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter CreateConfigParameter()
    {
        var configParameterResult = new Humidifier.RedshiftServerless.WorkgroupTypes.ConfigParameter();

        return configParameterResult;
    }

} // End Of Class

public static class InnerWorkgroupConfigParameterFactoryExtensions
{
}
