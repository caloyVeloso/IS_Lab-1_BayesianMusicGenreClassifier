# IS_Lab-1_BayesianMusicGenreClassifier

# Bayesian Music Genre Classifier

## Overview

This is a simple console program that uses Bayesian inference to classify music genres based on a provided dataset. The program assumes two genres, "Pop" and "Rock," and calculates the probability of each genre using a Bernoulli distribution. The genre with the higher probability is predicted as the most likely genre for a given dataset.

## Dependencies

This program uses the `Microsoft.ML.Probabilistic` library for Bayesian inference. Make sure to install the necessary dependencies before running the program.

**View the predicted music genre based on the provided dataset.**

## Dataset

The program uses a sample dataset of music genres, where each entry is labeled as either "Pop" or "Rock." You can customize the dataset in the `musicGenres` list within the code.

```csharp
List<string> musicGenres = new List<string>
{
    "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop", "Pop",
    "Rock", "Rock", "Rock", "Rock", "Rock", "Rock", "Rock"
};
```

## Results
 The program prints the probabilities of the genres "Pop" and "Rock" based on the dataset, as well as the predicted music genre with the higher probability.

    Pop: 0.7
    Rock: 0.3
    Predicted Music Genre: Pop
