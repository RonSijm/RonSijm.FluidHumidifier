// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VpcLattice;

public class ResourcePolicyFactory(string resourceName = null, Action<Humidifier.VpcLattice.ResourcePolicy> factoryAction = null) : ResourceFactory<Humidifier.VpcLattice.ResourcePolicy>(resourceName)
{

    protected override Humidifier.VpcLattice.ResourcePolicy Create()
    {
        var resourcePolicyResult = CreateResourcePolicy();
        factoryAction?.Invoke(resourcePolicyResult);

        return resourcePolicyResult;
    }

    private Humidifier.VpcLattice.ResourcePolicy CreateResourcePolicy()
    {
        var resourcePolicyResult = new Humidifier.VpcLattice.ResourcePolicy
        {
            GivenName = InputResourceName,
        };

        return resourcePolicyResult;
    }

} // End Of Class

public static class ResourcePolicyFactoryExtensions
{
}
