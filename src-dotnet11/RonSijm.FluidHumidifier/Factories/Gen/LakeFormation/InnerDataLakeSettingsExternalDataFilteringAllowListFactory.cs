// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LakeFormation;

public class InnerDataLakeSettingsExternalDataFilteringAllowListFactory(Action<Humidifier.LakeFormation.DataLakeSettingsTypes.ExternalDataFilteringAllowList> factoryAction = null) : SubResourceFactory<Humidifier.LakeFormation.DataLakeSettingsTypes.ExternalDataFilteringAllowList>
{

    protected override Humidifier.LakeFormation.DataLakeSettingsTypes.ExternalDataFilteringAllowList Create()
    {
        var externalDataFilteringAllowListResult = CreateExternalDataFilteringAllowList();
        factoryAction?.Invoke(externalDataFilteringAllowListResult);

        return externalDataFilteringAllowListResult;
    }

    private Humidifier.LakeFormation.DataLakeSettingsTypes.ExternalDataFilteringAllowList CreateExternalDataFilteringAllowList()
    {
        var externalDataFilteringAllowListResult = new Humidifier.LakeFormation.DataLakeSettingsTypes.ExternalDataFilteringAllowList();

        return externalDataFilteringAllowListResult;
    }

} // End Of Class

public static class InnerDataLakeSettingsExternalDataFilteringAllowListFactoryExtensions
{
}
