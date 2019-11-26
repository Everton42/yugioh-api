# My YuGiOh! Deck Api 

É uma WEB API com ASP.NET Core 2.2 que consome a api [ygoprodeck](https://db.ygoprodeck.com/api-guide/) e dá a opção de salvar 
as informações das cartas em um servidor local. É um projetinho feito por diversão.

### Instalação

Abra o NuGet Package Manager > Package Manager Console.

Selecione como Default Project [MyYuGiOhDeck.Persistence]

Execute os comandos:

```
PM> add-migration DBCreate
PM> update-database
```
Feita as migrações o banco será gerado.

Altera a connection string no appsettings.json

Ao executar o projeto adicione na url "/swagger"

