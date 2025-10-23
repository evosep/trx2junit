// (c) gfoidl, all rights reserved

using System.IO;
using System.Threading.Tasks;

namespace gfoidl.Trx2Junit.Core.Abstractions
{
    public interface ITestResultXmlConverter
    {
        Task ConvertAsync(Stream input, TextWriter output);
        string GetOutputFile(string inputFile, string outputPath = null);
    }
}
