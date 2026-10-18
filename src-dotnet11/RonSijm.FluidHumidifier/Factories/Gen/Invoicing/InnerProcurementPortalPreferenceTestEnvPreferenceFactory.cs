// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Invoicing;

public class InnerProcurementPortalPreferenceTestEnvPreferenceFactory(Action<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.TestEnvPreference> factoryAction = null) : SubResourceFactory<Humidifier.Invoicing.ProcurementPortalPreferenceTypes.TestEnvPreference>
{

    protected override Humidifier.Invoicing.ProcurementPortalPreferenceTypes.TestEnvPreference Create()
    {
        var testEnvPreferenceResult = CreateTestEnvPreference();
        factoryAction?.Invoke(testEnvPreferenceResult);

        return testEnvPreferenceResult;
    }

    private Humidifier.Invoicing.ProcurementPortalPreferenceTypes.TestEnvPreference CreateTestEnvPreference()
    {
        var testEnvPreferenceResult = new Humidifier.Invoicing.ProcurementPortalPreferenceTypes.TestEnvPreference();

        return testEnvPreferenceResult;
    }

} // End Of Class

public static class InnerProcurementPortalPreferenceTestEnvPreferenceFactoryExtensions
{
}
