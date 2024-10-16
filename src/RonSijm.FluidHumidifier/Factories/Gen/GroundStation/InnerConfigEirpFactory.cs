// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigEirpFactory(Action<Humidifier.GroundStation.ConfigTypes.Eirp> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.Eirp>
{

    protected override Humidifier.GroundStation.ConfigTypes.Eirp Create()
    {
        var eirpResult = CreateEirp();
        factoryAction?.Invoke(eirpResult);

        return eirpResult;
    }

    private Humidifier.GroundStation.ConfigTypes.Eirp CreateEirp()
    {
        var eirpResult = new Humidifier.GroundStation.ConfigTypes.Eirp();

        return eirpResult;
    }

} // End Of Class

public static class InnerConfigEirpFactoryExtensions
{
}
