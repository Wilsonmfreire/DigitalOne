menu = """
[d] Depositar
[s] Sacar
[e] Extrato
[q] Sair

=> """

saldo = 0
limite = 500
extrato = ""
numero_saque = 0
LIMITE_SAQUES = 3

while True:

    opcao = input(menu)

    if opcao == "d":
        valor = float(input("Valor: "))

        if valor > 0:
            saldo += valor
            extrato += f"Depósito: R$ {valor:.2f}\n"
        else:
            print("Valor informado inválido.")
    
    elif opcao == "s":
        valor = float(input("Quanto deseja retirar: "))

        excedeu_saldo= valor > saldo
        excedeu_limite= valor > limite
        excedeu_saque= numero_saque >=LIMITE_SAQUES

        if excedeu_saldo:
            print("Sem saldo suficiente.")
        elif excedeu_limite:
            print("Valor do saque excede o limite.")
        elif excedeu_saque:
            print("Número de saque excedido.")
        
        elif valor >0:
            saldo -= valor
            extrato += f"saque: R$ {valor:.2f}\n"
            numero_saque += 1
        
        else:
            print("Valor informado inválido.")

    
    elif opcao == "e":
        print(f"Extrato R${saldo:.2f}")
    
    elif opcao == "q":
        print("Sair")
        break

    else:
        print("Operação inválida, por favor selecione novamente a operação desejada.")
