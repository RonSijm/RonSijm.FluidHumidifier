// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AWSExternalAnthropic;

public class InnerWorkspaceDataResidencyFactory(Action<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency> factoryAction = null) : SubResourceFactory<Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency>
{

    protected override Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency Create()
    {
        var dataResidencyResult = CreateDataResidency();
        factoryAction?.Invoke(dataResidencyResult);

        return dataResidencyResult;
    }

    private Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency CreateDataResidency()
    {
        var dataResidencyResult = new Humidifier.AWSExternalAnthropic.WorkspaceTypes.DataResidency();

        return dataResidencyResult;
    }

} // End Of Class

public static class InnerWorkspaceDataResidencyFactoryExtensions
{
}
