# Projekt-Dokumentation


Stefan Jesenko

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.08.2022| 0.0.1|Heute habe ich zum ersten Mal an diesem Projekt gearbeitet, ich habe heute den ersten Teil der Projektdokumentation geschrieben und ein PAP zum RNG Spiel gemacht.|
| 30.08.2022|0.0.2|Heute habe ich meinen random number Generator Fertig geschrieben und alle User storys bis 5 umgesetzt.|
| 06.09.2022|0.0.3|Heute habe ich neue User Storys hinzugefügt und diese abgeschlossen, mein random number Generator ist jetzt Fertig.|
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

ich mache einen Random Number Generator, bei dem der Benutzer eine Zahl zwischen 1 und 100 erraten muss.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |muss             |Funktional|Als User möchte ich eine Zahl zwischen 1 und 100 eingeben können, damit das Spiel für mich spielbar ist.|
| 2    |muss             |Funktional|Als User möchte ich, dass eine zufällige Zahl generiert werden kann, damit das Spiel funktionieren kann.|
| 3    |muss             |Funktional|Als User möchte ich das überprüft wird ob meine eingegebene Zahl mit der zufälligen Zahl übereinstimmt, damit ich erfahre, ob ich gewonnen habe.|
| 4    |muss             |Funktional|Als User möchte ich, dass mir das Spiel sagt, ob meine Zahl grösser oder kleiner als die zufällige Zahl ist, damit ich nicht 100-mal raten muss.|
| 5    | kann            | Qualität | Als User möchte ich, dass ich die Farbe des Textes ändern kann, damit das Spiel für mich schöner aussieht.|
| 6    | kann            | Qualität | Als User möchte ich, dass mir Angezeigt wird wie viele Versuche ich gebraucht habe.|
| 7    | kann            | Qualität | Als User möchte ich den Zahlenbereich in dem ich rate selber wehlen.|
| 8    | kann            | muss     | Als User möchte ich, dass wenn ich etwas anderes als eine Zahl in dem gewünschten Zahlenbereich eingebe dass eine Meldung kommt, dass ich eine neue Zahl eingeben soll.|
| 9    | kann            | Qualität| Als User möchte ich, dass ich am ende sehe, wie lange ich gebraucht habe.|
| 10   | kann            | Qualität| Als User möchte gefragt werde, ob ich noch einmal spielen will.|


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Applikation gestartet: warte auf User Eingabe|"Zahl"|"Bitte geben Sie eine Zahl von 1 bis 100 ein".|
| 1.2  |Applikation gestartet: warte auf User Eingabe|"200"|"Bitte geben Sie eine Zahl von 1 bis 100 ein.|
| 1.3  |Applikation gestartet: Warte auf User Eingabe.|"15" |" "|
| 2.1  |Applikation gestartet: Führt RNG aus.|" "|zufällige Zahl 1-100|
| 3.1  |zufällige Zahl und eingegebene Zahl sind bestimmt: Führt Zahlenvergleich aus.|"Zahlen Eingabe"| "Die Zahlen sind nicht gleich"|
| 3.2  | zufällige Zahl und eingegebene Zahl sind bestimmt: Führt Zahlenvergleich aus.|"Zahlen Eingabe"|"Die Zahlen sind gleich"|
| 4.1  |Applikation gestartet: Führt Zahlenvergleich aus.|"Zahlen Eingabe"|"Die Zahl ist zu gross."|
| 4.2  |Applikation gestartet: Führt Zahlenvergleich aus.|"Zahlen Eingabe"|"Die Zahl ist zu klein."|
| 5.1  |Applikation wurde gestartet|" "| Die Textfarbe sollte in einer anderen Farbe sein.|
| 6.1  |Applikation wurde durchgeführt|" "|"Sie haben 13 Versuche gebraucht."|
| 7.1  |Applikation gestartet, wartet auf Input.|"500"|"Geben Sie eine Zahl zwischen 1 - 500 ein: "|
| 8.1  |Applikation gestartet, wartet auf Input.|"Banane"|"Geben Sie eine Zahl ein: "|
| 8.2  |Applikation gestartet, wartet auf Input, Zahlenbereich ist 1 - 500|"1000"|"Geben Sie eine Zahl ein: "|
| 9.1  |Applikation durchgeführt|" "|"Sie haben 13 Sekunden gebraucht "|
| 10.1 |Applikation durchgeführt, wartet auf Eingabe|" "|"Wollen Sie weiter spielen (ja/nein)? "|
| 10.2 |Applikation durchgeführt|"ja"|"In welchem Zahlenbereich wollen Sie raten? "|
| 10.3 |Applikation durchgeführt|"nein"|Programmende|
| 10.4 |Applikation durchgeführt|"Banane"|"Wollen Sie weiter spielen (ja/nein)? "|

