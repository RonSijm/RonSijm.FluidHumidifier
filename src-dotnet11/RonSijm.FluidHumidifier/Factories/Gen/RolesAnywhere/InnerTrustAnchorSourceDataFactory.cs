// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RolesAnywhere;

public class InnerTrustAnchorSourceDataFactory(Action<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData> factoryAction = null) : SubResourceFactory<Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData>
{

    protected override Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData Create()
    {
        var sourceDataResult = CreateSourceData();
        factoryAction?.Invoke(sourceDataResult);

        return sourceDataResult;
    }

    private Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData CreateSourceData()
    {
        var sourceDataResult = new Humidifier.RolesAnywhere.TrustAnchorTypes.SourceData();

        return sourceDataResult;
    }

} // End Of Class

public static class InnerTrustAnchorSourceDataFactoryExtensions
{
}
