// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ResourceExplorer2;

public class DefaultViewAssociationFactory(string resourceName = null, Action<Humidifier.ResourceExplorer2.DefaultViewAssociation> factoryAction = null) : ResourceFactory<Humidifier.ResourceExplorer2.DefaultViewAssociation>(resourceName)
{

    protected override Humidifier.ResourceExplorer2.DefaultViewAssociation Create()
    {
        var defaultViewAssociationResult = CreateDefaultViewAssociation();
        factoryAction?.Invoke(defaultViewAssociationResult);

        return defaultViewAssociationResult;
    }

    private Humidifier.ResourceExplorer2.DefaultViewAssociation CreateDefaultViewAssociation()
    {
        var defaultViewAssociationResult = new Humidifier.ResourceExplorer2.DefaultViewAssociation
        {
            GivenName = InputResourceName,
        };

        return defaultViewAssociationResult;
    }

} // End Of Class

public static class DefaultViewAssociationFactoryExtensions
{
}
