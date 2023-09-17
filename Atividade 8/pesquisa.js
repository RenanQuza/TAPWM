var j = 0;

var idade = 0;
var idadeSoma = 0;
var velha = 0;
var nova = 0;

var sexo = '';
var mulheres = 0;
var homens = 0;

var opiniao = 0;
var quantidadePessimo = 0;
var quantidadeRegular = 0;
var quantidadeBom = 0;
var quantidadeOtimo = 0;


for (i = 0; i < 45; i++) {

    alert("Rodada = " + i);
    j = i;

    idade = prompt("Digite a idade: ");
    if(idade > velha){
        velha = idade;
        idadeSoma += idade;
    }else if(idade < nova){
        nova = idade;
        idadeSoma += idade;
    }else{
        alert("Receita de programação: Nem mais velha nem mais nova");
        idadeSoma += idade;
    };

    sexo = prompt("Digite o sexo: masculino feminino");
    if(sexo == 'masculino' || sexo == 'Masculino'){
        homens++;
    }else if(sexo == 'feminino' || sexo == 'Feminino'){
        mulheres++;
    }else{
        alert("Nem masculino nem feminino foi selecionado");
    };

    opiniao = prompt("Digite a opinião: ótimo=4  bom=3  regular=2  péssimo=1");
    if(opiniao == 1){
        quantidadePessimo += opiniao;
    }else if(opiniao == 2){
        quantidadeRegular += opiniao;
    }else if(opiniao == 3){
        quantidadeBom += opiniao;
    }else if(opiniao == 4){
        quantidadeOtimo += opiniao;
    }else{
        alert("Erro, escolha não coesa com as categorias");
    }

};

if(quantidadeBom !== 0){
    quantidadeBom *= 100;
};

if(quantidadeOtimo !== 0){
    quantidadeOtimo *= 100;
};

idadeSoma /= j;


alert('Media de idade: ' + idadeSoma);
alert('Idade da pessoa mais velha: ' + velha);
alert('Idade da pessoa mais nova: ' + nova);
alert('Nº de pessoas que responderam péssimo: ' + quantidadePessimo);
alert('Nº de pessoas que responderam regular: ' + quantidadeRegular);
alert ('Porcentagem de pessoas que responderam bom: ' + quantidadeBom + '%');
alert ('Porcentagem de pessoas que responderam ótimo: ' + quantidadeOtimo + '%');
alert('Nº de mulheres que responderam: ' + mulheres);
alert('Nº de homens que responderam: ' + homens);