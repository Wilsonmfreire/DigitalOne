# frutas = ["laranja", "maca", "uva"]
# letras = list("Python")
# numeros = list(range(10))
# carro = ["Ferrari", "F8", 4000, 222, "São Paulo"]

# print(frutas, "\n", letras, "\n", numeros , "\n", carro)

# carros = ["gol", "celta", "palio"]



# for indice, carro in enumerate(carros):
# 	print(f"{indice}: {carro}")

numeros = [1,30,21,2,9,65,34]
pares = []
for numero in numeros:
	if numero % 2 == 0:
		pares.append(numero)
print(pares)

linguagens = ["python", "js", "c", "java", "csharp",]
linguagens.sort()
print(linguagens)

linguagens = ["python", "js", "c", "java", "csharp",]
linguagens.sort(reverse= True)
print(linguagens)

linguagens = ["python", "js", "c", "java", "csharp",]
linguagens.sort(key=lambda x: len(x))
print(linguagens)

linguagens = ["python", "js", "c", "java", "csharp",]
linguagens.sort(key=lambda x: len(x), reverse= True)
print(linguagens)

linguagens = ["python", "js", "c", "java", "csharp",]
len(linguagens)
print(len(linguagens))