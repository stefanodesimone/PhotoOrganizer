using PhotoOrganizer_ConsoleApp;

namespace PhotoOrganizer.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] image = System.IO.File.ReadAllBytes(Environment.CurrentDirectory +"/test/t1.jpg");
            var intpuData = new MLModelPhoto.ModelInput()
            {
                ImageSource = image
            };

            // Load model and predict output of sample data
            var result = MLModelPhoto.Predict(intpuData);
            var predictedLabel = result.PredictedLabel;
            var score = result.Score[0] * 100;
            Console.WriteLine($"#############################################");
            Console.WriteLine($"should be : {predictedLabel}, score {score}%");
            Console.WriteLine($"#############################################");
        }
    }
}
