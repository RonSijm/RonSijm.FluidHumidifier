// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerVdmAttributesGuardianAttributesFactory(Action<Humidifier.SES.VdmAttributesTypes.GuardianAttributes> factoryAction = null) : SubResourceFactory<Humidifier.SES.VdmAttributesTypes.GuardianAttributes>
{

    protected override Humidifier.SES.VdmAttributesTypes.GuardianAttributes Create()
    {
        var guardianAttributesResult = CreateGuardianAttributes();
        factoryAction?.Invoke(guardianAttributesResult);

        return guardianAttributesResult;
    }

    private Humidifier.SES.VdmAttributesTypes.GuardianAttributes CreateGuardianAttributes()
    {
        var guardianAttributesResult = new Humidifier.SES.VdmAttributesTypes.GuardianAttributes();

        return guardianAttributesResult;
    }

} // End Of Class

public static class InnerVdmAttributesGuardianAttributesFactoryExtensions
{
}
