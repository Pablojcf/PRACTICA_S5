def ejer1():
    precio = float(input("Ingrese el precio del producto: "))
    codigo = int(input("Ingrese el código de descuento (1=Estudiante, 2=Empleado, 3=Cliente frecuente): "))

    descuento = 0

    if codigo == 1:
     descuento = 0.10
    elif codigo == 2:
     descuento = 0.15
    elif codigo == 3:
        descuento = 0.20

    if precio > 500:
        descuento += 0.05

    precio_final = precio * (1 - descuento)
    print(f"Precio final: {precio_final:.2f}")

    def ejer2():
        
       nota = int(input("Ingrese una nota (0–20): "))

    if nota < 0 or nota > 20:
        print("Error: nota fuera de rango.")
    else:
        if nota <= 10:
            print("Desaprobado")
        elif nota <= 13:
            print("Regular")
        elif nota <= 17:
            print("Bueno")
        else:
            print("Excelente")

        if nota >= 14 and nota % 2 == 0:
         print("Buen desempeño con nota par")
        if nota < 11 or nota % 2 != 0:
         print("Necesita reforzar")

        print(f"Raíz cuadrada: {nota ** 0.5:.1f}")
        print(f"Potencia al cubo: {nota ** 3}")

    

