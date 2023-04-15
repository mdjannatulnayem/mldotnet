using Mldotnet_one_o_one;

Console.Write("Write your review here >>>>\t ");
var input = Console.ReadLine();

if (input is null) 
    return;

// Add input data
var sampleData = new SentimentModel.ModelInput()
{
    Col0 = input.ToString(),
};

// Load model and predict output of sample data
var result = SentimentModel.Predict(sampleData);

// If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative"
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");