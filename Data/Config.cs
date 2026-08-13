using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas_Pedidos.Data
{

        public static class AppConfig
        {
            public static IConfiguration Configuration { get; private set; }

            public static void Initialize()
            {
                Configuration = new ConfigurationBuilder()
                    .AddJsonFile("appconfig.json")
                    .Build();
            }

            public static string ConnectionString =>
                Configuration.GetConnectionString("ConexaoOracle");

            public static string PrinterLabel =>
                Configuration["Printers:PrinterLabel"];
            public static string PrinterInvoice =>
                Configuration["Printers:PrinterInvoice"];
    }
    }

