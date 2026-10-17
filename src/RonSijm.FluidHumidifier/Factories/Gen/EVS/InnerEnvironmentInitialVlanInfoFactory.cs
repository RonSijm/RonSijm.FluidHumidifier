// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EVS;

public class InnerEnvironmentInitialVlanInfoFactory(Action<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo> factoryAction = null) : SubResourceFactory<Humidifier.EVS.EnvironmentTypes.InitialVlanInfo>
{

    protected override Humidifier.EVS.EnvironmentTypes.InitialVlanInfo Create()
    {
        var initialVlanInfoResult = CreateInitialVlanInfo();
        factoryAction?.Invoke(initialVlanInfoResult);

        return initialVlanInfoResult;
    }

    private Humidifier.EVS.EnvironmentTypes.InitialVlanInfo CreateInitialVlanInfo()
    {
        var initialVlanInfoResult = new Humidifier.EVS.EnvironmentTypes.InitialVlanInfo();

        return initialVlanInfoResult;
    }

} // End Of Class

public static class InnerEnvironmentInitialVlanInfoFactoryExtensions
{
}
