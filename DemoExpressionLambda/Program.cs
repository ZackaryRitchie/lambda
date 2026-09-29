using DemoExpressionLambda;

// Passer un comportement en paramètre à une fonction : Callback 
static bool EstPair(int x)
{
    return x % 2 == 0;
}

List<int> nombres = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

// Les types délégués génériques Func et Action : une variable qui va contenir une fonction.
 /*
Func<int, bool> fctEstPair = EstPair;
Action<string> afficher = Console.WriteLine;
afficher("Je prends la fonction de writelines");
 */
// Lambda 
Func<int, bool> fctEstPair = x => x % 2 == 0;


// Expression lambda en Callback (retour à FindAll)


List<int> nbPaire = nombres.FindAll(EstPair);

foreach (int x in nbPaire)
{
    Console.WriteLine(x);
}

Func<int, int, int> addition = (a,b) => a + b;  

// LINQ et expressions lambda


// Exercice

List<Client> clients = new()
{
    new Client { Id = 1, Prenom = "Léo", Ville = "Québec" },
    new Client { Id = 2, Prenom = "Wilona",   Ville = "Montréal" },
    new Client { Id = 3, Prenom = "Rohan",  Ville = "Gatineau" },
    new Client { Id = 4, Prenom = "Luca", Ville = "Ottawa" },
    new Client { Id = 5, Prenom = "Julien",  Ville = "Montréal" },
    new Client { Id = 6, Prenom = "Junior",     Ville = "Sherbrooke" },
    new Client { Id = 7, Prenom = "Jonathan",Ville = "Gatineau" },
    new Client { Id = 8, Prenom = "Kevin",   Ville = "Montréal" }
};

// q1
List<Client> clientGatineau= clients.Where(c =>c.Ville == "Gatineau").ToList();


//3
Func<List<Client>, bool> clientQuebec = x => x.Exists(c => c.Ville == "Québec");
Console.WriteLine(clientQuebec(clients));

//q2
Func<List<Client>, string> listPrenom = x => x.Select(c => c.Prenom).ToString();
Console.WriteLine(listPrenom(clients));

