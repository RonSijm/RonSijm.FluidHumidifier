// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerPatchBaselinePatchFilterGroupFactory(Action<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup> factoryAction = null) : SubResourceFactory<Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup>
{

    protected override Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup Create()
    {
        var patchFilterGroupResult = CreatePatchFilterGroup();
        factoryAction?.Invoke(patchFilterGroupResult);

        return patchFilterGroupResult;
    }

    private Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup CreatePatchFilterGroup()
    {
        var patchFilterGroupResult = new Humidifier.SSM.PatchBaselineTypes.PatchFilterGroup();

        return patchFilterGroupResult;
    }

} // End Of Class

public static class InnerPatchBaselinePatchFilterGroupFactoryExtensions
{
}
