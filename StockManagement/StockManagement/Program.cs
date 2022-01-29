// See https://aka.ms/new-console-template for more information
using StockManagement;

const string STOCK_JSON = @"C:\Users\dell\source\repos\StockManagement\StockManagement\StockManagement\StockManagement\Stock.json";
StockManager stockmanager = new StockManager();
stockmanager.StockDataReport(STOCK_JSON);
