// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Inspector;

public class ResourceGroupFactory(string resourceName = null, Action<Humidifier.Inspector.ResourceGroup> factoryAction = null) : ResourceFactory<Humidifier.Inspector.ResourceGroup>(resourceName)
{

    protected override Humidifier.Inspector.ResourceGroup Create()
    {
        var resourceGroupResult = CreateResourceGroup();
        factoryAction?.Invoke(resourceGroupResult);

        return resourceGroupResult;
    }

    private Humidifier.Inspector.ResourceGroup CreateResourceGroup()
    {
        var resourceGroupResult = new Humidifier.Inspector.ResourceGroup
        {
            GivenName = InputResourceName,
        };

        return resourceGroupResult;
    }

} // End Of Class

public static class ResourceGroupFactoryExtensions
{
}
