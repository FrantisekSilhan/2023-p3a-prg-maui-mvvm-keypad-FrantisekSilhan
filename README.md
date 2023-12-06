# Test na MVVM v prost�ed� MAUI

Vytvo�te fiktivn� aplikaci pro zad�v�n� ��seln�ho k�du. P�edm�tem testu je p�ipojen� ViewModelu ke str�nce, bindov�n� komponent, pou�it� command� s parametrem a podm�nkou.

## Screenshoty

![Po��te�n� stav](screenshots/01.png)

![Po p�r znac�ch](screenshots/02.png)

![�est znak�](screenshots/03.png)

![Nespr�vn� k�d](screenshots/04.png)

![Spr�vn� k�d](screenshots/05.png)

## Chov�n� aplikace

* ��slice 
	* Jsou aktivn� pokud nem� k�d d�lku 6 znak� a stav aplikace je InProgress
	* P�id�vaj� nov� znak na konec k�du
* Back 
	* Odmaz�v� posledn� znak 
	* Je aktivn�, pokud je v k�du alespo� jeden znak a stav aplikace je InProgress
* OK 
	* Vyhodnocuje zadan� k�d a podle toho nastavuje vlastnost State
	* Je aktivn� pro v�ce ne� dva znaky a stav aplikace je InProgress
* Storno 
	* Resetuje stav aplikace - tedy k�d i stav
	* Je aktivn� v�dy
* Bindovateln� vlastnosti
	* Aplikace m� dv�: Code a State

## Zad�n�

* ViewModel
	* 2 Bindovateln� vlastnosti
	* 4 Commandy
* Prov�zat vlastnosti a Commandy tak, aby se v�e zobrazovalo spr�vn�
* P�ipojit ViewModel do str�nky
* Converter pro p�evod mezi stavem aplikace a barvou Frame pod k�dem

## Fragmenty k�du

	Code = Code.Remove(Code.Length - 1, 1);

