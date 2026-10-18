// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaPackageV2;

public class InnerOriginEndpointPolicyCdnAuthConfigurationFactory(Action<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration>
{

    protected override Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration Create()
    {
        var cdnAuthConfigurationResult = CreateCdnAuthConfiguration();
        factoryAction?.Invoke(cdnAuthConfigurationResult);

        return cdnAuthConfigurationResult;
    }

    private Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration CreateCdnAuthConfiguration()
    {
        var cdnAuthConfigurationResult = new Humidifier.MediaPackageV2.OriginEndpointPolicyTypes.CdnAuthConfiguration();

        return cdnAuthConfigurationResult;
    }

} // End Of Class

public static class InnerOriginEndpointPolicyCdnAuthConfigurationFactoryExtensions
{
}
