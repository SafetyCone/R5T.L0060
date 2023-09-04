using System;


namespace R5T.L0060
{
    public class ExecutablePathOperator : IExecutablePathOperator
    {
        #region Infrastructure

        public static IExecutablePathOperator Instance { get; } = new ExecutablePathOperator();


        private ExecutablePathOperator()
        {
        }

        #endregion
    }
}
