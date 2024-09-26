// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerEmailIdentityDkimAttributesFactory(Action<Humidifier.SES.EmailIdentityTypes.DkimAttributes> factoryAction = null) : SubResourceFactory<Humidifier.SES.EmailIdentityTypes.DkimAttributes>
{

    protected override Humidifier.SES.EmailIdentityTypes.DkimAttributes Create()
    {
        var dkimAttributesResult = CreateDkimAttributes();
        factoryAction?.Invoke(dkimAttributesResult);

        return dkimAttributesResult;
    }

    private Humidifier.SES.EmailIdentityTypes.DkimAttributes CreateDkimAttributes()
    {
        var dkimAttributesResult = new Humidifier.SES.EmailIdentityTypes.DkimAttributes();

        return dkimAttributesResult;
    }

} // End Of Class

public static class InnerEmailIdentityDkimAttributesFactoryExtensions
{
}
