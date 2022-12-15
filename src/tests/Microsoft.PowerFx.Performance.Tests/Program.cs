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
             *       --> This program needs to be run ELEVATED and compiles in "Release" configuration
             *       
             *       --> Also set the following env. variable before starting VS
             *           SET MSBuildSDKsPath=C:\Program Files\dotnet\sdk\6.0.307\Sdks                 
             *              
             *      --> The .NET tools collect usage data in order to help us improve your experience. 
             *          It is collected by Microsoft and shared with the community. 
             *          You can opt-out of telemetry by setting the DOTNET_CLI_TELEMETRY_OPTOUT environment variable to '1' or 'true' using your favorite shell.
             *          
             *      --> To execute the project, go in src\tests\Microsoft.PowerFx.Performance.Tests and run RunBenchmark.cmd
             */

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}
