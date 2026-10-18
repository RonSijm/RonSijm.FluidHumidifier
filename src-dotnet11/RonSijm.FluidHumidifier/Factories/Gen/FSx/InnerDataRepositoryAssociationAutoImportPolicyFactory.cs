// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerDataRepositoryAssociationAutoImportPolicyFactory(Action<Humidifier.FSx.DataRepositoryAssociationTypes.AutoImportPolicy> factoryAction = null) : SubResourceFactory<Humidifier.FSx.DataRepositoryAssociationTypes.AutoImportPolicy>
{

    protected override Humidifier.FSx.DataRepositoryAssociationTypes.AutoImportPolicy Create()
    {
        var autoImportPolicyResult = CreateAutoImportPolicy();
        factoryAction?.Invoke(autoImportPolicyResult);

        return autoImportPolicyResult;
    }

    private Humidifier.FSx.DataRepositoryAssociationTypes.AutoImportPolicy CreateAutoImportPolicy()
    {
        var autoImportPolicyResult = new Humidifier.FSx.DataRepositoryAssociationTypes.AutoImportPolicy();

        return autoImportPolicyResult;
    }

} // End Of Class

public static class InnerDataRepositoryAssociationAutoImportPolicyFactoryExtensions
{
}
