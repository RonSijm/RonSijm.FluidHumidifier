// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ARCZonalShift;

public class InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactory(Action<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration>
{

    protected override Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration Create()
    {
        var practiceRunConfigurationResult = CreatePracticeRunConfiguration();
        factoryAction?.Invoke(practiceRunConfigurationResult);

        return practiceRunConfigurationResult;
    }

    private Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration CreatePracticeRunConfiguration()
    {
        var practiceRunConfigurationResult = new Humidifier.ARCZonalShift.ZonalAutoshiftConfigurationTypes.PracticeRunConfiguration();

        return practiceRunConfigurationResult;
    }

} // End Of Class

public static class InnerZonalAutoshiftConfigurationPracticeRunConfigurationFactoryExtensions
{
}
