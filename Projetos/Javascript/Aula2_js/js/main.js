function trocar(element){
    element.innerHTML = "Obrigado por ter passado o mouse";
    //alert("trocar de texto");
}

function voltar(element){
    element.innerHTML = "Passe o mouse aqui";
}

function clicou(){
    //injetando html e trabalhando com clique
    document.getElementById("agradecimento").innerHTML = "<b>Obrigado por clicar!</b>"
}

function redirecionar(){
    //para ser direcionado a outra pagina nova guia popup
    window.open("https://www.youtube.com/")
    //ira ser direcionado a outra pagina na mesma guia.
    //window.location.href = "https://www.youtube.com/";
}

function load(){
    alert("Página carregada")
}

function funcaochange(elemento){
    console.log(elemento.value)
}
/*trabalhando com funcoes
function soma(n1, n2) {
    return n1 + n2;
};

var validar = 0;

function validadeIdade(idade){
    if (idade >= 18){
        validar = true
    }else{
        validar = false
    }
    return validar;
}

var idade = prompt("Qual a sua idade? ");
validadeIdade(idade);
console.log(validar)
*/


/*trabalhando Date
var d = new Date();
alert(d.getDay());
alert(d.getHours());
alert(d.getMinutes());
*/
/*estrutura de repeticao com while
var count;
for (count = 0; count <=5; count++) {
    alert(count);
}*/

/* estrutura de repeticao com while
var count = 0;
while (count <=5){
    console.log(count);
    alert(count)
    count++;
}*/

/*condicionai if / else
//prompt exibi uma pergunta para o usuario na tela.
var idade = prompt('Qual sua idade?');
if (idade >=18){
    alert('maior de idade');
}else{
    alert('menor de idade');
}*/


/* lista de objetos
var frutas = [{nome: 'maça', cor: 'vermelha'}, {nome: 'uva', cor: 'roxa'}]
console.log(frutas);
alert(frutas[1].nome);*/

/*arrays
var lista = ['maça', 'pera', 'laranja'];
//push para adicionar
lista.push('uva');
// para retirar o ultimo
lista.pop();
//para ver o tamanho da lista
lista.length;
console.log(lista);
//passando a lista para string
console.log(lista.toString());
//colocando elementos na lista;
console.log(lista.join(" "));*/


//introdução ao js
/*var nome = "Wilson Freire";
var idade = 32;
var idade2 = 33;
var frase = 'Japão é o melhor time do mundo'
//alert(nome + ' tem ' + idade);
//alert (idade + idade2);
console.log(nome);
console.log(idade + idade2);
//replace podemos alterar o valor da variavel passada a ele
console.log(frase.replace ('Brasil é o melhor time do mundo'));
//alert(frase.replace('Japão', 'Brasil'));
//toUpperCase transforma minusculo em maiusculo.
//console.log(frase.toUpperCase());
console.log(frase.toLowerCase());*/