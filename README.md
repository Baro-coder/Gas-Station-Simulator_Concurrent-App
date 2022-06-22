# Gas-Station-Simulator_Concurrent-App

# Projekt 
## Geneza[^gen]
Projekt powstał w ramach ćwiczeń laboratoryjnych z przedmiotu **Programowanie współbieżne** realizowanych w trakcie pobierania nauki na Wydziale Cybernetyki 
w Wojskowej Akademii Technicznej.

## Opis[^desc]
Program napisany w języku **C#** przy wykorzystaniu framework'u **Windows Forms**.

Aplikacja stanowi hipotetyczną symulację stacji paliw, również w kontekście wątkowym, tzn.
wątki sekwencyjne symulują klientów w oczekiwaniu na zwolnienie zasobów dzielonych, jakimi są
miejsca przy dystrybutorach, kasy płatnicze oraz miejsca oczekiwania na wolny dystrybutor.

___

## Interfejs[^ui]

<img align="right" width="500" height="300" src="https://user-images.githubusercontent.com/74451381/175053535-89005812-ebc7-4d07-a796-a114365f8d03.jpg">

### Klienci
Odzwierciedleniem klientów w interfejsie są nadjeżdżające samochody w odpowiednim kolorze, 
z czego każdy coś oznacza:

#### czerwony
> Samochód oczekuje na zatankowanie

#### żółty
> Samochód zatankowany, czeka w kolejce do zapłaty

#### zielony 
> Samochód zatankowany, rozliczony, wyjeżdża ze stacji

___

### Panel sterowania
#### Przyciski
Panel zawiera dwa przyciski: 
- **START** - rozpoczyna symulację,
- **RESET** - po zakończonej symulacji przygotowuje program do kolejnej symulacji.

#### Scrollbar
Dostępny jest również **scrollbar**, umożliwiający dobór ilości procesów sekwecyjnych 
(klientów) do wywołania w przedziale <1, 80>.

#### Czas symulacji
Użytkownik ma również dostęp do wglądu w **czas symulacji** liczony od kliknięcia przycisku
**START** do zakończenia działania wszystkich utworzonych procesów sekwencyjnych.

#### Pasek postępu
**Pasek postępu** informuje graficznie użytkownika o ilości pozostałych wątków, których
liczba jest wyświetlana powyżej **czasu symulacji**.

___

[^gen]: Geneza
[^desc]: Opis
[^ui]: Interfejs
