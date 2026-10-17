// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeFilterStringConfigurationFactory(Action<Humidifier.Glue.ConnectionTypeTypes.FilterStringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.FilterStringConfiguration>
{

    protected override Humidifier.Glue.ConnectionTypeTypes.FilterStringConfiguration Create()
    {
        var filterStringConfigurationResult = CreateFilterStringConfiguration();
        factoryAction?.Invoke(filterStringConfigurationResult);

        return filterStringConfigurationResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.FilterStringConfiguration CreateFilterStringConfiguration()
    {
        var filterStringConfigurationResult = new Humidifier.Glue.ConnectionTypeTypes.FilterStringConfiguration();

        return filterStringConfigurationResult;
    }

} // End Of Class

public static class InnerConnectionTypeFilterStringConfigurationFactoryExtensions
{
}
