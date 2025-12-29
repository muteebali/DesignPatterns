using Behavioral.ChainOfResponsibility.Handlers;

Logger infoLogger = new InfoLogger();
infoLogger.SetNextLogger(new ErrorLogger());

//Will Call the Error Logger
infoLogger.HandleRequest(1);

Console.WriteLine("Chain of Responsibility Pattern Example\n");