// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerAgreementCustomDirectoriesFactory(Action<Humidifier.Transfer.AgreementTypes.CustomDirectories> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.AgreementTypes.CustomDirectories>
{

    protected override Humidifier.Transfer.AgreementTypes.CustomDirectories Create()
    {
        var customDirectoriesResult = CreateCustomDirectories();
        factoryAction?.Invoke(customDirectoriesResult);

        return customDirectoriesResult;
    }

    private Humidifier.Transfer.AgreementTypes.CustomDirectories CreateCustomDirectories()
    {
        var customDirectoriesResult = new Humidifier.Transfer.AgreementTypes.CustomDirectories();

        return customDirectoriesResult;
    }

} // End Of Class

public static class InnerAgreementCustomDirectoriesFactoryExtensions
{
}
