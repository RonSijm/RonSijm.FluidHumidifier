// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Grafana;

public class InnerWorkspaceAssertionAttributesFactory(Action<Humidifier.Grafana.WorkspaceTypes.AssertionAttributes> factoryAction = null) : SubResourceFactory<Humidifier.Grafana.WorkspaceTypes.AssertionAttributes>
{

    protected override Humidifier.Grafana.WorkspaceTypes.AssertionAttributes Create()
    {
        var assertionAttributesResult = CreateAssertionAttributes();
        factoryAction?.Invoke(assertionAttributesResult);

        return assertionAttributesResult;
    }

    private Humidifier.Grafana.WorkspaceTypes.AssertionAttributes CreateAssertionAttributes()
    {
        var assertionAttributesResult = new Humidifier.Grafana.WorkspaceTypes.AssertionAttributes();

        return assertionAttributesResult;
    }

} // End Of Class

public static class InnerWorkspaceAssertionAttributesFactoryExtensions
{
}
