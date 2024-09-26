// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceAuroraParametersFactory(Action<Humidifier.QuickSight.DataSourceTypes.AuroraParameters> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.AuroraParameters>
{

    protected override Humidifier.QuickSight.DataSourceTypes.AuroraParameters Create()
    {
        var auroraParametersResult = CreateAuroraParameters();
        factoryAction?.Invoke(auroraParametersResult);

        return auroraParametersResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.AuroraParameters CreateAuroraParameters()
    {
        var auroraParametersResult = new Humidifier.QuickSight.DataSourceTypes.AuroraParameters();

        return auroraParametersResult;
    }

} // End Of Class

public static class InnerDataSourceAuroraParametersFactoryExtensions
{
}
