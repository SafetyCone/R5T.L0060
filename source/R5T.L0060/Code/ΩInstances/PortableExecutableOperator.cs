using System;


namespace R5T.L0060
{
    public class PortableExecutableOperator : IPortableExecutableOperator
    {
        #region Infrastructure

        public static IPortableExecutableOperator Instance { get; } = new PortableExecutableOperator();


        private PortableExecutableOperator()
        {
        }

        #endregion
    }
}
