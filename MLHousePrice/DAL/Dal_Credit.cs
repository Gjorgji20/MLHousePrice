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
    internal class Dal_Credit : ICredit
    {
        public float CreditMLModel(float Cena)
        {
            MLContext mlContext = new MLContext(seed: 0);


            IDataView trainingData = mlContext.Data.LoadFromTextFile<Credit>("D:\\MLHousePrice\\finallycon.csv", separatorChar: ',', hasHeader: false);
           
            var pipeline = mlContext.Transforms.Text.FeaturizeText("Status").Append(mlContext.Transforms.Text.FeaturizeText("FamilyStatus"))
                .Append(mlContext.Transforms.Concatenate("Features", new[] { "Amount", "Duration"}))
                .Append(mlContext.Regression.Trainers.Sdca(labelColumnName: "Installment", maximumNumberOfIterations: 100));

            // 3. Train model
            var model = pipeline.Fit(trainingData);

            // 4. Make a prediction
            var size = new Credit() { Amount = Cena, Duration=10 };
            var rata = mlContext.Model.CreatePredictionEngine<Credit, PredictionInstallment>(model).Predict(size);
            return rata.Installment;
        }
    }
}
