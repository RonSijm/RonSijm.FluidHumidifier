// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerUserAutoAcceptConfigFactory(Action<Humidifier.Connect.UserTypes.AutoAcceptConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.UserTypes.AutoAcceptConfig>
{

    protected override Humidifier.Connect.UserTypes.AutoAcceptConfig Create()
    {
        var autoAcceptConfigResult = CreateAutoAcceptConfig();
        factoryAction?.Invoke(autoAcceptConfigResult);

        return autoAcceptConfigResult;
    }

    private Humidifier.Connect.UserTypes.AutoAcceptConfig CreateAutoAcceptConfig()
    {
        var autoAcceptConfigResult = new Humidifier.Connect.UserTypes.AutoAcceptConfig();

        return autoAcceptConfigResult;
    }

} // End Of Class

public static class InnerUserAutoAcceptConfigFactoryExtensions
{
}
