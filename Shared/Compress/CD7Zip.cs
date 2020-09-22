using SevenZip;
using System;
using System.IO;

namespace CDDC.Compress
{
    public class CD7ZipProgress : Progress<CD7ZipProgress>
    {
        public float PercentDone { get; internal set; }
        public bool IsFinished { get; internal set; }

        protected override void OnReport(CD7ZipProgress value)
        {
            base.OnReport(value);
        }
    }
    public static class CD7Zip
    {
        public static void Compress(string fileName, Stream archive, Stream file, IProgress<CD7ZipProgress> progress)
        {
            var comp = new SevenZipCompressor
            {
                CompressionLevel = CompressionLevel.High,
                CompressionMethod = CompressionMethod.Lzma,
                ArchiveFormat = OutArchiveFormat.SevenZip,
                DefaultItemName = fileName,
            };

            comp.Compressing += (s, e) =>
            {
                progress.Report(new CD7ZipProgress
                {
                    PercentDone = e.PercentDone
                });
            };


            comp.CompressionFinished += (s, e) => progress.Report(new CD7ZipProgress { IsFinished = true, PercentDone = 100 });

            comp.BeginCompressStream(archive, file);
        }

        public static void CompressFiles(Stream archive, string[] files, IProgress<CD7ZipProgress> progress)
        {
            var comp = new SevenZipCompressor
            {
                CompressionLevel = CompressionLevel.High,
                CompressionMethod = CompressionMethod.Lzma,
                ArchiveFormat = OutArchiveFormat.SevenZip,
                //DefaultItemName = fileName,
            };

            comp.Compressing += (s, e) =>
            {
                progress.Report(new CD7ZipProgress
                {
                    PercentDone = e.PercentDone
                });
            };


            comp.CompressionFinished += (s, e) => progress.Report(new CD7ZipProgress { IsFinished = true, PercentDone = 100 });

            comp.BeginCompressFiles(archive, files);
        }
    }
}
