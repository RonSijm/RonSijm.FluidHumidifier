// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FinSpace;

public class InnerEnvironmentSuperuserParametersFactory(Action<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters> factoryAction = null) : SubResourceFactory<Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters>
{

    protected override Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters Create()
    {
        var superuserParametersResult = CreateSuperuserParameters();
        factoryAction?.Invoke(superuserParametersResult);

        return superuserParametersResult;
    }

    private Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters CreateSuperuserParameters()
    {
        var superuserParametersResult = new Humidifier.FinSpace.EnvironmentTypes.SuperuserParameters();

        return superuserParametersResult;
    }

} // End Of Class

public static class InnerEnvironmentSuperuserParametersFactoryExtensions
{
}
