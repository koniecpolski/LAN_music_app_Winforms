# LAN music app
## Programowanie Sieciowe [2021/2022]
###### Aplikacja do wspólnego słuchania muzyki w sieci LAN (Winforms .NET C#)

Data oddania projektu: 17 stycznia 2021

### Korzystanie z aplikacji Serwera

1. Aby dodać utwory do playlisty, zaznacz je w folderze i przeciągnij do białego pola, po czym upuść.
2. Możliwe jest dodanie pojedynczych utworów za pomocą przycisku **DODAJ** poprzez wskazanie lokalizacji pliku
3. Aby klienci byli w stanie odtwarzać te same utwory, dodane do playlisty **pliki muszą znajdować się w identycznej lokalizacji na dysku**
4. Odtwarzaniem muzyki można sterować za pomocą przycisków na górze: *START*, *NEXT*, *PAUZA/WZNÓW*, *STOP*
5. Aby zmienić czas odtwarzanego utworu należy wprowadzić liczbę całkowitą oznaczającą docelową **milisekundę** utworu oraz nacisnąć **USTAW**
6. Utwory można przełączać również poprzez dwukrotne kliknięcie na zaznaczoną linię na playliście
7. Kolejna ścieżka dźwiękowa jest odtwarzana automatycznie po zakończeniu bieżącej, aż do dotarcia na koniec playlisty
8. Aby uruchomić serwer należy **wprowadzić IP urządzenia** (komputer może posiadać różne interfejsy sieciowe) oraz **nacisnąć przycisk WŁĄCZ SERWER**
9. Przed zamknięciem aplikacji sugerowane jest wyłączenie serwera przyciskiem **WYŁĄCZ SERWER** (służący wcześniej do jego włączenia)


### Korzystanie z aplikacji Klienta

1. Aby połączyć się z serwerem, należy **wprowadzić adres IP serwera** oraz **nacisnąć przycisk POŁĄCZ**
2. Niezbędne jest aby pliki dźwiękowe z których korzysta serwer znajdowały się w tej samej lokalizacji z perspektywy klienta (taka sama ścieżka)
3. Akcje wykonywane po stronie serwera mają swoje działanie także w aplikacji klienta.
4. Raz na 5 sekund serwer przysyła aktualną paczkę informacji.
5. Przed zamknięciem aplikacji sugerowane jest zakończenie połączenia przyciskiem **ROZŁĄCZ** (służący wcześniej do nawiązania połączenia)


### Istniejące problem

* Aplikacje spontanicznie crash'ują w momencie rozłączenia (klient)
* Zamknięcie aplikacji może pozostawiać działający proces w tle, który trzeba zakończyć ręcznie za pomocą narzędzia *taskmgr*
* Czas odtwarzania utworu jest synchronizowany tylko, jeżeli rozdźwięk przekroczy interwał 3 sekund
