using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICSVService
{
   public IEnumerable<T> ReadCSV<T>(Stream file);
}

public class CSVService : ICSVService
{
    public IEnumerable<T> ReadCSV<T>(Stream file)
    {
        var reader = new StreamReader(file);
        var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        var records = csv.GetRecords<T>();
        return records;
    }
}