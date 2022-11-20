using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using MLHousePrice.BLL;
using MLHousePrice.Interfaces;

namespace MLHousePrice.DAL
{
    public class Dal_UserGoal : IUserGoal
    {
        public bool UserGoalMLModel(string goal)
        {
            MLContext mlContext = new MLContext(seed: 0);

            SentimentData[] sentimentDatas = new SentimentData[]
            {
                new SentimentData{ SentimentText="i want to buy",Sentiment=true },

                new SentimentData{ SentimentText="buy",Sentiment=true },

                new SentimentData{ SentimentText="buy buy",Sentiment=true },

                new SentimentData{ SentimentText="i dont want to buy",Sentiment=false },
                new SentimentData{ SentimentText="not buy",Sentiment=false },
                new SentimentData{ SentimentText="deny buy",Sentiment=false }
            };

            IDataView trainingData = mlContext.Data.LoadFromEnumerable(sentimentDatas);

            var pipeline = mlContext.Transforms.Text.FeaturizeText(outputColumnName: "Features", inputColumnName: nameof(SentimentData.SentimentText))
                .Append(mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(labelColumnName: "Label", featureColumnName: "Features"));
            // 3. Train model
            var model = pipeline.Fit(trainingData);

            // 4. Make a prediction
            var size = new SentimentData() { SentimentText=goal};
            var price = mlContext.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(model).Predict(size);
            return price.Prediction;
        }
    }
}
