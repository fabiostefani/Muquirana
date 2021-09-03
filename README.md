# Muquirana

![Imgur](https://i.imgur.com/1IoDbax.png)

Software para controle de Despesas Pessoais. Possui fins didáticos para entendimento de conceitos de Bound Context, Eventos de Domínio....


### Aqui estão as stacks utilizadas no projeto 
 - [**ASP.NET Core**](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-5.0)
</br>


Passos:
<br>1º - Criação do projeto no GitHub
<br>2º - Clone do projeto para o repositório local
```
git clone https://github.com/fabiostefani/Muquirana.git
```
<br>3º - Criação das estruturas de Diretórios para organização dos fontes. Separei em pastas **SRC** e **TESTS**. E dentro de SRC estão os códigos fontes organizados em projetos.
A estrutura final de diretórios ficou dessa forma

![Imgur](https://i.imgur.com/PFIkzQH.png)



<br>4º - Criação da Solution. No diretório raíz do projeto, executar o comando abaixo.
```
dotnet new solution --name fabiostefani.io.Muquirana
```
Estou indicando para ser criado uma Solution com o nome fabiostefani.io.Muquirana.

<br>5º - Criação dos Projetos. No diretório especifico de cada projeto, devemos criar a sua classlib e adicionar na solution.
Vamos criar primeiro o nosso Core, aonde teremos a base para as nossas aplicações.
```
dotnet new classlib --name fabiostefani.io.Muquirana.Core
```
Agora vamos adicionar esse projeto a solution
```
dotnet sln ..\..\..\fabiostefani.io.Muquirana.sln add .\fabiostefani.io.Muquirana.Core\fabiostefani.io.Muquirana.Core.csproj
```
E assim vamos criando os demais projetos da solution.
```
dotnet new classlib --name fabiostefani.io.Muquirana.Cadastros.Domain

dotnet sln ..\..\..\fabiostefani.io.Muquirana.sln remove .\fabiostefani.io.Muquirana.Cadastros.Domain\fabiostefani.io.Muquirana.Cadastros.Domain.csproj
```
E para adicionar a referência entre os projetos, deve ser executado
```
dotnet add .\fabiostefani.io.Muquirana.Cadastros.Domain\fabiostefani.io.Muquirana.Cadastros.Domain.csproj reference ..\Core\fabiostefani.io.Muquirana.Core\fabiostefani.io.Muquirana.Core.csproj
```
