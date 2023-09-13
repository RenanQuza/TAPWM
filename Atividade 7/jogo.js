var a = 0;//usuário
var b = Math.random();//pc

a = prompt("Digite o nº de acordo com sua escolha: \n1=Pedra \n2=Papel \n3=Tesoura");
//1=pedra 2=papel 3=tesoura
if(b <= 0.33){
    b=1;
}
else if(b > 0.33 && b <= 0.66){
    b=2;
}
else if(b > 0.66 && b <= 0.99){
    b=3;
}
else{
    alert("Falha ao converter o número da máquina");
}

if(a == b){
    alert("Empate");
}
else if(a==1 && b==3){
    alert("Pedra quebra tesoura, usuario venceu");
}
else if(a==3 && b==2){
    alert("Tesoura corta papel, usuario venceu");
}
else if(a==2 && b==1){
    alert("Papel cobre a pedra, usuario venceu");
}
else if(b==1 && a==3){
    alert("Pedra quebra tesoura, a máquina venceu");
}
else if(b==3 && a==2){
    alert("Tesoura corta papel, a máquina venceu");
}
else if(b==2 && a==1){
    alert("Papel cobre a pedra, a máquina venceu");
}
else{
    alert("resultado invalido, tente novamente");
}