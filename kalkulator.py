def kalkulator():
    try:
        a = float(input("Podaj pierwszą liczbę: "))
        b = float(input("Podaj drugą liczbę: "))
        operacja = input("Wybierz operację (+, -, *, /): ")

        if operacja == '+':
            wynik = a + b
        elif operacja == '-':
            wynik = a - b
        elif operacja == '*':
            wynik = a * b
        elif operacja == '/':
            if b == 0:
                print("Błąd: Dzielenie przez zero!")
                print("Program zakończony.")
                exit()
            wynik = a / b
        else:
            print("Nieznana operacja.")
            print("Program zakończony.")
            exit()

        print(f"Wynik: {wynik}")
    finally:
        print("Program zakończony.")
        exit()

kalkulator()
