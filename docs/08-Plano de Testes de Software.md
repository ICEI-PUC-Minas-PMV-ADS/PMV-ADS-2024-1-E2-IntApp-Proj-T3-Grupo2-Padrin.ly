# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| CT-01 – Cadastro de Instituição (Pessoa jurídica) 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de instituições para que essas consigam criar e gerenciar seus perfis. |
| Objetivo do Teste 	| Verificar se o usuário (instituição) consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://https://padrin.ly//src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome da instituição, sobrenome, celular, CNPJ, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi efetuado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Verificar se após logar, a instituição consegue realizar o cadastro de seus alunos. |
|	Requisito Associado 	| RF-002 - Verificar se após logar, a instituição consegue realizar o cadastro de seus alunos.|
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://https://padrin.ly//src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar em "Registro de alunos" <br> Preencher os campos obrigatórios (e-mail, nome, sobrenome e CPF) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar aluno" <br> |
|Critério de Êxito |- O cadastro foi efetuado com sucesso. |

 | **Caso de Teste** 	| CT-03 – Cadastro de Apadrinhadores (Pessoa física) 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - O usuário doador/apadrinhador (pessoa fisica) se cadastrará no site. |
| Objetivo do Teste 	| Verificar se apdrinhadores conseguem efetuar o cadastro no site. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://https://padrin.ly//src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome da instituição, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi efetuado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-04 – Efetuar Login	|
|Requisito Associado | RF-004	- O usuário irá efetuar login no site. |
| Objetivo do Teste 	| Verificar se usuários conseguem efetuar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://https://padrin.ly//src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> |
|Critério de Êxito | - O login foi efetuado com sucesso.  |
|  	|  	|
| **Caso de Teste** 	| CT-05 – Gerenciar Alunos Vinculados 	|
|	Requisito Associado 	| RF-005 - As instituições cadastradas devem ter a capacidade de gerenciar alunos vinculados a elas |
| Objetivo do Teste 	| Verificar se o usuário (instituição) consegue gerenciar alunos vinculados. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://https://padrin.ly//src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar no botão "Gerenciar alunos" <br> |
|Critério de Êxito | - Foi possível gerenciar os dados do aluno |
|  	|  	|
| **Caso de Teste** 	| CT-06 – Administrador do site deve conseguir gerenciar as Insituições 	|
|	Requisito Associado 	| RF-006 - O administrador do site deve ter a capacidade de gerenciar as instituições vinculadas |
| Objetivo do Teste 	| Garantir que o administrador do site possa gerenciar efetivamente as instituições vinculadas, incluindo adição, remoção e edição. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://https://padrin.ly//src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar no botão "Gerenciar insituições" <br> |
|Critério de Êxito | - Foi possível gerenciar os dados das instituições. |
|  	|  	|
| **Caso de Teste** 	| CT-07 – Usuário aluno deve conseguir postar textos e imagens na plataforma. 	|
|	Requisito Associado 	| RF-007 - O usuário aluno irá publicar textos e/ou imagens em seu mural |
| Objetivo do Teste 	| Assegurar que o usuário aluno consiga publicar textos e/ou imagens no seu mural de forma correta e eficiente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://https://padrin.ly//src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" <br> - Clicar no botão "Ver Perfil" <br> - Clicar no botão "Postar" <br> |
|Critério de Êxito | - Foi possível publicar um texto ou imagem. |
|  	|  	|



> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
