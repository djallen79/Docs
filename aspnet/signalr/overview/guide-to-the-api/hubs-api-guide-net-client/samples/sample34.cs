var hubConnection = new HubConnection("http://www.contoso.com/");
hubConnection.TraceLevel = TraceLevels.All;
hubConnection.TraceWriter = Console.Out;
IHubProxy stockTickerHubProxy = hubConnection.CreateHubProxy("StockTickerHub");
stockTickerHubProxy.On<Stock>("UpdateStockPrice", stock => Console.WriteLine("Stock update for {0} new price {1}", stock.Symbol, stock.Price));
await hubConnection.Start();