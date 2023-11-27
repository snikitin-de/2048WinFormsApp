namespace _2048WinFormsApp
{
    public class FileProvider
    {
        private string filepath;

        public FileProvider(string filename)
        {
            filepath = filename;
        }

        public void Save(string data)
        {
            using (StreamWriter writer = new StreamWriter(filepath, false))
            {
                writer.WriteLine(data);
            }
        }

        public string Read()
        {
            string? lines = string.Empty;

            using (StreamReader reader = new StreamReader(filepath))
            {
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    lines += line;
                }
            }

            return lines;
        }
    }
}
