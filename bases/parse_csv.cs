using appiumtest.testcase;
using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace appiumtest.bases
{
    public class ParseCsv
    {
        // 读取CSV文件并返回数据列表
        public static List<TestData> ReadTestDataFromCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<TestData>().ToList();
            }
        }
    }
}