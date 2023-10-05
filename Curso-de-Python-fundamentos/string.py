nome = "wilson"

print(nome.upper())
print(nome.lower())
print(nome.title())
print("\n")

nome_completo = "  Wilson Morais freire "
print(nome_completo.strip()+ ".")
print(nome_completo.rstrip() + ".")
print(nome_completo.lstrip() + ".")
print("\n")

nome_sobrenome = "Wilson Freire"
print(".".join(nome_sobrenome))
print(nome_sobrenome.center(20, "#"))