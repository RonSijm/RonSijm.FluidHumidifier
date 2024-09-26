// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerDataRepositoryAssociationAutoExportPolicyFactory(Action<Humidifier.FSx.DataRepositoryAssociationTypes.AutoExportPolicy> factoryAction = null) : SubResourceFactory<Humidifier.FSx.DataRepositoryAssociationTypes.AutoExportPolicy>
{

    protected override Humidifier.FSx.DataRepositoryAssociationTypes.AutoExportPolicy Create()
    {
        var autoExportPolicyResult = CreateAutoExportPolicy();
        factoryAction?.Invoke(autoExportPolicyResult);

        return autoExportPolicyResult;
    }

    private Humidifier.FSx.DataRepositoryAssociationTypes.AutoExportPolicy CreateAutoExportPolicy()
    {
        var autoExportPolicyResult = new Humidifier.FSx.DataRepositoryAssociationTypes.AutoExportPolicy();

        return autoExportPolicyResult;
    }

} // End Of Class

public static class InnerDataRepositoryAssociationAutoExportPolicyFactoryExtensions
{
}
