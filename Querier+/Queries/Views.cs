using System;
using System.Collections.Generic;
using System.Text;

namespace WeMicroIt.Utils.QuerierPlus.Queries
{
    public static class Views
    {
        public static string AddStringView(string OriginalTable, string GroupField, string Value)
        {
            return $"CREATE OR REPLACE VIEW {OriginalTable}Stats AS " +
                    $"SELECT t.{GroupField} as RecordId, " +
                        $"Count(t.Id) as Count, " +
                        $"Count(Distinct(t.{Value})) as UniqueValue, " +
                        $"Count(t.{Value} IS NULL) as NullValue, " +
                        $"Count(t.{Value} IS NOT NULL) as NotNullValue " +
                    $"from {OriginalTable}s t " +
                    $"GROUP BY t.{GroupField}";
        }

        public static string AddDateView(string OriginalTable, string GroupField, string Value)
        {
            return $"CREATE OR REPLACE VIEW {OriginalTable}Stats AS " +
                    $"SELECT t.{GroupField} as RecordId, " +
                        $"Count(t.Id) as Count, " +
                        $"Count(Distinct(t.{Value})) as UniqueValue, " +
                        $"Count(t.{Value} IS NULL) as NullValue, " +
                        $"Count(t.{Value} IS NOT NULL) as NotNullValue, " +
                        $"Min(t.{Value}) as Min, " +
                        $"Max(t.{Value}) as Max " +
                    $"from {OriginalTable}s t " +
                    $"GROUP BY t.{GroupField}";
        }

        public static string AddNumericView(string OriginalTable, string GroupField, string Value)
        {
            return $"CREATE OR REPLACE VIEW {OriginalTable}Stats AS " +
                    $"SELECT t.{GroupField} as RecordId, " +
                        $"Count(t.Id) as Count, " +
                        $"Count(Distinct(t.{Value})) as UniqueValue, " +
                        $"Count(t.{Value} IS NULL) as NullValue, " +
                        $"Count(t.{Value} IS NOT NULL) as NotNullValue, " +
                        $"Min(t.{Value}) as Min, " +
                        $"Max(t.{Value}) as Max," +
                        $"Avg(t.{Value}) as Avg, " +
                        $"Sum(t.{Value}) as Sum" +
                    $"from {OriginalTable}s t " +
                    $"GROUP BY t.{GroupField}";
        }

        public static string DeleteView(string Name)
        {
            return $"DROP VIEW IF EXISTS {Name}Stats";
        }
    }
}
