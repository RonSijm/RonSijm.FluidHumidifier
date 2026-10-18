// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterOutputFabricConfigurationFactory(Action<Humidifier.MediaConnect.RouterOutputTypes.FabricConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterOutputTypes.FabricConfiguration>
{

    protected override Humidifier.MediaConnect.RouterOutputTypes.FabricConfiguration Create()
    {
        var fabricConfigurationResult = CreateFabricConfiguration();
        factoryAction?.Invoke(fabricConfigurationResult);

        return fabricConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterOutputTypes.FabricConfiguration CreateFabricConfiguration()
    {
        var fabricConfigurationResult = new Humidifier.MediaConnect.RouterOutputTypes.FabricConfiguration();

        return fabricConfigurationResult;
    }

} // End Of Class

public static class InnerRouterOutputFabricConfigurationFactoryExtensions
{
}
