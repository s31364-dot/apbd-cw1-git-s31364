# Zadanie 5
Merge nie był "fast-forward", ponieważ na gałęzi main pojawił się nowy commit.
Historie się rozeszły, co wymusiło utworzenie "merge commit".
# Zadanie 6
Merge tworzy nowy merge commit, łącząc dwie równoległe historie.

Rebase przenosi commity z gałęzi bocznej na koniec gałęzi głównej. Historia staje się liniowa a scalenie odbywa się przez fast-forward.
# Odpowiedzi na pytania 
1. Fast-forward występuje, gdy gałąź główna nie ma nowych zmian i Git tylko przesuwa wskaźnik. 
Merge commit powstaje, gdy obie gałęzie mają własne nowe commity.
2. Merge zachowuje pełną historię, pokazując dokładnie kiedy i co było robione. 
Rebase "prostuje" historię, przenosząc zmiany na sam koniec głównej gałęzi dzięki czemu wykres wygląda jak jedna prosta.
3. Konflikt rozwiązano przez ręczną edycję pliku Program.cs i usunięcie znaczników. 
Następnie użyto komendy git add, aby oznaczyć konflikt jako rozwiązany, oraz git commit, co sformalizowało zakończenie operacji merge.