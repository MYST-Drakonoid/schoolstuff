using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// public string file = "binary letters.csv";

var configuration = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
    {
        HasHeaderRecord = false
    };



