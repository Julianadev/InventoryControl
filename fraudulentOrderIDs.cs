string [] fraudulentOrderIDs = {"A123", "B456" ,"C789"};

Console.WriteLine($"Primeiro: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Segundo: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Terceiro: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F001";

Console.WriteLine($"Valor reatribuído primeira ordem: {fraudulentOrderIDs[0]}");

Console.WriteLine($"Existem {fraudulentOrderIDs.Length} ordens para serem processadas!");