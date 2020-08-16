using SevenZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDDC.Compress
{
    public class CD7ZipProgress
    {        
        public double PercentDone { get; internal set; }
    }
    public static class CD7Zip
    {
        public static void Compress(Stream streamIn, Stream streamOut, EventHandler<CD7ZipProgress> progress)
        {
            var comp = new SevenZipCompressor
            {
                CompressionLevel = CompressionLevel.High,
                
            };
            SevenZipCompressor.CompressStream(streamIn, streamOut, (int)streamIn.Length, (s, e) => { progress(s, new CD7ZipProgress { PercentDone = e.PercentDone }); });
        }
    }
}
