// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class DataShareFactory(string resourceName = null, Action<Humidifier.Redshift.DataShare> factoryAction = null) : ResourceFactory<Humidifier.Redshift.DataShare>(resourceName)
{

    protected override Humidifier.Redshift.DataShare Create()
    {
        var dataShareResult = CreateDataShare();
        factoryAction?.Invoke(dataShareResult);

        return dataShareResult;
    }

    private Humidifier.Redshift.DataShare CreateDataShare()
    {
        var dataShareResult = new Humidifier.Redshift.DataShare
        {
            GivenName = InputResourceName,
        };

        return dataShareResult;
    }

} // End Of Class

public static class DataShareFactoryExtensions
{
}
