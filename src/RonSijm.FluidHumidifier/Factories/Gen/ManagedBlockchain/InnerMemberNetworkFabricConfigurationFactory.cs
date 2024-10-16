// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ManagedBlockchain;

public class InnerMemberNetworkFabricConfigurationFactory(Action<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration>
{

    protected override Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration Create()
    {
        var networkFabricConfigurationResult = CreateNetworkFabricConfiguration();
        factoryAction?.Invoke(networkFabricConfigurationResult);

        return networkFabricConfigurationResult;
    }

    private Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration CreateNetworkFabricConfiguration()
    {
        var networkFabricConfigurationResult = new Humidifier.ManagedBlockchain.MemberTypes.NetworkFabricConfiguration();

        return networkFabricConfigurationResult;
    }

} // End Of Class

public static class InnerMemberNetworkFabricConfigurationFactoryExtensions
{
}
