# GefangenenProblem
Aufgabe P2 AS

Programmierung des Gefangenendilemma (siehe unten) oder Programmierung eines eigenen Problems (siehe andere Abgabe).

Rahmensituation

Video abspielen
(Quelle: https://youtu.be/RiLytA_cHtY?t=6)

Es modelliert die Situation zweier Gefangener, die beschuldigt werden, gemeinsam ein Verbrechen begangen zu haben.

2 Bankräuber werden nach Ihrer Tat gefasst, es kann Ihnen jedoch außer unerlaubten Waffenbesitzes nichts nachgewiesen werden, was 3 Jahre Gefängnis nach sich ziehen würde. Bei der Polizei werden die beiden getrennt von einander verhört. Die Staatsanwaltschaft bietet eine Kronzeugenregelung an.
Auf den Bankraub stehen 10 Jahre Gefängnis; gesteht nur einer der beiden greift die Kronzeugenregelung, d.h. 0 Jahre für den Geständigen. Liefern jedoch beide ein Geständnis ab, bekommen beide aufgrund mildernder Umstände (sie haben ja gestanden!) nur 8 Jahre.

Das Dilemma besteht nun darin, dass sich jeder Gefangene entscheiden muss, entweder zu leugnen, abstreiten (also mit dem anderen Gefangenen zu kooperieren) oder zu gestehen (also den anderen zu verraten), ohne die Entscheidung des anderen Gefangenen zu kennen. Das letztlich verhängte Strafmaß richtet sich allerdings danach, wie die beiden Gefangenen zusammengenommen ausgesagt haben und hängt damit nicht nur von der eigenen Entscheidung, sondern auch von der Entscheidung des anderen Gefangenen ab.

Quelle: Wikipedia & Ina Stein

Spielweise
Das Ziel ist es, die wenigsten Jahre/Punkte zu erhalten. Es spielen 2 Gefangene/Strategien immer gegeneinander in 5, 25 und 100 Runden, in jeder Runde gibt es ein leichten, mittleren und schweren Verstoß, d.h. es werden 9 Spiele (Leicht 5R, Leicht 25R, ... Schwer 100R) gegenander gespielt. Wenn 5 Runden gespielt wird, werden die Ergebnispunkte mit 20 multipliziert und bei 25 Runden mit 4 multipliziert und am Ende alles addiert.

Bei schweren Verstößen (in Punkte):
S1/S2	S2 Abstreiten	S2 Gestehen
S1 Abstreiten	4 / 4	10 / 0
S1 Gestehen	0 / 10	8 / 8
Bei mittleren Verstößen (in Punkte):
S1/S2	S2 Abstreiten	S2 Gestehen
S1 Abstreiten	10 / 10	0 / 8
S1 Gestehen	8 / 0	4 / 4
Bei leichten Verstößen (in Punkte):
S1/S2	S2 Abstreiten	S2 Gestehen
S1 Abstreiten	3 / 3	9 / 0
S1 Gestehen	0 / 9	6 / 6
Aufgabe
Die Aufgabe ist es nun, das jedes Gruppenmitglied 1 Strategie schreibt, also bei 3 Mitgliedern 3 Strategien, welches einen Gefangenen darstellt. D.h. die Strategie muss jede Runde gegen die andere Strategie entscheiden, ob es gestehen/kooperien oder abstreiten/verraten will. Damit dies umsetzbar ist, sollen Sie sich an die vorgebenene Implementierung der Methoden halten und ein passenden Verwaltungsrogramm schreiben. Im Anhang existiert ein Rumpfprogramm, welches Sie als Basis verwenden sollen. Beachten Sie auch die Hinweise.
