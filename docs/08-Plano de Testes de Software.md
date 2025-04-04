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
| Caso de Teste 	| **CT06 – Cadastro e Gestão de Clientes**	|
|Requisito Associado | RF-006 - O sistema deverá permitir o cadastro e a gestão de clientes, incluindo nome, contato e histórico de compras. |
| Objetivo do Teste 	| Verificar se o sistema permite cadastrar e gerenciar informações de clientes, incluindo histórico de compras. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Navegar até a seção de cadastro de clientes. 3.	Cadastrar um novo cliente. 4.	Salvar o cadastro e verificar se foi registrado corretamente. 5.	Editar informações do cliente cadastrado. 6.	Verificar o histórico de compra. 7.	Buscar clientes por diferentes critérios. |
|Critério de Êxito | O sistema permite cadastrar e gerenciar informações de clientes corretamente, mantendo histórico atualizado de compras e permitindo consultas por diferentes critérios.|
| Caso de Teste 	| **CT07 – Alertas para Estoque Mínimo**	|
|Requisito Associado | RF-007 - O sistema deverá gerar alertas automáticos para produtos com estoque abaixo do nível mínimo definido. |
| Objetivo do Teste 	|Verificar se o sistema identifica e alerta sobre produtos com estoque abaixo do nível mínimo. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Cadastrar ou editar um produto definindo um nível mínimo de estoque. 3.	Registrar saídas do produto até que o estoque fique abaixo do nível mínimo definido. 4.	Verificar se o sistema exibe alerta visual na interface, adiciona o produto à lista de produtos com estoque baixo e envia notificação (se aplicável). 5.	Verificar se existe uma seção consolidada para visualizar todos os produtos com estoque baixo. |
|Critério de Êxito |O sistema identifica corretamente produtos com estoque abaixo do nível mínimo e gera alertas adequados para informar os usuários. |
| Caso de Teste 	| **CT08 – Transferência de Estoque Interna**	|
|Requisito Associado |RF-008 - O sistema deve permitir a transferência de estoque interna. |
| Objetivo do Teste 	| Verificar se o sistema permite realizar transferências de produtos entre diferentes locais ou departamentos internos. |
| Passos 	|1.	Acessar o sistema com credenciais válidas. 2.	Navegar até a seção de transferência de estoque. 3.	Selecionar a origem (local/departamento atual do produto). 4.	Selecionar o destino da transferência. 5.	Adicionar os produtos a serem transferidos com suas quantidades. 6.	Confirmar a transferência. 7.	Verificar se o estoque foi atualizado corretamente em ambos os locais. 8.	Verificar o registro da transferência no histórico de movimentações. |
|Critério de Êxito | O sistema permite realizar transferências internas de estoque, atualizando corretamente as quantidades nos locais de origem e destino, e mantendo registro da operação. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
