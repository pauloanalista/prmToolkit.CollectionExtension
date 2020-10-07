# prmToolkit

# CollectionExtension
Classe responsável por estender as funcionalidades de uma coleção de objetos.

### Installation - CollectionExtension

Para instalar, abra o prompt de comando Package Manager Console do seu Visual Studio e digite o comando abaixo:

Para adicionar somente a referencia da dll
```sh
Install-Package prmToolkit.CollectionExtension
```
### Recursos disponíveis
- SplitCollection (Divide uma coleção em coleções menores, baseado em uma quantidade de registros informada)


### Alguns exemplos
```sh
//Divide uma grande coleção em X coleções de 100 registros
myCollection.SplitCollection(100).ToList().ForEach( mySplitCollection =>
{
	//Loop com apenas 100 registros
	mySplitCollection.ToList().ForEach(x =>
		{
			//Executa alguma ação
		});
});
```        

# VEJA TAMBÉM
## Grupo de Estudo no Telegram
- [Participe gratuitamente do grupo de estudo](https://t.me/blogilovecode)

## Cursos baratos!
- [Meus cursos](https://olha.la/udemy)

## Fique ligado, acesse!
- [Blog ILoveCode](https://ilovecode.com.br)

## Novidades, cupons de descontos e cursos gratuitos
https://olha.la/ilovecode-receber-cupons-novidades
