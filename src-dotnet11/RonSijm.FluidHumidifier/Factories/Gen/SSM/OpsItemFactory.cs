// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class OpsItemFactory(string resourceName = null, Action<Humidifier.SSM.OpsItem> factoryAction = null) : ResourceFactory<Humidifier.SSM.OpsItem>(resourceName)
{

    protected override Humidifier.SSM.OpsItem Create()
    {
        var opsItemResult = CreateOpsItem();
        factoryAction?.Invoke(opsItemResult);

        return opsItemResult;
    }

    private Humidifier.SSM.OpsItem CreateOpsItem()
    {
        var opsItemResult = new Humidifier.SSM.OpsItem
        {
            GivenName = InputResourceName,
        };

        return opsItemResult;
    }

} // End Of Class

public static class OpsItemFactoryExtensions
{
}
