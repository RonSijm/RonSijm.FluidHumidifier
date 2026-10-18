using System.Collections;
using Humidifier.Base;
using Humidifier.Interfaces;

namespace RonSijm.FluidHumidifier.Features.Consumer
{
    public class ExportModel : IEnumerable<IResultFactory>
    {
        internal readonly List<IResultFactory> ExportedFactories = new();

        public void Add<T>(ResourceFactory<T> factory) where T : BaseResource
        {
            factory.ExtendedActions.Enqueue(x => x.Export = true);
            ExportedFactories.Add(factory);
        }

        public static implicit operator ImportModel(ExportModel source)
        {
            return new ImportModel(source);
        }

        public IEnumerator<IResultFactory> GetEnumerator()
        {
            return ExportedFactories.GetEnumerator();
        }

        [MustDisposeResource]
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)ExportedFactories).GetEnumerator();
        }
    }

    public class ImportModel
    {
        private readonly List<IResultFactory> _importedFactories;

        public ImportModel(ExportModel exportModel)
        {
            _importedFactories = exportModel.ExportedFactories.ToList();
        }

        public ImportModel(params IResultFactory[] factories)
        {
            _importedFactories = factories.ToList();
        }

        public ImportModel(List<ExportModel> importModel)
        {
            _importedFactories = new List<IResultFactory>();

            foreach (var exportModel in importModel)
            {
                _importedFactories.AddRange(exportModel.ExportedFactories);
            }
        }

        public IResultFactory Single(Func<IResultFactory, bool> predicate)
        {
            return _importedFactories.Single(predicate);
        }

        public static implicit operator ImportModel(List<ExportModel> sources)
        {
            return new ImportModel(sources);
        }
    }
}