
const janela = document.getElementById("janela");
const h1 = document.querySelector("h1");


function abrirJanela() {
    janela.src = "Imagens/imagem3.jpg";
    h1.textContent = "Janela Aberta";
}


function fecharJanela() {
    janela.src = "Imagens/imagem1.jpg";
    h1.textContent = "Janela Fechada";
}


function quebrarJanela() {
    janela.src = "Imagens/imagem2.jpg";
    h1.textContent = "Janela Quebrada";
}


janela.addEventListener("mouseover", abrirJanela);
janela.addEventListener("mouseout", fecharJanela);
janela.addEventListener("click", quebrarJanela);