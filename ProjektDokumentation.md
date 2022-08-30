# Projekt-Dokumentation


Stefan Jesenko

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.08.2022| 0.0.1|Heute habe ich zum ersten mal an diesem Projekt gearbeitet ich habe heute den ersten Teil der Projekt Dokumentation geschrieben und ein PAP zum RNG spiel gemacht.|
| 23.08.2022|0.0.2|Heute habe ich meinen random number generator Fertig geschrieben und alle User storys umgesätzt.|
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


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Applikation gestartet: warte auf User Eingabe|"Zahl"|"Bitte geben Sie eine Zahl von 1 bis 100 ein".|
| 1.2  |Applikation gestartet: warte auf User Eingabe|"200"|"Bitte geben Sie eine Zahl von 1 bis 100 ein.|
| 1.3  |Applikation gestartet: Warte auf User Eingabe.|"15" |" "|
| 2.1  |Applikation gestartet: Führt RNG aus.|" "|zufällige Zahl 1-100|
| 3.1  |zufällige Zahl und eingegebene Zahl sind bestimmt: Fürt Zahlenvergleich aus.|"zufällige Zahl und eingegebene Zahl."| gibt aus, ob die Zahlen gleich sind oder nicht.|
| 4.1  |Applikation gestartet: Führt Zahlenvergleich aus.|"zufällige Zahl und eingegebene Zahl."| wenn die Zahlen nicht gleich sind, wird ausgegeben, ob die eingegebene Zahl grösser oder kleiner ist als die zufällige Zahl.|
| 5.1  |Applikation wurde durchgeführt|" "| Die Textfarbe sollte in einer anderen Farbe sein.|

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

Total: 8



## 3 Entscheiden

Ich habe mich entschieden das ich als zusätzliche User story hinzufüge das ich den Text umfärben kann.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 30.08.2022|Stefan Jesenko| 30min|10min|
| 2.A  | 30.08.2022|Stefan Jesenko| 30min|5min |
| 3.A  | 30.08.2022|Stefan Jesenko| 1h   |30min|
| 4.A  | 30.08.2022|Stefan Jesenko| 1h   |30min|
| 5.A  | 30.08.2022|Stefan Jesenko| 3h   |10min|



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
