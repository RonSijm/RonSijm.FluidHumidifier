// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterKerberosAttributesFactory(Action<Humidifier.EMR.ClusterTypes.KerberosAttributes> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.KerberosAttributes>
{

    protected override Humidifier.EMR.ClusterTypes.KerberosAttributes Create()
    {
        var kerberosAttributesResult = CreateKerberosAttributes();
        factoryAction?.Invoke(kerberosAttributesResult);

        return kerberosAttributesResult;
    }

    private Humidifier.EMR.ClusterTypes.KerberosAttributes CreateKerberosAttributes()
    {
        var kerberosAttributesResult = new Humidifier.EMR.ClusterTypes.KerberosAttributes();

        return kerberosAttributesResult;
    }

} // End Of Class

public static class InnerClusterKerberosAttributesFactoryExtensions
{
}
