# Gefangenendilemma
## Aufgabe P2 AS

<span class="c17">Programmierung des Gefangenendilemma (siehe unten)</span> <span class="c17 c19">oder</span><span class="c2"> Programmierung eines eigenen Problems (siehe andere Abgabe).</span>

### <span class="c16">Rahmensituation</span>

<span class="c2">(Quelle: https://youtu.be/RiLytA_cHtY?t=6)</span>

<span class="c2">Es modelliert die Situation zweier Gefangener, die beschuldigt werden, gemeinsam ein Verbrechen begangen zu haben.</span>

<span class="c2">2 Bankräuber werden nach Ihrer Tat gefasst, es kann Ihnen jedoch außer unerlaubten Waffenbesitzes nichts nachgewiesen werden, was 3 Jahre Gefängnis nach sich ziehen würde. Bei der Polizei werden die beiden getrennt von einander verhört. Die Staatsanwaltschaft bietet eine Kronzeugenregelung an.</span>

<span class="c2">Auf den Bankraub stehen 10 Jahre Gefängnis; gesteht nur einer der beiden greift die Kronzeugenregelung, d.h. 0 Jahre für den Geständigen. Liefern jedoch beide ein Geständnis ab, bekommen beide aufgrund mildernder Umstände (sie haben ja gestanden!) nur 8 Jahre.</span>

<span class="c2">Das Dilemma besteht nun darin, dass sich jeder Gefangene entscheiden muss, entweder zu leugnen, abstreiten (also mit dem anderen Gefangenen zu kooperieren) oder zu gestehen (also den anderen zu verraten), ohne die Entscheidung des anderen Gefangenen zu kennen. Das letztlich verhängte Strafmaß richtet sich allerdings danach, wie die beiden Gefangenen zusammengenommen ausgesagt haben und hängt damit nicht nur von der eigenen Entscheidung, sondern auch von der Entscheidung des anderen Gefangenen ab.</span>

<span class="c17">Quelle:</span> <span class="c7">[Wikipedia](https://www.google.com/url?q=https://de.wikipedia.org/wiki/Gefangenendilemma&sa=D&ust=1589447860252000)</span><span class="c2"> & Ina Stein</span>

### <span class="c14">Spielweise</span>

<span class="c2">Das Ziel ist es, die wenigsten Jahre/Punkte zu erhalten. Es spielen 2 Gefangene/Strategien immer gegeneinander in 5, 25 und 100 Runden, in jeder Runde gibt es ein leichten, mittleren und schweren Verstoß, d.h. es werden 9 Spiele (Leicht 5R, Leicht 25R, ... Schwer 100R) gegenander gespielt. Wenn 5 Runden gespielt wird, werden die Ergebnispunkte mit 20 multipliziert und bei 25 Runden mit 4 multipliziert und am Ende alles addiert.</span>

#### <span class="c13">Bei schweren Verstößen (in Punkte):</span>

<a id="t.18e5bed2710aa81fa52f058336d4a0d50083ec53"></a><a id="t.0"></a>

<table class="c4">

<tbody>

<tr class="c9">

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S1/S2</span>

</td>

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S2 Abstreiten</span>

</td>

<td class="c6" colspan="1" rowspan="1">

<span class="c2">S2 Gestehen</span>

</td>

</tr>

<tr class="c9">

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S1 Abstreiten</span>

</td>

<td class="c0" colspan="1" rowspan="1">

<span class="c2">4 / 4</span>

</td>

<td class="c6" colspan="1" rowspan="1">

<span class="c2">10 / 0</span>

</td>

</tr>

<tr class="c9">

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S1 Gestehen</span>

</td>

<td class="c0" colspan="1" rowspan="1">

<span class="c2">0 / 10</span>

</td>

<td class="c6" colspan="1" rowspan="1">

<span class="c2">8 / 8</span>

</td>

</tr>

</tbody>

</table>

#### <span class="c13">Bei mittleren Verstößen (in Punkte):</span>

<a id="t.f6c08b772cd828e60a051cef8bf8ba0f97f1e0a7"></a><a id="t.1"></a>

<table class="c4">

<tbody>

<tr class="c9">

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S1/S2</span>

</td>

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S2 Abstreiten</span>

</td>

<td class="c6" colspan="1" rowspan="1">

<span class="c2">S2 Gestehen</span>

</td>

</tr>

<tr class="c9">

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S1 Abstreiten</span>

</td>

<td class="c0" colspan="1" rowspan="1">

<span class="c2">10 / 10</span>

</td>

<td class="c6" colspan="1" rowspan="1">

<span class="c2">0 / 8</span>

</td>

</tr>

<tr class="c9">

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S1 Gestehen</span>

</td>

<td class="c0" colspan="1" rowspan="1">

<span class="c2">8 / 0</span>

</td>

<td class="c6" colspan="1" rowspan="1">

<span class="c2">4 / 4</span>

</td>

</tr>

</tbody>

</table>

#### <span class="c13">Bei leichten Verstößen (in Punkte):</span>

<a id="t.66fcd445864445f6e222a8970cf09c2850cba8f1"></a><a id="t.2"></a>

<table class="c4">

<tbody>

<tr class="c9">

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S1/S2</span>

</td>

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S2 Abstreiten</span>

</td>

<td class="c6" colspan="1" rowspan="1">

<span class="c2">S2 Gestehen</span>

</td>

</tr>

<tr class="c9">

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S1 Abstreiten</span>

</td>

<td class="c0" colspan="1" rowspan="1">

<span class="c2">3 / 3</span>

</td>

<td class="c6" colspan="1" rowspan="1">

<span class="c2">9 / 0</span>

</td>

</tr>

<tr class="c9">

<td class="c0" colspan="1" rowspan="1">

<span class="c2">S1 Gestehen</span>

</td>

<td class="c0" colspan="1" rowspan="1">

<span class="c2">0 / 9</span>

</td>

<td class="c6" colspan="1" rowspan="1">

<span class="c2">6 / 6</span>

</td>

</tr>

</tbody>

</table>

## <span class="c21">Aufgabe</span>

<span class="c2">Die Aufgabe ist es nun, das jedes Gruppenmitglied 1 Strategie schreibt, also bei 3 Mitgliedern 3 Strategien, welches einen Gefangenen darstellt. D.h. die Strategie muss jede Runde gegen die andere Strategie entscheiden, ob es gestehen/kooperien oder abstreiten/verraten will. Damit dies umsetzbar ist, sollen Sie sich an die vorgebenene Implementierung der Methoden halten und ein passenden Verwaltungsrogramm schreiben. Im Anhang existiert ein Rumpfprogramm, welches Sie als Basis verwenden sollen. Beachten Sie auch die Hinweise.</span>

<span class="c18"></span>

<a href="https://ls11-www.cs.tu-dortmund.de/_media/techreports/tr06-11.pdf" target="_blank">Paper</a>


# Bewertungskrtieren

Für die 1+ benötigen Sie 100 Punke. Alle Aufgaben/Tasks/Storys (vgl. Scrum) bringen
Punkte, Sie entscheiden, welche Aufgaben Sie machen wollen. Geben Sie bei der Abgabe
an, welche Aufgaben Sie gemacht haben. Die eingereichten Aufgaben dürfen max. 105
Punkte wert sein, alle weiteren angegeben Aufgaben werd ignoriert.
● S1-3: je +10 für eine eigene Strategie pro Gruppenmitglied (bei 3
Gruppenmitgliern) Dazu einfach die Strategie1-3 mit Leben füllen.
● S1-2: je +15 für eine eigene Strategie pro Gruppenmitglied (bei 2
Gruppenmitgliern) Dazu einfach die Strategie1-2 mit Leben füllen.
● B1: +15 Eine ihrer Strategie schlägt die Verrate immer Strategie (Wenn Sie die
Aufgabe machen, geben Sie an, welche Strategie, wieviele Runden und die Art des
Verstoßes)
● B2: +15 Eine ihre Strategie schlägt die Groll Strategie (Wenn Sie die Aufgabe
machen, geben Sie an, welche Strategie, wieviele Runden und die Art des
Verstoßes)
● P1: +5 Testprotokoll des einfachen Schreibtischtests, der eine Strategie testet,
welche 5 Runden gegen die Groll Strategie spielt und gewinnt.
● P2: +10 Erstellung eines Struktogramms oder Programmablaufplan nur für eine
Strategie, welche gegen die Groll Strategie spielt und gewinnt.
● P3: +5 Kommenieren Sie ihre komplexen Codeabschnitte und Methoden C#
konform
● E1: +10 Ergänzung, dass auch leichte und mittlere Schwere im Programm
gespielt werden können.
● E2: +10 Neue Funktion, dass 2 Strategien die 9 Spiele gegenander spielen und
dann erst der Sieger gekürt wird.
● E3: +10 Neue Funktion, die ermittelt, ab welcher Rundenzahl gewinnt die eine
Strategie zuverlässig.
● E4: +10 Der Benutzer kann gegen eine Strategie spielen
● A1: +5 Gegen ein anderes Team gespielt. Geben Sie an, welche ihrer Strategien,
gegen welche andere Strategie in welchem Spielmodus gespielt hat. Am
einfachsten die Dateien dazu austauschen.
● R1: +10 Sie haben im Team ein Reposity verwendet, also jedes Teammitglied hat
mehr als 2 Commits gemacht.
● T1: +15 Turnierverwaltung*, Alle Strategien spielen 9 Spiele zusammen und das
Programm ermittelt eine Rangfolge der Stategien. Empfehlenswert sollte E
davor umgesetzt werden.
● T2: +10 Erweiterung der Turnierverwaltung um eine Statistikfunktion
● Z1: +?? Sie haben noch eine tolle Erweiterungsidee? Dann melden Sie sich und es
wird hier ergänzt.

# Zusatzpunkte

Ihre Strategien nehmen am Turnier teil:


● G0: +20 Sie sind Aufgabensieger, d.h. ihre Strategie schlägt alle anderen
Strategien der Klasse und der Parallelklasse.
● G1: +15 Sie sind Klassensieger, d.h. ihre Strategie schlägt alle anderen Strategien
der Klasse.
● G2: +10 Alternaitv Sie haben den 2. Platz errungen.
● G3: +5 Alternaitv Sie haben den 3. Platz errungen.
Beispiel: Sie sind 3 Gruppenmitglieder und machen die Tasks S1,S2,S3,B1,E2,A1,T1,T
dann haben die Tasks einen Umfang von 10+10+10+15+15+10+5+15+10=100 Punkte,
und nur diese Funktionalität wird bei Ihnen bewertet. Da einige Aspekte fehlerhaft waren,
erhalten Sie aber nur 83 von 100 Punkte, da Sie aber eine tolle Strategie geschrieben
haben, welche den 2. Platz errungen hat erhalten Sie noch 10 Zusatzpunkte, also
insgesamt 93 Punkte.
Beispiel II: Sie sind 3 Gruppenmitglieder und machen die Tasks
S1,S2,S3,B1,E2,A1,T1,T2,E4 dann haben die Tasks einen Umfang von
10+10+10+15+15+10+5+15+10+10=110 Punkte, und nur diese Funktionalität wird bei
Ihnen bewertet. E4 wird nicht mehr bewertet, da die Gesamtpunkte dann über 105 liegen
würden. Da einige Aspekte fehlerhaft waren, erhalten Sie aber nur 87 von 100 Punkte.

# *Turnierverwaltung

Das Ziel ist es, die wenigsten Jahre/Punkte zu erhalten. Es spielen 2
Gefangene/Strategien immer gegeneinander in 5, 25 und 100 Runden, in jeder Runde
gibt es ein leichten, mittleren und schweren Verstoß, d.h. es werden 9 Spiele (Leicht 5R,
Leicht 25R, ... Schwer 100R) gegenander gespielt. Wenn 5 Runden gespielt wird, werden
die Ergebnispunkte mit 20 multipliziert und bei 25 Runden mit 4 multipliziert und am
Ende alles addiert.

# Hinweise

```
● Sie können alles im Rumpfprogramm an ihre Bedürfnisse anpassen, außer, was
im Ordner Basis ist, dies wird benötigt, dass gemeinsam gegen andere gespielt
werden kann.
● Geben Sie am Ende ihr ganzes Projekt ab. Sie finden im Anhang das
Rumpfprogramm.
● Keine Idee für eine Strategie? Das Internet kann sicherlich weiterhelfen ;)
● Damit es einfacher umsetzbar ist, enthält das Programm schon Konzepte aus
AS3 und Collection (Siehe Skript II). Sie müssen diese aber nicht im Detail
verstehen, um das Programm abgeben zu können.
● Im Kopf/class der Strategien steht : BasisStrategie, dies bitte so stehen lassen
und einfach ignorieren. Genauso müssen die vorgegeben Methoden weiterhin so
heißen, damit es funktioniert. Sollten Sie ausversehen etwas geändert haben und
es nicht mehr funktionieren und Sie wissen nicht mehr, wie Sie es zurück ändern,
melden Sie sich bitte, dann ändern wir es kurz gemeinsam zusammen.
```

```
● Im Verwaltungsprogramm gibt es eine beispielhafte Implementierung. Sie können
sich gerne an dieser orientieren und anpassen (besonders für E?)
● Prisoner icon by ​Delapouite​ under ​CC BY 3.
● Bei mittleren Verstößen sind mit Absicht die Punkte vertauscht. Ist zwar
unlogisch, macht es so aber interessanter.
● Es gibt noch eine abgespeckte Version, für Leute, die schonerfahrender sind und
alles selbst entwickeln wollen. Für Anfänger wird es nicht empfehlen, da es
Konzepte veraussetzt, die wir noch nicht behandelt hatten.
```
# Log

```
● 20.05. Aufgabe & Rumpfprogramm überarbeitet, konkretisiert, Hinweise ergänzt
und komplexe Codeabschnitte vereinfacht.
● 27.05. B3 in P1 umgwandelt, P2 ergänzt, Interfaceversion für Profis ergänzt.
● 02.06. Tasks konkretisiert.
● 04.06. P3 ergänzt.
● 06.06. max. Punkte auf 105 gesetzt.
●
```
