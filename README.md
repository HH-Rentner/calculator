# calculator
Taschenrechner mit grafischer Oberfläche (winforms-app)
Regeln bei der Bedienung dieser Anwendung:
1. Alternativ zur "Click-Eingabe" kann teilweise auch eine Eingabe per Tastatur erfolgen. 
  Folgende Möglichkeiten bestehen zurzeit:
 1.1 Ziffern "0-9"
 1.2 Eingabe eine Zahl in Exponenten-Darstellung. Dabei ist folgendes zu beachten:
   • zuerst wird die Basis eingegeben.
   • danach wird ein "e" und der Exponent eingegeben.
   • Danach kann das Vorzeichen des Exponenten bei Bedarf per Button_click [+-] gewechselt werden.
 1.3 "+"	schließt die Zifferneingabe zur ersten Zahl ab und speichert die Rechenart.
 1.4 "-"	schließt die Zifferneingabe zur ersten Zahl ab und speichert die Rechenart.
 1.5 "/" oder ":"   schließt die Zifferneingabe zur ersten Zahl ab und speichert die Rechenart.
 1.6 "*"	schließt die Zifferneingabe zur ersten Zahl ab und speichert die Rechenart.
 1.7 "="	schließt die Zifferneingabe zur zweiten Zahl ab und die Berechnung wird durchgeführt.
 1.8 "Backspace"	     löscht das letzte Zeichen in der Anzeige.
 1.9 "=" oder "Enter"  schließt die Zifferneingabe zur zweiten Zahl ab und die Berechnung wird durchgeführt.

2 "Fast" alle Eingaben können per Button_click erfolgen! Die einzige Ausnahme sind "Potenz-Zahlen"(siehe 1.2).
 2.1 Mit [0]-[9] und [,] können die gewünschten Zahlen eingegeben werden.
 2.2 [+-] Mit diesem "Click" kann das Vorzeichen nach Eingabe der gewünschten Zahl erfolgen. 
 2.3 [+]           schließt die Zifferneingabe zur ersten Zahl ab und speichert die Rechenart.
 2.4 [-]           schließt die Zifferneingabe zur ersten Zahl ab und speichert die Rechenart.
 2.5 [/]           schließt die Zifferneingabe zur ersten Zahl ab und speichert die Rechenart.
 2.6 [*]           schließt die Zifferneingabe zur ersten Zahl ab und speichert die Rechenart.
 2.7 [=]           schließt die Zifferneingabe zur zweiten Zahl ab und die Berechnung wird durchgeführt.
 2.8 [X2] kann jederzeit angewendet werden. Die weitere Berechnung wird davon nicht beeinflußt.
 2.9 [Wurzel] kann jederzeit angewendet werden. Die weitere Berechnung wird davon nicht beeinflußt.
 2.10 [+-] kann jederzeit angewendet werden. Die weitere Berechnung wird davon nicht beeinflußt.
 2.11 [1/X] kann jederzeit angewendet werden. Die weitere Berechnung wird davon nicht beeinflußt.
 2.12 [%] Zuerst die 1.Zahl eingeben. Danach die Rechenart und die 2.Zahl und die Prozentzuordnung.
          Beispiel 1: [1][0][0][*][2][%] ergibt 2.
          Beispiel 2: [1][0][0][+][2][%] ergibt 102.
          Beispiel 3: [1][0][0][-][2][%] ergibt 98.
	      Mit dem Ergebnis kann weitergerechnet werden.
		   2.8 [X2] kann jederzeit angewendet werden. Die weitere Berechnung wird davon nicht beeinflußt.
 2.13 [->] löscht das letzte Zeichen in der Anzeige.
 2.14 [CE] löscht die Eingabe der aktuellen Zahl. Es kann mit den vorherigen Eingaben weitergerechnet werden.
 2.15 [C] löscht alle Eingaben. Normiert den Recher.
 
3. Die Berechnung muss nicht nach der Eingabe von 2 Zahlen mit [=] abgeschlossen werden.
   Es können mehrere Zahlen in einem Rechengang berechnet werden. 
   Dabei können die Rechenarten während des Rechenvorgangs gewechselt werden.
   Die Zahlen werden berechnet wie sie "reinkommen". Eine Beachtung Punkt- vor Strichrechnung findet also nicht statt. 
   Dazu müsste die Eingabe gespeichert werden, damit sie analysiert werden kann. 
   Erst dann könnte der Rechenvorgang entsprechend der Prioritäten durchgeführt werden.

4. Abschluss einer Berechnung mit[=]
Wird [=] eingeben, wird die Berechnung abgeschlossen und das Ergebnis wird ausgegeben.
Mögliche Aktionen nachdem eine Berechnung mit [=] abgeschlossen wurde:
a. Eingabe ([+], [-], [*] oder [/]) und einer Zahl usw. 
   Folge: Es wird mit dem Ergebnis der vorher abgeschlossenen Berechnung weitergerechnet.
   Erfolgt direkt nach der Berechnung die Eingabe einer Rechenart, muss noch eine neue zweite Zahl eingegeben werden.
b. Eingabe [X2], [Wurzel], [+-] oder [1/X] 
   Folge: Es wird mit dem Ergebnis der vorher abgeschlossenen Berechnung weitergerechnet.
   Danach kann mit ([+], [-], [*] oder [/]), einer Zahl usw. weitergerechnet werden.
   Wird jetzt [=] betätigt, wird mit dem vorhandenen Ergebnis, der neuen Rechenart und der neuen 2.Zahl weitergerechnet.
b. Eingabe [%]
   Ein Weiterrechnen mit dem Ergebnis wird verweigert. Man bekommt eine Nachricht was zu tun ist.
c. Eingabe einer Zahl, ([+], [-], [*] oder [/]), einer weiteren Zahl und [=]
   Erfolgt direkt nach der Berechnung die Eingabe einer Zahl und einer Rechart, wird damit eine neue Berechnung eingeleitet.
   Folge: Das alte Ergebnis wird verworfen und eine neue Berechnung gestartet. Genauso als ob [C] betätigt wurde.
   Es muss also noch eine 2.Zahl eingegeben werden. Das Ergebnis der letzten Berechnung spielt in diesem Fall keine Rolle mehr.
