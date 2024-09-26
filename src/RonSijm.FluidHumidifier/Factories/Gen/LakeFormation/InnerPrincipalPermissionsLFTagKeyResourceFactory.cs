// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerPrincipalPermissionsLFTagKeyResourceFactory(Action<Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagKeyResource> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagKeyResource>
{

    protected override Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagKeyResource Create()
    {
        var lFTagKeyResourceResult = CreateLFTagKeyResource();
        factoryAction?.Invoke(lFTagKeyResourceResult);

        return lFTagKeyResourceResult;
    }

    private Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagKeyResource CreateLFTagKeyResource()
    {
        var lFTagKeyResourceResult = new Humidifier.LakeFormation.PrincipalPermissionsTypes.LFTagKeyResource();

        return lFTagKeyResourceResult;
    }

} // End Of Class

public static class InnerPrincipalPermissionsLFTagKeyResourceFactoryExtensions
{
}
