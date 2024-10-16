// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerEmailIdentityDkimSigningAttributesFactory(Action<Humidifier.SES.EmailIdentityTypes.DkimSigningAttributes> factoryAction = null) : SubResourceFactory<Humidifier.SES.EmailIdentityTypes.DkimSigningAttributes>
{

    protected override Humidifier.SES.EmailIdentityTypes.DkimSigningAttributes Create()
    {
        var dkimSigningAttributesResult = CreateDkimSigningAttributes();
        factoryAction?.Invoke(dkimSigningAttributesResult);

        return dkimSigningAttributesResult;
    }

    private Humidifier.SES.EmailIdentityTypes.DkimSigningAttributes CreateDkimSigningAttributes()
    {
        var dkimSigningAttributesResult = new Humidifier.SES.EmailIdentityTypes.DkimSigningAttributes();

        return dkimSigningAttributesResult;
    }

} // End Of Class

public static class InnerEmailIdentityDkimSigningAttributesFactoryExtensions
{
}
