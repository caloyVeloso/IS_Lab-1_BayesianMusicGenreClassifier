using System;
using Microsoft.ML.Probabilistic;
using Microsoft.ML.Probabilistic.Models;
using Microsoft.ML.Probabilistic.Distributions;

class Program
{
    static void Main(string[] args)
    {
        List<string> musicGenres = new List<string>
        {
            "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop",
            "Rock", "Rock", "Rock", "Rock", "Rock", "Rock", "Rock"
        };

        float pop = 0;
        float rock = 0;
        foreach (string music in musicGenres)
        {
            if (music == "Pop")
                pop++;
            else
                rock++;
        }

        pop = pop / musicGenres.Count;
        rock = rock / musicGenres.Count;

        Console.WriteLine("Pop: " + pop);
        Console.WriteLine("Rock: " + rock);

        // Define the Bayesian network structure
        Variable<bool> isPop = Variable.Bernoulli(pop);
        Variable<bool> isRock = Variable.Bernoulli(rock);

        // Create an inference engine
        InferenceEngine engine = new InferenceEngine();

        // Perform inference to classify the genre
        Bernoulli probabilityIsPop = engine.Infer<Bernoulli>(isPop);
        Bernoulli probabilityIsRock = engine.Infer<Bernoulli>(isRock);

        // Determine the most likely genre
        double probabilityPop = probabilityIsPop.GetProbTrue();
        double probabilityRock = probabilityIsRock.GetProbTrue();

        string genre = (probabilityPop > probabilityRock) ? "Pop" : "Rock";

        Console.WriteLine("Predicted Music Genre: " + genre);
    }
}
