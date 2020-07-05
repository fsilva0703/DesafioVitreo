<center><img src="https://upload.wikimedia.org/wikipedia/commons/thumb/0/04/MarvelLogo.svg/1200px-MarvelLogo.svg.png" width="200" height="80"></center>

# Projeto

DESAFIO VITREO

## Descrição

Aplicativo desenvolvido em Xamarin.Forms com XAML fazendo integração com a API da Marvel, trazendo algumas informações dos seus personagens, tais como: nome, foto e descrição. 

### Pré-requisitos

Para executar o projeto, será necessário seguir os procedimentos abaixo:

- [Visual Studio: Para desenvolvimento do projeto](https://visualstudio.microsoft.com/pt-br/vs/community/)
- [API Marvel: Necessário criar uma conta de desenvolvedor na API da Marvel](https://developer.marvel.com/)
- [Syncfusion: Necessário ter licença para utilizar os controles destes componente](https://www.syncfusion.com/xamarin-ui-controls)
- [Device: Emuladores ou dispositivos nativos para executar o projeto em tempo real] 

### Instalação

- Fazer um clone do repositório https://github.com/fsilva0703/DesafioVitreo/ e já com o projeto aberto no Visual Studio atualizar alguns componentes via Nuget caso necessário.

Por exemplo:

```
Syncfusion ListView
Syncfusion CardView
Plugin Multilingual
NewtonsoftJson
```

## Recuros e funcionalidades

- O app foi desenvolvido exclusivamente em Xamarin.Forms com XAML utilizando os conceitos de arquiterua MVVM.

- O APP identifica a cultura do dispositivo Mobile e faz a tradução automática.

- Linguagens disponíveis:

  - Inglês
  - Português

- Boas práticas de desenvolvimento

- Conceitos de componentização e reaproveitamento de código

  - Projeto DesafioVitreo.Domain pode ser usado como exemplo

- O APP possui:

  - Iconização diferente do padrão xamarin, sendo assim todos os ícones foram personificados com a identificação da Marvel

  - Ao inicar o APP uma SplashScreen customizada é iniciada, trazendo em si uma animação com a logo da Marvel

  - O APP possui uma tela inicial com um filtro para pesquisa no topo e filtragem em tempo real dos personagens. Porém ao carregar o APP, após a splashscreen uma lista de personagens já é carregada automaticamente

  - Ao efetuar o filtro através da pesquisa, o mesmo somente inicia-se após 3 caracteres e automaticamente inicia o filtro da lista

  - Ao clicar em um personagem na listagem você verá uma transição entre as páginas e uma leve animação no item selecionado, após será direcionado para uma tela de detalhes, onde encontrará uma breve descrição sobre o personagem selecionado.
  
  - Também utilizamos controle de cache para armazenar o Hash Code solicitado pela API da Marvel em cada requisição por 10 minutos. Desta forma, reutilizamos o Hash cacheado e aumentamos a performance.

## Testes Unitários

Existe um projeto de teste unitário chamado DesafioVitreo.UnitTest, este faz o teste dos 3 métodos executados no aplicativo.

## Versão

1.0

## Autor

* **Fábio de Paula Silva** - [DesafioVitreo](https://github.com/fsilva0703/DesafioVitreo)

## Agradecimentos

- Gostaria de agradecer ao Fábio Hara e ao Thiago Moreira pela oportunidade que me deram em poder participar deste projeto. Tem sido uma experiência muito satisfatória e chegar até aqui para mim é motivo de orgulho.  Agradecer também pela humildade, disponibilidade e atenção que me concederam no pouco tempo em que estivemos reunidos para falar sobre essa oportunidade. 

## Licença

Não necessário
