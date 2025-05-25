using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");
Nokia nokia = new(numero:"9959883181",modelo:"Modelo 1",imei:"4390742",memoria:12);
nokia.InstalarAplicativo("YouTube");
nokia.AboutPhone();
Console.WriteLine("------------------------------------------------------------------------------------------------");
Console.WriteLine("iphone:");
Iphone iphone = new(numero:"963494991",modelo: "Modelo X",imei: "432434",memoria: 10);
iphone.InstalarAplicativo("Twitter");
iphone.AboutPhone();