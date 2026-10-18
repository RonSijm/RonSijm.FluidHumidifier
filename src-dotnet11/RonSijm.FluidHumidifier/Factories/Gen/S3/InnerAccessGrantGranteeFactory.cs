// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerAccessGrantGranteeFactory(Action<Humidifier.S3.AccessGrantTypes.Grantee> factoryAction = null) : SubResourceFactory<Humidifier.S3.AccessGrantTypes.Grantee>
{

    protected override Humidifier.S3.AccessGrantTypes.Grantee Create()
    {
        var granteeResult = CreateGrantee();
        factoryAction?.Invoke(granteeResult);

        return granteeResult;
    }

    private Humidifier.S3.AccessGrantTypes.Grantee CreateGrantee()
    {
        var granteeResult = new Humidifier.S3.AccessGrantTypes.Grantee();

        return granteeResult;
    }

} // End Of Class

public static class InnerAccessGrantGranteeFactoryExtensions
{
}
