using System;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

using R5T.L0054;
using R5T.T0132;
using R5T.T0181;
using R5T.T0213;
using R5T.T0213.Extensions;


namespace R5T.L0060
{
    [FunctionalityMarker]
    public partial interface IPortableExecutableOperator : IFunctionalityMarker
    {
#pragma warning disable IDE1006 // Naming Styles
        private static L0054.IPortableExecutableOperator _Platform => L0054.PortableExecutableOperator.Instance;
#pragma warning restore IDE1006 // Naming Styles


        public async Task<IFullAssemblyName> Get_FullAssemblyName(IDllFilePath dllFilePath)
        {
            var fullAssemblyName = await _Platform.Get_FullAssemblyName(
                dllFilePath.Value);

            var output = fullAssemblyName
                .ToFullAssemblyName();

            return output;
        }

        public void In_MetadataReaderContext(
            IDllFilePath dllFilePath,
            Action<MetadataReader> action)
        {
            _Platform.In_MetadataReaderContext(
                dllFilePath.Value,
                action);
        }

        public Task In_MetadataReaderContext(
            IDllFilePath dllFilePath,
            Func<MetadataReader, Task> action)
        {
            return _Platform.In_MetadataReaderContext(
                dllFilePath.Value,
                action);
        }

        public void In_MetadataReaderWrapperContext(
            IDllFilePath dllFilePath,
            Action<MetadataReaderWrapper> action)
        {
            _Platform.In_MetadataReaderWrapperContext(
                dllFilePath.Value,
                action);
        }

        public Task In_MetadataReaderWrapperContext(
            IDllFilePath dllFilePath,
            Func<MetadataReaderWrapper, Task> action)
        {
            return _Platform.In_MetadataReaderWrapperContext(
                dllFilePath.Value,
                action);
        }

        public void In_ReaderContext(
            IDllFilePath dllFilePath,
            Action<PEReader> action)
        {
            _Platform.In_ReaderContext_Synchronous(
                dllFilePath.Value,
                action);
        }

        public Task In_ReaderContext(
            IDllFilePath dllFilePath,
            Func<PEReader, Task> action)
        {
            return _Platform.In_ReaderContext_Synchronous(
                dllFilePath.Value,
                action);
        }
    }
}
