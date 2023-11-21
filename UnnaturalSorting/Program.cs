Random random = new Random();

Console.WriteLine("Lista di interi random con ordine personalizzato in base alla lunghezza dei caratteri:\n");

Enumerable.Range(1, 1000).Select(numeriCasuali => random.Next(1000)).OrderBy(numeriOrdinati => numeriOrdinati.ToString().Length).ToList().ForEach(numero => Console.WriteLine(numero));

