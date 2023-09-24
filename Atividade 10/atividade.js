var a = parseFloat(prompt("Digite um valor: "));
var b = parseFloat(prompt("Digite um valor: "));
var c = parseFloat(prompt("Digite um valor: "));


if(Number.isNaN(a, b, c)){
    alert("Por favor insira apenas números nos valores.");
}
 
if(a + b > c && a + c > b && b + c > a){
    alert("Os três valores formam um triângulo.")
 
    if(a == b && a == c){
    alert("É um equilátero");
    }
    else if(a == b || a == c || b == c){
    alert("É um isósceles");
    }
    else{
    alert("É um escaleno");
    }
}
else{
    alert("Não é um triangulo");
   }