# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve permitir que os usuários realizem cadastro do seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar corretamente no sistema. |
| Passos 	| 01. Acessar a página de cadastro. 02. Preencher os campos obrigatórios (nome, email, senha e confirmação de senha). 03. Clicar no botão "Cadastrar". 04. Verificar se o sistema exibe uma mensagem de sucesso. 05. Tentar fazer login com as credenciais recém-criadas. |
|Critério de Êxito | O sistema exibe uma mensagem de sucesso após o cadastro. O usuário consegue fazer login com as credenciais cadastradas. |
|  	|  	|
| Caso de Teste 	| **CT02 – Consulta de Itens no Estoque**	|
|Requisito Associado | RF-002 - O sistema deverá permitir a consulta de itens cadastrados no estoque, exibindo a quantidade disponível dos mesmos. |
| Objetivo do Teste 	| Garantir que os usuários possam visualizar os produtos cadastrados e suas respectivas quantidades. |
| Passos 	| 01. Acessar a seção de estoque do sistema. 02. Pesquisar um produto pelo nome ou código. 03. Verificar se as informações de quantidade disponível e detalhes do produto são exibidas corretamente. |
|Critério de Êxito | O sistema exibe corretamente os produtos cadastrados e suas respectivas quantidades disponíveis. |
|  	|  	|
| Caso de Teste 	| **CT03 – Entrada e Saída de Produtos no Estoque**	|
|Requisito Associado | RF-003 - O sistema deverá permitir que o usuário realize a entrada e saída de produtos. |
| Objetivo do Teste 	| Validar se o sistema permite registrar corretamente a movimentação do estoque. |
| Passos 	| 01. Acessar a seção de gerenciamento de estoque. 02. Selecionar um produto cadastrado. 03. Inserir uma quantidade para entrada no estoque e confirmar. 04. Inserir uma quantidade para saída no estoque e confirmar. 05. Verificar se a quantidade total é atualizada corretamente. |
|Critério de Êxito | O sistema atualiza corretamente a quantidade de estoque após cada operação. |
|  	|  	|
| Caso de Teste 	| **CT04 – Cadastro de Produtos**	|
|Requisito Associado | RF-004 - O sistema deverá permitir o cadastro de produtos com nome, descrição, preço de entrada e saída. |
| Objetivo do Teste 	| Garantir que os usuários possam cadastrar novos produtos corretamente. |
| Passos 	| 01. Acessar a seção de cadastro de produtos. 02. Preencher os campos obrigatórios (nome, descrição, preço de entrada, preço de saída). 03. Clicar no botão "Cadastrar Produto". 04. Verificar se o produto foi salvo corretamente e aparece na listagem do estoque. |
|Critério de Êxito | O produto é cadastrado com sucesso e aparece na lista de produtos disponíveis. |
|  	|  	|
| Caso de Teste 	| **CT05 – Geração de Relatório Financeiro Mensal**	|
|Requisito Associado | RF-005 - O sistema deverá gerar relatórios financeiros mensais, apresentando receitas, despesas e lucro líquido. |
| Objetivo do Teste 	| Verificar se o sistema gera corretamente os relatórios financeiros com receitas, despesas e lucro líquido. |
| Passos 	| 01. Acessar a seção de relatórios financeiros. 02. Selecionar um mês específico para gerar o relatório. 03. Clicar no botão "Gerar Relatório". 04. Verificar se os dados de receitas, despesas e lucro líquido são exibidos corretamente. 05. Testar a exportação do relatório em formatos PDF e CSV. |
|Critério de Êxito | O relatório financeiro é gerado corretamente com os valores esperados. O usuário pode visualizar e exportar o relatório. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
