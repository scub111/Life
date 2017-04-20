using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Life
{

    /// <summary>
    /// Класс для создания сводных диаграмм.
    /// </summary>
    public class RecordSum : IComparable<RecordSum>
    {
        public RecordSum(string name, double sum)
        {
            Name = name;
            Sum = sum;
        }
        /// <summary>
        /// Название записи.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Сумма.
        /// </summary>
        public double Sum { get; set; }

        public int CompareTo(RecordSum other)
        {
            return Sum.CompareTo(other.Sum);
        }

        public static void GenerateTableSum<tableType>(List<RecordSum> recordSum, XPCollection xpCollection, string fieldNameCollection, string typeID, string typeCaption)
        {
            recordSum.Clear();
            XPCollection<tableType> costTypes = new XPCollection<tableType>();

            foreach (tableType costType in costTypes)
            {
                xpCollection.Filter = CriteriaOperator.Parse(string.Format("[{0}] == ?", typeID), costType);

                double costSum = 0;
                foreach (object costCollection in xpCollection)
                    costSum += (double)costCollection.GetType().GetProperty(fieldNameCollection).GetValue(costCollection, null);
                if (costSum > 0)
                    recordSum.Add(new RecordSum((string)typeof(tableType).GetProperty(typeCaption).GetValue(costType, null), costSum));
            }

            xpCollection.Filter = CriteriaOperator.Parse("");
        }
    }
}
