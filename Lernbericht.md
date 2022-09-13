# Lernbericht
Stefan Jesenko
## Einleitung
Ich habe im Lernatelier den Auftrtag bekommen, ein Random Number Guessing Game zu programmieren.
## Was habe ich gelernt?
Ich habe gelernt, wie ich `try` und `catch` benutze, um zu prüfen, ob eine Eingabe, das von mir vorgesehene Format hat.
## Beschreibung
Ich habe in meinem Programm mit `try` und `chatch` geprüft, ob die Eingabe des Users auch das Format hat, das ich vorgesehen habe.
`Try` versucht den darin geschriebenen Code auszuführen, wenn die Eingabe einen Fehler ausgibt und das Programm abstürzen würde,
geht das Programm zu der `catch` funktion und führt den Code aus, der dort steht. So kann man einen Fehler vermeiden und dadurch kann das Programm auch bei einer falschen Eingabe weiterlaufen.

```c#
 while (!int.TryParse(Eingabe, out num))
 {
     try
     {
         Console.WriteLine("Geben Sie eine Zahl ein: ");
         Eingabe = Console.ReadLine();
         Zahleneingabe = Convert.ToInt32(Eingabe);
     }
     catch
     {
         continue;
     }
 }
if (int.TryParse(Eingabe, out num))
{
    Zahleneingabe = Convert.ToInt32(Eingabe);
}
```
In diesem Code Beispiel sieht man wo und wie ich in meinem Code `try` `chatch` benutzt habe.


![image](https://user-images.githubusercontent.com/110892250/189840167-9623d0d2-d71a-497e-bca9-cfcc80a3b6cb.png)

In diesem Bild sieht man die Konsolenausgabe, wenn man keine Zahl eingibt.

## Verifikation
Text: Mein Text beschreibt wie `try` `catch` funktioniert und wofür man es benutzen kann.

Code: Mein Code zeigt wie ich `try` `catch` benutzt habe.

Bild: Das Bild zeigt, was diese Zeilen Code am Ende in der Applikation ausgeben werden.

## Reflexion zum Arbeitsprozess
**Bei mir ist gut gelaufen:**

Ich konnte immer motiviert an meinem Projekt arbeiten und war nie abgelenkt.
Ich versuche bei den anderen Projekten auch so motiviert zu arbeiten.

**Bei mir ist nicht so gut gelaufen:**

Ich hatte etwas schlechte Organisation, deswegen war ich im Realisieren nicht so effizient, weil ich einfach angefangen habe zu Coden.

**VBV:**
Ich versuche bei meinem nächsten Projekt mehr zu Planen und nicht einfach drauflos zu programmieren, damit ich nicht so viel Zeit brauche um Code neu zu schreiben, weil er mit dem Rest des Programms nicht funktioniert.


 