### 1.4 Diagramme
![PAPRNG3](https://user-images.githubusercontent.com/110892250/186109659-54723499-a508-4385-8ecd-bc080e7a66d7.png)





## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |30.08.2022|Stefan Jesenko|Eine zufällige Nummer zwischen 1 und 100 generieren.|30 min|
| 2.A  |30.08.2022|Stefan Jesenko|Der User kann eine Zahl eingeben.|30min|
| 3.A  |30.08.2022|Stefan Jesenko|Es wird geprüft, ob die eingegebene Zahl mit der zufälligen Zahl übereinstimmt.|1h|
| 4.A  |06.09.2022|Stefan Jesenko|Es wird mir gezeigt, ob die eingegebene Zahl grösser oder kleiner ist als die zufällige Zahl.|1h|
| 5.A  |06.09.2022|Stefan Jesenko|Die Farbe der Schrift kann geändert werden|3h|
| 6.A  |06.09.2022|Stefan Jesenko|Die Anzahl der Versuche anzeigen.|5 min|
| 7.A  |06.09.2022|Stefan Jesenko|Den Zahlenbereich wählen können.| 30min|
| 8.A  |06.09.2022|Stefan Jesenko|Falsche Eingaben fragen nach einer neuen Eingabe.|1h|
| 9.A  |06.09.2022|Stefan Jesenko|Es wird gemessen wie lange man braucht, um die Zahl zu erraten.|30min|
| 10.A |06.09.2022|Stefan Jesenko|Es wird gefragt, ob man noch einmal spielen will.|30min|

Total: 8



## 3 Entscheiden

Ich habe mich entschieden, dass ich als zusätzliche User story hinzufüge das ich den Text umfärben kann.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 30.08.2022|Stefan Jesenko| 30min|10min|
| 2.A  | 30.08.2022|Stefan Jesenko| 30min|5min |
| 3.A  | 30.08.2022|Stefan Jesenko| 1h   |30min|
| 4.A  | 30.08.2022|Stefan Jesenko| 1h   |30min|
| 5.A  | 30.08.2022|Stefan Jesenko| 3h   |10min|
| 6.A  | 06.09.2022|Stefan Jesenko| 5min |5min |
| 7.A  | 06.09.2022|Stefan Jesenko| 30min|20min|
| 8.A  | 06.09.2022|Stefan Jesenko| 1h   |40min|
| 9.A  | 06.09.2022|Stefan Jesenko| 30min|10min|
|10.A  | 06.09.2022|Stefan Jesenko| 30min|20min|



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |13.09.2022|"Schreiben Sie eine Zahl zwischen 1 und 100"|Stefan Jesenko|
| 1.2  |13.09.2022|"Geben Sie eine Zahl ein"|Stefan Jesenko|
| 1.3  |13.09.2022|Eingabe wird gespeichert|Stefan Jesenko|
| 2.1  |13.09.2022|Zufällige Zahl wird generiert|Stefan Jesenko|
| 3.1  |13.09.2022|Pogramm fährt weiter|Stefan Jesenko|
| 3.2  |13.09.2022|"Ihre Zahl ist richtig."|Stefan Jesenko|
| 4.1  |13.09.2022|"Ihre Zahl ist zu klein"|Stefan Jesenko|
| 4.2  |13.09.2022|"Ihre Zahl ist zu gross"|Stefan Jesenko|
| 5.1  |13.09.2022|Ausgabe hat eine andere Farbe|Stefan Jesenko|
| 6.1  |13.09.2022|"Sie haben 13 Versuche gebraucht"|Stefan Jesenko|
| 7.1  |13.09.2022|"Schreiben Sie eine Zahl zwischen 1 und 500"|Stefan Jesenko|
| 8.1  |13.09.2022|"Geben Sie eine Zahl ein"|Stefan Jesenko|
| 8.2  |13.09.2022|"Geben Sie eine Zahl ein"|Stefan Jesenko|
| 9.1  |13.09.2022|"Sie haben 13 Sekunden gebraucht"|Stefan Jesenko|
| 10.1 |13.09.2022|"Wollen Sie weiterspielen[ja/nein]|Stefan Jesenko|
| 10.2 |13.09.2022|"In welchem Zahlenbereich wollen Sie raten?"|Stefan Jesenko|
| 10.3 |13.09.2022|Programmende|Stefan Jesenko|
| 10.4 |13.09.2022|"Wollen Sie weiterspielen[ja/nein]|Stefan Jesenko|
Alle Testfälle haben bei mir funktioniert.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |Programm wurde gestartet: Wartet auf Eingabe: (3) Wartet auf Eingabe |-3|Die Zahl ist zu gross                   |Crash                      |
| ...  |              |         |                   |                      |
Das Programm wurde von Julius Burlet getestet.


## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
