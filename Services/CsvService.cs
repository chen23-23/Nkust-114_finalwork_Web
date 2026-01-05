using AgingIndexWeb.Models;

namespace AgingIndexWeb.Services
{
    public class CsvService
    {
        private readonly string _csvPath;

        public CsvService(IWebHostEnvironment env)
        {
            _csvPath = Path.Combine(env.ContentRootPath, "Data", "主要國家老化指數.csv");
        }

        public List<AgingIndexData> LoadData()
        {
            var dataList = new List<AgingIndexData>();

            if (!File.Exists(_csvPath))
            {
                return dataList;
            }

            var lines = File.ReadAllLines(_csvPath);

            // Skip header (Row 0)
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;

                var values = line.Split(',');

                if (values.Length >= 5)
                {
                    // Assuming columns: 國別,西元年,民國年,類別,老化指數,...
                     try
                    {
                        var data = new AgingIndexData
                        {
                            Country = values[0].Trim(),
                            Year = int.Parse(values[1].Trim()),
                            RepublicYear = int.Parse(values[2].Trim()),
                            Category = values[3].Trim(),
                            AgingIndex = double.Parse(values[4].Trim())
                        };
                        dataList.Add(data);
                    }
                    catch
                    {
                        // Skip invalid rows
                        continue;
                    }
                }
            }

            return dataList;
        }
    }
}
