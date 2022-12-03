/*
 Si vuole progettare un'applicazione in grado di gestire un'agenzia immobiliare. Gli immobili sono caratterizzati da:
un codice alfanumerico,
indirizzo,
cap,
città
una superficie espressa in mq attraverso un numero intero.
L'agenzia gestisce diverse tipologie di immobili:
Box
Abitazione
Ville.
Per i box è riportato il numero di posti auto. Per le abitazioni è riportato il numero di vani e il numero di bagni. Per le ville è previsto, in aggiunta rispetto all'abitazione,
la dimensione in mq di giardino.
Ridefinire per ciascuna delle tre classi il metodo ToString() in modo da fornire una descrizione completa dell'immobile.
*/


using Csharp_OOP_Agenzia_Immobiliare;

Immobile Test = new Immobile("123 SanFrancisco", 123, "SanFrancisco",12);
Box NewBox = new Box("123 SanFrancisco", 123, "SanFrancisco", 3, 12);
Test.StampaImmobile();
Test.StampaImmobile();
Test.StampaImmobile();
Test.StampaImmobile();
Test.StampaImmobile();
Console.WriteLine(NewBox);

NewBox.StampaImmobile();