def sacar(valor = float(input("Informe o valor para saque: "))):
    saldo = 500

    if saldo >= valor:
        print(f"valor ${valor} sacado!")
        print("retire o seu dinheiro na boca do caixa.")
        
    else: 
        print("Saldo insuficiente!")
    print("Obrigado por ser nosso clientre, tenha um bom dia!")

sacar()