using System;
using System.Collections.Generic;
using System.IO;

using libApplication.app;
using libApplication.arg;
using libApplication.io;
using libApplication.optarg;

namespace MusicExtractor
{
internal class Program
    {
    private static AppConfig config = new AppConfig
        {
        logger             = new ConsoleLogger(),
        description        = "Copy music archive and extract AI information.",
        forward_exceptions = false,
        };

    private static DirectoryPath output_directory_path = new DirectoryPath();
    private static DirectoryList input_directory_list  = new DirectoryList();

    private static List<ArgEntry> arg_entry_list = new List<ArgEntry>
        {
            new ArgEntry('i', "input-dir",  ArgType.REQUIRED_ARGUMENT, true, input_directory_list,  null, "Input directory for music files."),
            new ArgEntry('o', "output-dir", ArgType.REQUIRED_ARGUMENT, true, output_directory_path, null, "Output directory for extracted files."),
        };

    static void Main( string[] args )
        {
        Console.WriteLine("MusicExtractor!");
        var application = new MusicExtractor();
        application.run(args, arg_entry_list, config);
        }
    }
}
