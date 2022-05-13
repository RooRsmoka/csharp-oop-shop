using csharp_oop_shop;
// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World!");
//Random myRandom = new Random();
//Console.WriteLine(myRandom.Next());


Prodotto prodottoOne = new Prodotto("Tastiera","Tastiera meccanica da gaming", 89.99, 0.22);

Console.WriteLine("Prodotto N°1: Nome: {0}, Descrizione: {1}, Codice: {2}, {3}, Prezzo di partenza: {4}, Prezzo con IVA: {5}", 
    prodottoOne.Nome, prodottoOne.Descrizione, prodottoOne.Codice, prodottoOne.GetNomeProdotto(), prodottoOne.GetPrezzoNonIvato(), prodottoOne.GetPrezzoIvato()); 