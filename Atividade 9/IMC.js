var peso = parseFloat(prompt("Digite a seu peso: "));
var altura = parseFloat(prompt("Digite a sua altura: "));

var calculo = Math.round(peso / Math.pow(altura,2), 1);




if(calculo < 18.5){
    alert("IMC: "+ calculo +" | Classificação: Magreza | Grau de obesidade: 0");
}
else if(calculo >= 18.5 && calculo <= 24.9){
    alert("IMC: "+ calculo +" | Classificação: Normal | Grau de obesidade: 0");
}
else if(calculo >= 25 && calculo <= 29.9){
    alert("IMC: "+ calculo +" | Classificação: Sobrepeso | Grau de obesidade: I");
}
else if(calculo >= 30 && calculo <= 39.9){
    alert("IMC: "+ calculo +" | Classificação: Obesidade | Grau de obesidade: II");
}
else if(calculo > 40){
    alert("IMC: "+ calculo +" | Classificação: Obesidade grave | Grau de obesidade: III");
}
else{
    alert("IMC: "+ calculo +" | Falha ao calcular o IMC");
}