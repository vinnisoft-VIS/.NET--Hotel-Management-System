using System.Collections.Generic;

namespace DataViewModel
{
    public class MonthlyStarReport
    {
        public string Month { get; set; }
        public MonthlyPerformanceMeta CurrentMonth { get; set; }
        public MonthlyPerformanceMeta YearToDate { get; set; }
        public MonthlyPerformanceMeta Running3Month { get; set; }
        public MonthlyPerformanceMeta Running12Month { get; set; }
    }

    public class MonthlyStarReportFlat
    {
        public string Measure { get; set; }
        public string CurrentMonth { get; set; }
        public string YearToDate { get; set; }
        public string Running3Month { get; set; }
        public string Running12Month { get; set; }
    }

    public class MonthlyPerformanceMeta
    {
        public string Occupancy { get; set; }
        public string Adr { get; set; }
        public string RevPar { get; set; }
    }

    public class WeeklyStarReport
    {
        public string DateRange { get; set; }
        public List<TrendDataSet> Occupancy { get; set; }
        public List<TrendDataSet> Adr { get; set; }
        public List<TrendDataSet> RevPar { get; set; }
    }

    public class TrendDataSet
    {
        public string PerformanceMeasure { get; set; }
        public string PerformanceMeta { get; set; }
    }

    public class DailyPerformanceMeta
    {
        public decimal Performance { get; set; }
        public decimal PerformanceChange { get; set; }
    }

    public class MonthlyStarPerformanceTrend
    {
        public string Month { get; set; }
        public List<TrendDataSet> Occupancy { get; set; }
        public List<TrendDataSet> Adr { get; set; }
        public List<TrendDataSet> RevPar { get; set; }
    }

    public class DailyRevenue
    {
        public string Day { get; set; }
        public string Month { get; set; }
        public List<RevenueCategory> Categories { get; set; }
        public List<int> SoldRooms { get; set; }
        public List<decimal> Revenue { get; set; }
        public List<decimal> Occupancy { get; set; }
        public List<decimal> Arr { get; set; }
        public decimal TotalRevenue { get; set; }
    }

    public class RevenueCategory
    {
        public string TransactionCode { get; set; }
        public string Description { get; set; }
        public string LineNo { get; set; }
        public string LineDescription { get; set; }
        public int CategoryMappingId { get; set; }
    }

    public class DailyRevenueByProperty
    {
        public string Property { get; set; }
        public DailyRevenue DailyRevenue { get; set; }
    }

    public class MonthlyRevenueReportByDay
    {
        public string Property { get; set; }
        public int Rooms { get; set; }
        public decimal Revenue { get; set; }
        public string Day { get; set; }
        public decimal Occupancy { get; set; }

    }
}
