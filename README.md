# Jogo da Forca

![](https://i.imgur.com/KASCZY1.gif)

## Informações

o Sistema, ele vai escolher uma palavra aleatória no tema de frutas, e o jogador deve chutar letra por letra até adivinhar a palavra completa

o jogador so tem 5 chances de errar, depois de 5 a pessoa perde.

## Como joga

Os jogadores são solicitados a inserir uma letra por vez através do console. Se a letra estiver presente na palavra, ela será revelada nas posições correspondentes. Se a letra não estiver presente na palavra, uma parte do boneco da forca será desenhada.

## Funcionalidades

- Aleatóriedade: Ele escolhe uma palavra secreta aleatória.
- Representação da forca: forca bem desenhada, com erros continuos a cada erro que a pessoa comete, aparece uma parte do corpo
- Retorno De letras: as letras que a pessoa acerta, vai aparecer no lugar certo da palavra.
- Contador de erros: ele apresenta o número de erros que a pessoa ja cometeu.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

## Como Usar

#### Clone o Repositório
```
git clone https://github.com/coelho-glith/JogoDaForca-2025
```

#### Navegue até a pasta raiz da solução
```
cd JogoDaForca-2025
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
cd JogoDaForca.ConsoleApp
```

#### Execute o projeto
```
dotnet run
```
