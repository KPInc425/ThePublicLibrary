using System;
using Langwish.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Langwish
{
    class Program
    {
        public static void Main(string[] args)
        {
            var startup = new Startup();
            
            var databaseService = startup.Provider.GetRequiredService<DatabaseService>();
            var scanService = startup.Provider.GetRequiredService<MapFileCreateService>();    
            var syncService = startup.Provider.GetRequiredService<SyncWithExcelService>();
            var resxWriteServices = startup.Provider.GetRequiredService<WriteExcelToResx>();
            

            databaseService.ClearData();
            scanService.ScanDir();
            syncService.SyncWithExcel();
            resxWriteServices.CreateResxFiles();
        }
    }
}