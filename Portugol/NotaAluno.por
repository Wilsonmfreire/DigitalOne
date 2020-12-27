programa
{
	
	funcao inicio()
	{
		real nota1,nota2,nota3,nota4,media
		cadeia aluno

		escreva("Digite o nome do aluno:")
		leia(aluno)
		escreva("DIgite a nota 1:")
		leia(nota1)
		escreva("DIgite a nota 2:")
		leia(nota2)	
		escreva("DIgite a nota 3:")
		leia(nota3)	
		escreva("DIgite a nota 4:")
		leia(nota4)	
		
		media = (nota1+nota2+nota3+nota4)/4
		
		escreva("Sua média é:" + media)

		se(media>=7){
			escreva("\n" +"parabens você foi aprovado") 
		}
		senao{
			escreva("\n" + "Infelizmente você foi reprovado")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 531; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */