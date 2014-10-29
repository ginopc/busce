BusCE
=====

Applicazione di ricezione file da terminale con Windows CE
Puo' essere avviata sia senza parametri (GUI) che con parametri.

** Avvio senza parametri** 
In questo caso viene aperta l'interfaccia Windows dove è possibile inserire i valori per i parametri
e avviare la ricezione dei file.

** Avvio con parametri **
In questo caso non viene mostrata nessuna interfaccia visuale e l'applicazione esegue la ricezione
senza la necessità di internvento da parte dell'utente.
Questa modalità può essere utile come modulo di un altra applicazione.


** Parametri Applicazione **
-lp	Local Path    : è il percorso dove verranno salvati i file ricevuti dal terminale
-rp	Remote Path   : percorso sul terminalino dove devono essere cercati i file
-rf	Remote Filter : filtro di ricerca dei file

Nel nostro caso si chiamera' l'applicazione con:

BusCE.exe -lp=c:\scs\ordini -rp=\ -rf=ord*.txt