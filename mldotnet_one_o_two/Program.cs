using Mldotnet_one_o_two;

//if (true) return 0;

//Load sample data
var sampleData = new TaxiFarePrediction.ModelInput()
{
    Vendor_id = @"CMT",
    Rate_code = 1F,
    Passenger_count = 6F,
    Trip_distance = 1.5F,
    Payment_type = @"CRD",
};

//Load model and predict output
var result = TaxiFarePrediction.Predict(sampleData);

Console.WriteLine($"Predicted fare amount :{result.Score}");