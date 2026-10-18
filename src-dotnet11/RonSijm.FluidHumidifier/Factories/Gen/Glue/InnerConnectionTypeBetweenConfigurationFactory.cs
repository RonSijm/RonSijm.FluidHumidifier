// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerConnectionTypeBetweenConfigurationFactory(Action<Humidifier.Glue.ConnectionTypeTypes.BetweenConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Glue.ConnectionTypeTypes.BetweenConfiguration>
{

    protected override Humidifier.Glue.ConnectionTypeTypes.BetweenConfiguration Create()
    {
        var betweenConfigurationResult = CreateBetweenConfiguration();
        factoryAction?.Invoke(betweenConfigurationResult);

        return betweenConfigurationResult;
    }

    private Humidifier.Glue.ConnectionTypeTypes.BetweenConfiguration CreateBetweenConfiguration()
    {
        var betweenConfigurationResult = new Humidifier.Glue.ConnectionTypeTypes.BetweenConfiguration();

        return betweenConfigurationResult;
    }

} // End Of Class

public static class InnerConnectionTypeBetweenConfigurationFactoryExtensions
{
}
