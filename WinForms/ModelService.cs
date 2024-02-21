using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondoDBtest
{
    public class ModelService
    {     
        public ModelService(decimal sqmetr)
        {
            IndividualUsageVolume = sqmetr;
        }
        public ModelService() { }
         
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        public string ServiceName { get; set; }
        public string UnitOfMeasurement { get; set; } // единица измерения
        public decimal IndividualUsageVolume { get; set; } // потребление
        public decimal tariff { get; set; } // тариф



        private decimal _totalChargedForThePeriod;
        public decimal TotalChargedForThePeriod // начислено
        {
            get => Math.Round(tariff * IndividualUsageVolume,2);

        }
        private decimal _totalRecalculations;
        public decimal TotalRecalculations // пересчеты
        {
            get; set;
        }

        private decimal _benefitsAndSubsidies;
        public decimal BenefitsAndSubsidies //льготы
        {
            get; set;
        }

        public decimal DebtPast { get; set; } // задолжность за пред. период 

        public decimal Paid { get; set; } // оплачено 

        public decimal Debt // задолженность на текущ. период 
        {
            get => Math.Round(TotalChargedForThePeriod + TotalRecalculations + BenefitsAndSubsidies - Paid + DebtPast,2);
        }

    }
}
