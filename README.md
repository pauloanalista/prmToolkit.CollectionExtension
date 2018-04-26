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
