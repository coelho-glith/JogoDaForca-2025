# Jogo Da Forca

![](https://i.imgur.com/KASCZY1.gif)

# Detalhes 

O sistema escolhera de maneira aleatória, uma palavra entre várias possibilidades no tema de frutas, e o jogador deve chutar, letra por letra, até adivinhá-la com sucesso

Se o jogador chutar mais de 5 letras erradas, ele perde totalmente.

# Entrada

O jogador será solicitado mandar uma letra de cada vez para adivinhar a palavra completa, se a letra estiver errada uma parte do boneco aparece, e sera revelada posições das letras certas da palavra secreta escolhida.

# Funcionalidades

- Escolha de Palavra Secreta: Uma palavra é aleatoriamente escolhida para o jogo.
- Representação da Forca: A forca é desenhada com etapas, com cada erro do jogador.
- Feedback Visual: As letras corretas são aparecerão no lugar certo enquanto outros ainda não.
- Contagem de Erros: O jogo coloca na sua cara o quão azarado ou sortudo tu é com um contador de Erros até o 5.

# Como Usar

---
## Clone o Repositório
```
git clone https://github.com/coelho-glith/JogoDaForca-2025
```
## Navegue até a pasta raiz da solução
```
cd JogoDaForca
```
## Restaure as dependências
```
dotnet restore
```
## Navegue até a pasta do projeto
```
cd JogoDaForca.ConsoleApp
```
## Execute o projeto
```
dotnet run
```

## Requisitos
---
- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
