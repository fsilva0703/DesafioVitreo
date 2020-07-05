<center><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/MarvelLogo.svg/1200px-MarvelLogo.svg.png" width="200" height="80"></center>

# Projeto

DESAFIO VITREO

## Descrição

Aplicativo desenvolvido em Xamarin.Forms com XAML, trazendo algumas informações de personagens Marvel, tais como: nome, foto e descrição. 

### Pré-requisitos

Para executar o projeto, será necessário seguir os procedimentos abaixo:

- [Visual Studio: Para desenvolvimento do projeto](https://visualstudio.microsoft.com/pt-br/vs/community/)
- [API Marvel: Necessário criar uma conta de desenvolvedor na API da Marvel](https://developer.marvel.com/)
- [Syncfusion: Necessário ter licença para utilizar os controles destes componente](https://www.syncfusion.com/xamarin-ui-controls)
- [Device: Emuladores ou dispositivos nativos para executar o projeto em tempo real] 

### Instalação

Somente fazer um clone do repositório https://github.com/fsilva0703/DesafioVitreo/ e já com o projeto aberto no Visual Studio, atualizar alguns componentes via Nuget caso necessário.

Por exemplo:

```
Syncfusion ListView
Syncfusion CardView
Plugin Multilingual
NewtonsoftJson
```

## Recuros e funcionalidades

- O app deverá ser exclusivamente desenvolvido em Xamarin.Forms com XAML.

- Faça uso de boas práticas de desenvolvimento

- Use conceitos de componentização e reaproveitamento de código

- O app deverá ter:

  - Iconização diferente do padrão xamarin

  - Uma splashscreen customizada semelhante para android e ios

  - Deverá apresentar uma tela inicial com um filtro para pesquisa no topo com filtragem em tempo real dos personagens. Assim que entrar os personagens com imagem e nome deverá ser apresentado

  - Ao efetuar o filtro através da pesquisa, somente iniciar a pesquisa após 3 caracteres, iniciando o filtro da lista

  - Ao clicar em um personagem deverá enviar para uma tela de detalhes

  - Tela de detalhes precisa ter a imagem do personagem, seu nome e sua história(descrição)

## Testes Unitários

Existe um projeto de teste unitário chamado DesafioVitreo.UnitTest, este faz o teste dos 3 métodos executados no aplicativo.



## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Billie Thompson** - *Initial work* - [PurpleBooth](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc

