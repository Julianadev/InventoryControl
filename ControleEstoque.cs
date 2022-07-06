int[] estoque = {200,700,150,900,175,43,75,210};
int soma = 0;
int bin = 0;
foreach(int items in estoque){
    soma += items;
    bin ++;
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine($"Bin {bin} = {items} itens\t\t(Estoque Total:{soma})");
}
Console.WriteLine($"\n\nVocê tem {soma} itens no estoque");