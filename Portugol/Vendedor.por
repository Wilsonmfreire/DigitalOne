programa
{
	
	funcao inicio()
	{
		real janeiro,fevereiro,marco,abril,media
		cadeia vendedor

		escreva("Digite o nome do Vendedor: ")
		leia(vendedor)
		escreva("Digite valor de Janeiro ")
		leia(janeiro)
		escreva("Digite valor de Fevereiro ")
		leia(fevereiro)
		escreva("Digite valor de Marco ")
		leia(marco)
		escreva("Digite valor de Abril ")
		leia(abril)

		media = (janeiro+fevereiro+marco+abril)/4
		escreva("O Vendedor: " + vendedor + "\n" + "Fez o valode de:" + media)

		se(media>5000){
			escreva("\n" + "Parabéns você ganhou bônus de 5%")
		}
		se(media<5000){
			escreva("\n" + "Parabéns você ganhou bônus de 3%")
		}
				
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 461; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */