// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerAddonNamespaceConfigFactory(Action<Humidifier.EKS.AddonTypes.NamespaceConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.AddonTypes.NamespaceConfig>
{

    protected override Humidifier.EKS.AddonTypes.NamespaceConfig Create()
    {
        var namespaceConfigResult = CreateNamespaceConfig();
        factoryAction?.Invoke(namespaceConfigResult);

        return namespaceConfigResult;
    }

    private Humidifier.EKS.AddonTypes.NamespaceConfig CreateNamespaceConfig()
    {
        var namespaceConfigResult = new Humidifier.EKS.AddonTypes.NamespaceConfig();

        return namespaceConfigResult;
    }

} // End Of Class

public static class InnerAddonNamespaceConfigFactoryExtensions
{
}
