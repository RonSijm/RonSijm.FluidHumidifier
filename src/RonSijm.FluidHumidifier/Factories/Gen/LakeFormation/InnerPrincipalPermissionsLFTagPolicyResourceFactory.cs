// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPrincipalPermissionsLFTagPolicyResourceFactory(Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagPolicyResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagPolicyResource>
{

    protected override Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagPolicyResource Create()
    {
        var lFTagPolicyResourceResult = CreateLFTagPolicyResource();
        factoryAction?.Invoke(lFTagPolicyResourceResult);

        return lFTagPolicyResourceResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagPolicyResource CreateLFTagPolicyResource()
    {
        var lFTagPolicyResourceResult = new Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagPolicyResource();

        return lFTagPolicyResourceResult;
    }

} // End Of Class

public static class InnerPrincipalPermissionsLFTagPolicyResourceFactoryExtensions
{
}
