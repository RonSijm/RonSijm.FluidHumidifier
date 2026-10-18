// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerDataSourceGlueRunConfigurationInputFactory(Action<Humidifier.DataZone.DataSourceTypes.GlueRunConfigurationInput> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.DataSourceTypes.GlueRunConfigurationInput>
{

    protected override Humidifier.DataZone.DataSourceTypes.GlueRunConfigurationInput Create()
    {
        var glueRunConfigurationInputResult = CreateGlueRunConfigurationInput();
        factoryAction?.Invoke(glueRunConfigurationInputResult);

        return glueRunConfigurationInputResult;
    }

    private Humidifier.DataZone.DataSourceTypes.GlueRunConfigurationInput CreateGlueRunConfigurationInput()
    {
        var glueRunConfigurationInputResult = new Humidifier.DataZone.DataSourceTypes.GlueRunConfigurationInput();

        return glueRunConfigurationInputResult;
    }

} // End Of Class

public static class InnerDataSourceGlueRunConfigurationInputFactoryExtensions
{
}
