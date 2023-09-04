using System;

using R5T.T0132;


namespace R5T.L0060
{
    [FunctionalityMarker]
    public partial interface IFileOperator : IFunctionalityMarker
    {
#pragma warning disable IDE0051 // Remove unused private members
        private static L0054.IFileOperator _Platform => L0054.FileOperator.Instance;
#pragma warning restore IDE0051 // Remove unused private members
    }
}
