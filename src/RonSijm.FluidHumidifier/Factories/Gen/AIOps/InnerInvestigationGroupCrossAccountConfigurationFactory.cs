// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AIOps;

public class InnerInvestigationGroupCrossAccountConfigurationFactory(Action<Humidifier.AIOps.InvestigationGroupTypes.CrossAccountConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AIOps.InvestigationGroupTypes.CrossAccountConfiguration>
{

    protected override Humidifier.AIOps.InvestigationGroupTypes.CrossAccountConfiguration Create()
    {
        var crossAccountConfigurationResult = CreateCrossAccountConfiguration();
        factoryAction?.Invoke(crossAccountConfigurationResult);

        return crossAccountConfigurationResult;
    }

    private Humidifier.AIOps.InvestigationGroupTypes.CrossAccountConfiguration CreateCrossAccountConfiguration()
    {
        var crossAccountConfigurationResult = new Humidifier.AIOps.InvestigationGroupTypes.CrossAccountConfiguration();

        return crossAccountConfigurationResult;
    }

} // End Of Class

public static class InnerInvestigationGroupCrossAccountConfigurationFactoryExtensions
{
}
