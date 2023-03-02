using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

using YamlDotNet.Core;

using Dogged;

using Foo.Core;

namespace Foo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine(Greeting.GetMessage());
        }
    }
}
