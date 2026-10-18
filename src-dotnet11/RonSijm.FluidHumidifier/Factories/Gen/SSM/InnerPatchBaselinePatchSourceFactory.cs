// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerPatchBaselinePatchSourceFactory(Action<Humidifier.SSM.PatchBaselineTypes.PatchSource> factoryAction = null) : SubResourceFactory<Humidifier.SSM.PatchBaselineTypes.PatchSource>
{

    protected override Humidifier.SSM.PatchBaselineTypes.PatchSource Create()
    {
        var patchSourceResult = CreatePatchSource();
        factoryAction?.Invoke(patchSourceResult);

        return patchSourceResult;
    }

    private Humidifier.SSM.PatchBaselineTypes.PatchSource CreatePatchSource()
    {
        var patchSourceResult = new Humidifier.SSM.PatchBaselineTypes.PatchSource();

        return patchSourceResult;
    }

} // End Of Class

public static class InnerPatchBaselinePatchSourceFactoryExtensions
{
}
