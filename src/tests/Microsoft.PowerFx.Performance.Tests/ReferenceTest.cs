using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnostics.Windows.Configs;
using BenchmarkDotNet.Engines;
using Microsoft.PowerFx.Core.Tests;
using Microsoft.PowerFx.Syntax;

namespace Microsoft.PowerFx.Performance.Tests
{
    [EtwProfiler]
    [CsvExporter]
    [MinColumn, Q1Column, MeanColumn, Q3Column, MaxColumn]
    public class ReferenceTest : PowerFxTest
    {
        [Benchmark]
        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        public int Reference1()
        {
            // Fixed duration, independant of CPU speed 
            Thread.Sleep(100);
            return 0;
        }

        [Benchmark]
        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining)]
        public long Reference2()
        {
            var j = 0;
            for (var i = 0; i < 1000000; i++)
            {
                j += i;
            }

            return j;
        }
    }
}
