# GestioneAlbergo
Diego Smacchia
Matricola 294374
titolo del progetto: Gestione Albergo
Specifica del progetto:
Il progetto consiste nella simulazione della gestione di un albergo, composto da tre diverse tipologie di stanze:
-le camere standard;
-le camere superior;
-le suite.
Ogni stanza differisce dalle altre per il prezzo per notte e per i servizi disponibili per i clienti (un cliente sistemato in una suite avrà più servizi disponibili, ma la suite è più costosa delle altre stanze).
I clienti che frequentano l’albergo sono di due tipi: normali e viziati: i clienti normali hanno ogni giorno la possibilità del 40% di voler usufruire di un servizio mentre i clienti viziati hanno una possibilità del 100%, e un cliente ogni 5 è viziato.
L’albergo è composto da 18 stanze (10 stanze normali, 5 superior e 3 suite), e i clienti che vogliono prendere una camera sono 22, i cui nomi vengono presi in input da un file di testo.
Ogni cliente dispone di un budget determinato casualmente, dai 350 ai 1500 euro, e vuole alloggiare in una stanza per un numero di giorni che va da 1 a 7.
All’arrivo ogni cliente contatta il gestore dell’albergo per provare a prenotare una stanza, e se ce n’è almeno una ancora libera (e il suo budget lo consente) riesce ad ottenere un posto nell’albergo.
Ogni cliente vuole alloggiare nella migliore tipologia di stanza che può permettersi, ma in caso di mancanza di posto si accontenterà anche delle altre.
Durante la permanenza nell’albergo ogni cliente si rilassa ogni giorno, e può richiedere un servizio dall’albergo e pagarlo.
I clienti che non sono riusciti a prendere una stanza continueranno a provare fino a quando non riescono a fare la loro vacanza, e il programma termina con la chiusura dell’albergo quando non c’è rimasto più nessun cliente da gestire.
