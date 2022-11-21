using Microsoft.ML;
using MLHousePrice.BLL;
using MLHousePrice.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLHousePrice.DAL
{
    public class Dal_HouseData : IHouseData
    {
        public float HouseMLModel(HouseData houseData)
        {
           
            MLContext mlContext = new MLContext(seed: 0);
            
            IDataView trainingData = mlContext.Data.LoadFromTextFile<HouseData>("D:\\MLHousePrice\\Book1.csv", separatorChar: ',', hasHeader: false);
            
            var pipeline = mlContext.Transforms.Text.FeaturizeText("RoofStyle")
                .Append(mlContext.Transforms.Concatenate("Features", new[] { "Size", "YearBuilt", "RoofStyle" }))
                .Append(mlContext.Regression.Trainers.Sdca(labelColumnName: "Label", maximumNumberOfIterations: 100));

            // 3. Train model
            var model = pipeline.Fit(trainingData);

            // 4. Make a prediction
            var size = new HouseData() { Size = houseData.Size, YearBuilt = houseData.YearBuilt, RoofStyle = houseData.RoofStyle };
            var price = mlContext.Model.CreatePredictionEngine<HouseData, PredictionPrice>(model).Predict(size);
            return price.Price;

        }
    }
}
