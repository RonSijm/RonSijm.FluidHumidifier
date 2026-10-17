// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Tables;

public class TablePolicyFactory(string resourceName = null, Action<Humidifier.S3Tables.TablePolicy> factoryAction = null) : ResourceFactory<Humidifier.S3Tables.TablePolicy>(resourceName)
{

    protected override Humidifier.S3Tables.TablePolicy Create()
    {
        var tablePolicyResult = CreateTablePolicy();
        factoryAction?.Invoke(tablePolicyResult);

        return tablePolicyResult;
    }

    private Humidifier.S3Tables.TablePolicy CreateTablePolicy()
    {
        var tablePolicyResult = new Humidifier.S3Tables.TablePolicy
        {
            GivenName = InputResourceName,
        };

        return tablePolicyResult;
    }

} // End Of Class

public static class TablePolicyFactoryExtensions
{
}
