def konwerter_temperatur():
    try:
        kierunek = input("Wybierz konwersję (C - Celsjusz na Fahrenheit, F - Fahrenheit na Celsjusz): ").upper()
        temperatura = float(input("Podaj temperaturę: "))

        if kierunek == 'C':
            wynik = temperatura * 1.8 + 32
            print(f"{temperatura}°C = {wynik}°F")
        elif kierunek == 'F':
            wynik = (temperatura - 32) / 1.8
            print(f"{temperatura}°F = {wynik:.2f}°C")
        else:
            print("Niepoprawny wybór konwersji.")
            print("Program zakończony.")
            exit()
    finally:
        print("Program zakończony.")
        exit()

konwerter_temperatur()
