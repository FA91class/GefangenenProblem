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
