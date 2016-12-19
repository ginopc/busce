# BusCE: Receive files from Microsoft Windows CE PdAs

<a href="http://www.ginopc.it">Author WebSite</a>

**BusCE** is a Microsoft Windows app developed in C#. It is a tool for receive files from a WinCE PdA (Portable Digital Assistant) like a Motorola Symbol terminal.
You can start BusCE either with or without parameters. First option is also known as <i>Ghost Mode</i>, second option is knows as <i>GUI Mode</i>.


## GUI Mode
Without start parameters the application shows his graphical interface. You can insert values on fields and starts file reception.

## Ghost Mode
It's a start without parameters. On this case the graphical interface is not shown. The application execute data transfer without need of user interaction.
This mode can be used as a module from another application.

## Command Line Parameters
-lp	Local Path    : path where the files receiced from PdA are saved
-rp	Remote Path   : path on PdA where source files are searched
-rf	Remote Filter : file's search filter

Follows an exemple of Ghost Mode:
```html
BusCE.exe -lp=c:\scs\ordini -rp=\ -rf=ord*.txt
