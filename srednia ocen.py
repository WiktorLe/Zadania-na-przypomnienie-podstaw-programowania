def srednia_ocen():
    try:
        ile = int(input("Ile ocen chcesz podać? "))
        oceny = []

        for i in range(ile):
            ocena = float(input(f"Podaj ocenę {i+1}: "))
            if ocena < 1 or ocena > 6:
                print("Ocena spoza zakresu 1–6. Program zakończony.")
                exit()
            oceny.append(ocena)

        srednia = sum(oceny) / len(oceny)
        print(f"Średnia: {srednia:.2f}")

        if srednia >= 3.0:
            print("Uczeń zdał.")
        else:
            print("Uczeń nie zdał.")
    finally:
        print("Program zakończony.")
        exit()

srednia_ocen()
