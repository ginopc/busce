# BusCE: Receive files from Microsoft Windows CE PdAs

<a href="http://www.ginopc.it">Author WebSite</a>

**BusCE** is a Microsoft Windows app developed in C#. It is a tool for receive files from a WinCE PdA (Portable Digital Assistant) like a Motorola Symbol terminal.
You can start BusCE either with or without parameters. First option is also known as <i>Ghost Mode</i>, second option is knows as <i>GUI Mode</i>.


## GUI Mode
In questo caso viene aperta l'interfaccia Windows dove è possibile inserire i valori per i parametri
e avviare la ricezione dei file.

## Ghost Mode
In questo caso non viene mostrata nessuna interfaccia visuale e l'applicazione esegue la ricezione
senza la necessità di internvento da parte dell'utente.
Questa modalità può essere utile come modulo di un altra applicazione.


** Parametri Applicazione **
-lp	Local Path    : è il percorso dove verranno salvati i file ricevuti dal terminale
-rp	Remote Path   : percorso sul terminalino dove devono essere cercati i file
-rf	Remote Filter : filtro di ricerca dei file

Nel nostro caso si chiamera' l'applicazione con:

BusCE.exe -lp=c:\scs\ordini -rp=\ -rf=ord*.txt
