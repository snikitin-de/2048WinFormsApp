using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    internal class JsonSerializer
    {
        private string filepath;
        private FileProvider fileProvider;

        public JsonSerializer(string filename)
        {
            filepath = filename;
            fileProvider = new FileProvider(filename);
        }

        public void Add<T>(T data)
        {
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);

            fileProvider.Save(json);
        }

        public List<T> Read<T>()
        {
            if (File.Exists(filepath))
            {
                var json = fileProvider.Read();

                return JsonConvert.DeserializeObject<List<T>>(json);
            }

            return new List<T>();
        }
    }
}
