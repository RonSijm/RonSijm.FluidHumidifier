// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Organizations;

public class ResponsibilityTransferFactory(string resourceName = null, Action<Humidifier.Organizations.ResponsibilityTransfer> factoryAction = null) : ResourceFactory<Humidifier.Organizations.ResponsibilityTransfer>(resourceName)
{

    protected override Humidifier.Organizations.ResponsibilityTransfer Create()
    {
        var responsibilityTransferResult = CreateResponsibilityTransfer();
        factoryAction?.Invoke(responsibilityTransferResult);

        return responsibilityTransferResult;
    }

    private Humidifier.Organizations.ResponsibilityTransfer CreateResponsibilityTransfer()
    {
        var responsibilityTransferResult = new Humidifier.Organizations.ResponsibilityTransfer
        {
            GivenName = InputResourceName,
        };

        return responsibilityTransferResult;
    }

} // End Of Class

public static class ResponsibilityTransferFactoryExtensions
{
}
