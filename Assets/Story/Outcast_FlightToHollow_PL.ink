
/*

    Scene info
    ----------

    LOCATION: Interior of the prison transport ship, border of the Hollow
    OCCUPATION: None
    NPCS:
    - Player
    - Convoy Leader

*/

=== flighttohollow_01 ===
"Hej, ty śmieciu. Wstawaj! Już czas!" #color:white
Otwierasz swoje zaspane oczy. Tuż przed tobą wpatruje się w ciebie maska z dwoma dużymi szkłami, za którymi widzisz ludzkie oczy. Przynajmniej tak ci się wydaje. Członkowie Cichej Straży podobno nie mają nic z człowieka. #color:grey

    + [Co się dzieje?]
        "No proszę, nasza Śpiąca Królewna wstała. Zbliżamy się do Kotła." #color:white
        Twój brzuch skręca się z bólu. To przez uderzenie, które serwuje ci jeden ze twoich oprawców. #color:grey
        "No dalej, wstawaj! Zaraz lądujemy!" #color:white
        -> flighttohollow_02
        
=== flighttohollow_02 ===
    + [Dzięki, tego mi było trzeba - odrobiny zachęty.]
        "Żartowniś. Śmiej się, póki jeszcze możesz. Kiedy trafisz do Kotła, nie będzie odwrotu." #color:white
        -> flighttohollow_03
    + [Już wstaję, do cholery!]
        "Ktoś tu chyba nie jest w humorze. Bez obaw, po lądowaniu będzie tylko gorzej." #color:white
        -> flighttohollow_03
        
=== flighttohollow_03 ===
"A właśnie... Dajcie tu numerator. Trzeba wybić temu gnojkowi jego numer seryjny." #color:white
Słyszłeś co nieco o numeratorach i znakowaniu więźniów. Strażnicy tuż przed zesłaniem wypalają im na skórze unikalny zestaw liczb. Bydło... Tym ty i tobie podobni jesteście dla nich i dla władzy. #color:grey
"Ej, myślicielu, dawaj rękę." #color:white
Kiedy odpłynąłeś myślami od rzeczywistości, co dość często ci się zdarza, jeden z Cichych przyniósł ze sobą numerator. Urządzenie zdaje się przypominać coś w rodzaju maszyny do szycia. #color:grey
"Powiedziałem: dawaj tu tę rękę!" #color:white

    + [Po moim trupie!]
        "Chciałbyś! Bierzcie go." #color:white
        Strażnicy błyskawicznie cię obezwładniają. Ten z numeratorem łapie za twoją rękę i wkłada ją do maszyny. Do Twoich uszu dociera niepokojący syk... który zaczyna być zagłuszany przez alarm. W jednej chwili luk wypełnia się czerwienią. #color:grey
        -> flighttohollow_04
    + [Niech będzie...]
        Nie widzisz sensu w stawianiu oporu. Strażnik z numeratorem łapie za twoją rękę i wkłada ją do maszyny. Do Twoich uszu dociera niepokojący syk... który zaczyna być zagłuszany przez alarm. W jednej chwili luk wypełnia się czerwienią. #color:grey
        -> flighttohollow_04
        
=== flighttohollow_04 ===
Otaczający cię Strażnicy nieruchomieją w mgnieniu oka. Rzucasz okiem na swoją dłoń. Jest nietknięta. #color:grey
"Co się wyrabia?" #color:white
W odpowiedzi luk wypełnia mechaniczny, lekko zniekształcony głos pilota z kokpitu. #color:grey
<Kod czerwony! Powtarzam: kod czerwony! Zajmijcie miejsca! Pocisk zmierza w naszą stronę!> #color:white
Strażnik naprzeciwko ciebie odkłada numerator i siada, wbijając w ciebie nienawistne spojrzenie. #color:grey
"Nie myśl, że ci się upiekło. Zajmę się tobą później." #color:white

    + [Chciałbym to zobaczyć.] -> flighttohollow_05
    + [Nie ma co czekać.] -> flighttohollow_05
    
=== flighttohollow_05 ===
Zanim zdążysz cokolwiek powiedzieć, potężny huk rozrywa świat na pół. Ciepło w jednej chwili wypełnia luk. To statek płonie! #color:grey
<Trzymajcie się!> #color:white
Świat zaczyna wirować, a ty razem z nim. Czujesz jak z każdą upływającą sekundą przyspieszacie i spadacie z coraz większą prędkością. Macie przesrane. #color:grey
W końcu jakaś nieznana siła wyrzuca cię z fotela, a w ślad za tobą podążają Cisi. To ostatnia rzecz, którą zauważasz. Ciemność przyćmiewa twój wzrok, gdy zderzasz się z sufitem.
Pozostaje jedynie pustka... #color:grey

-> END
