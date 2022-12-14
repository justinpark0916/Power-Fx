// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using BenchmarkDotNet.Running;

namespace Microsoft.PowerFx.Performance.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 
             *       --> This program needs to be run ELEVATED
             *       
             *       --> Also set the following env. variable before starting VS
             *           SET MSBuildSDKsPath=C:\Program Files\dotnet\sdk\7.0.100\Sdks
             *              
             */

            //// reference for benchmarks
            //var reference = BenchmarkRunner.Run<ReferenceTest>();

            //// list of tests
            //var summary = BenchmarkRunner.Run<PerformanceTest1>();

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
